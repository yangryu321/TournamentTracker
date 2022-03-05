using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


	
namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDateConnection
    {


        /// <summary>
        /// Steps to setup a connection to SQL database using Dapper (save data to SQL) 
        /// 0.Create a Dapper ORM in References(.dll)
        /// 1.Declare a connection string in APP.config
        /// 2.Create a connection using the connectionString
        /// 3.Create a DynamicParameter object to store the data you want to save to the database
        /// 4.Use connection.excute() to call a StoredProcedure using the DynamicParameter object as a parameter
        /// 5.Get the id of the data in the database using p.get<int>("@id")
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel createPrize(PrizeModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_SavePrize", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");

                return model;


            }
        }



        public PersonModel createPerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.Firstname);
                p.Add("@LastName", model.Lastname);
                p.Add("@EmailAddress", model.Emailaddress);
                p.Add("@CellPhoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_SavePersonInfo", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
               
            }

            return model;
        }


        public List<PersonModel> Get_All_Person()
        {
            List<PersonModel> people = new List<PersonModel>();

            using (IDbConnection connection=new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                //call the StoredProcedure to get all people in the database

                people = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();

            }


            return people;
            
        }

        public TeamModel createTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {

                //save teamName and ID
                var p = new DynamicParameters();
                p.Add("@TeamName",model.TeamName);
                p.Add("@id",0,dbType:DbType.Int32,direction:ParameterDirection.Output);

                connection.Execute("dbo.spTeam_SaveTeam", p, commandType: CommandType.StoredProcedure);
                model.Id= p.Get<int>("@id");


                //save teamId and personId
                foreach (PersonModel person in model.TeamMembers )
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", person.Id);
                   

                    connection.Execute("dbo.spTeamMembers_SaveTeamAndMembers", p, commandType: CommandType.StoredProcedure);

                }

            }

            return model;
        }

        public List<TeamModel> Get_ALL_Team()
        {
            List<TeamModel> teams = new List<TeamModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {

                teams=connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach(var team in teams)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",p,commandType:CommandType.StoredProcedure).ToList();
                }
            }

                return teams;
        }

        public TournamentModel createTournament(TournamentModel model)
        {

            using (IDbConnection connection=new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                //save tournament name and entryfee
                var p = new DynamicParameters();
                p.Add("@TournamentName", model.TournamentName);
                p.Add("@EntryFee", model.EntryFee);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                //create insert tournament sp

                connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");


                //save tournament id and prize id 
                foreach (var t in model.Prizes)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId",model.Id);
                    p.Add("@PrizeId", t.Id);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                }    


                //save tournament id and team id
                foreach(var t in model.EnteredTeams)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@TeamId", t.Id);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);

                }


                //model.Rounds
               

                foreach (List<MatchupModel> round in model.Rounds)
                {
                    foreach (MatchupModel matchup in round)
                    {
                        //save matchups info to sql
                        //save id, Matchupentries id, winner team id, matchupround
                        p = new DynamicParameters();
                        p.Add("@TournamentId", model.Id);
                        p.Add("@MatchupRound", matchup.MatchupRound);
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("dbo.spMatchup_Insert", p, commandType: CommandType.StoredProcedure);
                        matchup.Id = p.Get<int>("@id");

                        foreach (MatchupEntryModel matchupEntry in matchup.Entries)
                        {
                            //save matchupentries info to sql(there is 2)

                            //if the team is not a bot, save the info to database
                            if(matchupEntry!=null)
                            {
                                //save id, teamCompetingid, score, parentmatchupid, matchupid
                                p = new DynamicParameters();
                                p.Add("@MatchupId", matchup.Id);

                                //if the matchupentry is from the 1st round, it doesnt have a parentMatchupid
                                if(matchupEntry.ParentMatchup==null)
                                {
                                    p.Add("@ParentMatchupId", null);
                                }
                                else
                                {
                                    p.Add("@ParentMatchupId", matchupEntry.ParentMatchup.Id);
                                }
                                
                                //if the matchupentry is from the 2nd round and so on, it doenst have a team competing yet
                                if(matchupEntry.TeamCompeting==null)
                                {
                                    p.Add("@TeamCompetingId", null);
                                }
                                else
                                {
                                    p.Add("@TeamCompetingId", matchupEntry.TeamCompeting.Id);
                                }
                               
                                
                                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                                //dbo.spMatchupEntries_Insert
                               
                                connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                                matchupEntry.Id= p.Get<int>("@id");

                            }
                        }



                    }

                }
            }



                return model;
        }

        public List<TournamentModel> Get_ALL_Tournaments()
        {
            List<TournamentModel> tournaments = new List<TournamentModel>();
            List<MatchupModel> allMatchupsofthisTournament = new List<MatchupModel>();
            List<MatchupModel> round = new List<MatchupModel>();
            int max_round = 0;
            int count = 1;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                tournaments = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                //fill up rounds first
                foreach (var tournament in tournaments)
                {
                    //get all the matchup of this tournament
                    allMatchupsofthisTournament=connection.Query<MatchupModel>("dbo.spMatchup_GetAll").Where(x=>x.TournamentId==tournament.Id).ToList();
                    //get the biggest round number of the tournament
                    max_round = allMatchupsofthisTournament.OrderByDescending(x => x.MatchupRound).First().MatchupRound;
                    while (count<=max_round)
                    {
                        round = allMatchupsofthisTournament.Where(x => x.MatchupRound == count).ToList();
                        count++;
                        tournament.Rounds.Add(round);
                    }
                    count = 1;

                    //fill up matchup entries
                    foreach (var r in tournament.Rounds)
                    {
                        foreach (var matchup in r)
                        {
                            //Q:so here right now have the teamcompeting id but its in int form, and the team competing id is in teammodel form so cant convert
                            //A:Just add another property in matchupentry model called TeamCompetingId(name has to be the same with the one in sql database, apparently thats how it works)
                            matchup.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetAll").Where(x => x.MatchupId == matchup.Id).ToList();

                            //fill up winner team if there is one
                            if (matchup.WinnerId != null)
                                matchup.Winner = GlobalConfig.connection.Get_ALL_Team().Where(x => x.Id == int.Parse(matchup.WinnerId)).First();

                            //fill up teammodel
                            foreach (var entry in matchup.Entries)
                            {
                                if (entry.TeamCompetingId != 0)
                                    entry.TeamCompeting = GlobalConfig.connection.Get_ALL_Team().Where(x => x.Id == entry.TeamCompetingId).First();
                                else
                                    entry.TeamCompeting = null;
                                
                            }
        

                        }

                    }



                }
 

            }
            return tournaments;
        }

        public void Update(MatchupModel model)
        {
            Console.WriteLine($"{model.Winner.TeamName}");
            //update current match
            //including winner
            //what about matchups with one bot? It's supposed to be updated automatically, which means you dont have to click the button to 
            //update it, which means it can not be in the score_button click method?

            using (IDbConnection connection= new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                //update current match winner
                var p = new DynamicParameters();
                p.Add("id",model.Id);
                p.Add("WinnerId", model.Winner.Id.ToString());

                connection.Execute("dbo.spMatchup_Update", p, commandType: CommandType.StoredProcedure);

                //update matchup entries of the current matchup
                foreach (var entry in model.Entries)
                {
                    p = new DynamicParameters();
                    p.Add("id",entry.Id);
                    p.Add("Score",entry.Score);

                    connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                }

                //update one of the two matchupentries of the matchup of next round where its parent matchup is the current matchup
                //set its teamcompeting to the winner team
                p = new DynamicParameters();
                p.Add("ParentMatchupId",model.Id);
                p.Add("TeamCompetingId",model.Winner.Id);
                connection.Execute("dbo.spMatchupEntries_Update_teamCompeting", p, commandType: CommandType.StoredProcedure);


            }

            
        }
    }
}
