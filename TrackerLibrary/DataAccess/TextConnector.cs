using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.extension_methods;
namespace TrackerLibrary.DataAccess
{
    /// <summary>
    /// Steps to save data to textfile database
    /// 0.Create a connection
    /// 1.Read data from textfile data base first
    /// 2.Generate a new ID
    /// 3.Create a new dateModel using the new ID
    /// 4.Save model to textfile 
    /// </summary>
    public class TextConnector : IDateConnection
    {
        private const string PrizeTextFile = "PrizeModels.csv";
        private const string PeopleTextFile = "PeopleModels.csv";
        private const string TeamTextFile = "TeamModels.csv";
        private const string TeamAndMembersFile = "TeamAndMembersFile.csv";
        private const string TournamentFile = "TournamentModels.csv";
     
        private const string MatchupEntryFile = "MatchupEntryModel.csv";
        private const string MatchupFile = "MatchupModel.csv";



        public PrizeModel createPrize(PrizeModel model)
        {
           
            List<PrizeModel> prizeModels = PrizeTextFile.Fullfilepath().LoadFile().ConvertToPrizeModel();

            if(prizeModels!=null&&!prizeModels.Any())
            {
                //Console.WriteLine("NO TEXT FILE FOUND");
                model.Id = 1;
            }
            else
            {
                model.Id = prizeModels.OrderByDescending(x => x.Id).First().Id + 1; //Orderby() doesnt mutate the list?
            }

            
            prizeModels.Add(model);//add to the end of a list so if you have 3 item in list already the sequence is like 3 2 1 4?


            prizeModels.SavePrizesToTextFile(PrizeTextFile);

            return model;


        }



        public PersonModel createPerson(PersonModel model)
        {
            
            
            List<PersonModel> personModels = PeopleTextFile.Fullfilepath().LoadFile().ConvertToPersonModel();
           

            if(personModels!=null&&!personModels.Any())
            {
                model.Id = 1;
            }
            else
            {
                model.Id = personModels.OrderByDescending(x => x.Id).First().Id + 1;
            }

            personModels.Add(model);

            personModels.SavePersonToTextFile(PeopleTextFile);
            return model;

        }

        public List<PersonModel> Get_All_Person()
        {
            List<PersonModel> people = new List<PersonModel>();
            people = PeopleTextFile.Fullfilepath().LoadFile().ConvertToPersonModel();

            return people;
        }

        public TeamModel createTeam(TeamModel model)
        {
           
            List<TeamModel> teams = TeamTextFile.Fullfilepath().LoadFile().ConvertToTeamModel(PeopleTextFile, TeamAndMembersFile);

            if(teams!=null&&!teams.Any())
            {
                Console.WriteLine("NO TEAMS FOUND");
                model.Id = 1;
            }
            else
            {
                model.Id = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            teams.Add(model);

            teams.SaveTeamToTextFile(TeamTextFile, TeamAndMembersFile);

            //Is it to read or to save?
            //teammodel.scv teammembers.scv
            //you need both teammodel.scv and teammembers.scv
            //beacause you each fine has its own id and it's independent from each other?
            //But I dont have a TeamMember model, do I have to creat a new class just for that?


            return model;
            
        }

        public List<TeamModel> Get_ALL_Team()
        {
             List<TeamModel> teams = TeamTextFile.Fullfilepath().LoadFile().ConvertToTeamModel(PeopleTextFile, TeamAndMembersFile);

            return teams;
        }

        public TournamentModel createTournament(TournamentModel model)
        {

            List<TournamentModel> tournaments = TournamentFile.Fullfilepath().LoadFile().ConvertToTournamentModel(PrizeTextFile,MatchupFile);

            if(tournaments!=null&&!tournaments.Any())
            {
                model.Id = 1;

            }
            else
            {
                model.Id = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            tournaments.Add(model);
            model.SaveRoundToTextFile(MatchupEntryFile, MatchupFile);
            

            tournaments.SaveTournamentToTextFile(TournamentFile);


            return model;
         
        }

        public List<TournamentModel> Get_ALL_Tournaments()
        {
            return TournamentFile.Fullfilepath().LoadFile().ConvertToTournamentModel(PrizeTextFile, MatchupFile);
        }

        public void Update(MatchupModel model)
        {

            Console.WriteLine($"{model.Winner.TeamName}");

            //read data from text file database and convert it to List<Matchupmodel>
            List<MatchupModel> AllMatchups = MatchupFile.Fullfilepath().LoadFile().ConvertToMatchupModel();

            List<MatchupEntryModel> AllMatchupEntries = MatchupEntryFile.Fullfilepath().LoadFile().ConvertToMatchupEntryModel();

            MatchupEntryModel matchupEntry = new MatchupEntryModel();
            //stuff to update
            //1.matchup winner of current matchup

            //look for current matchup by id and update winner team
            AllMatchups.Where(x => x.Id == model.Id).First().Winner = model.Winner;

            //write it back to file database
            AllMatchups.SaveMatchupToTextFile(MatchupFile);


            //2.matchup entries(2)
            //update score
            foreach (var entry in model.Entries)
            {

                matchupEntry = AllMatchupEntries.Where(x => x.Id == entry.Id).First();
                matchupEntry.Score = entry.Score;

            }

            //write it back to file database
            AllMatchupEntries.UpdateMatchupEntryToTextFile(MatchupEntryFile);


            AllMatchups = MatchupFile.Fullfilepath().LoadFile().ConvertToMatchupModel();
            AllMatchupEntries = MatchupEntryFile.Fullfilepath().LoadFile().ConvertToMatchupEntryModel();
            
            //3.matchupentry where the parent matchup is the current matchup
            //update matchupentry of that matchup
            foreach (var entry in AllMatchupEntries)
            {
                
                if (entry.ParentMatchup != null && entry.ParentMatchup.Id == model.Id)
                {
                    entry.TeamCompeting = model.Winner;
                    if (AllMatchups.Where(x => x.Id == entry.MatchupId).First().Entries[0].TeamCompeting == null)
                        AllMatchups.Where(x => x.Id == entry.MatchupId).First().Entries[0] = entry;
                    else
                        AllMatchups.Where(x => x.Id == entry.MatchupId).First().Entries[1] = entry;

                   
                }
                   
                    

            }
            //write it back to file database
            AllMatchupEntries.UpdateMatchupEntryToTextFile(MatchupEntryFile);
            AllMatchups.SaveMatchupToTextFile(MatchupFile);





        }
    }


}
