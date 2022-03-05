using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.extension_methods
{
    public static class TextConnector_ExtensionMethods
    {
        private const string MatchupFile = "MatchupModel.csv";
        private const string MatchupEntryFile = "MatchupEntryModel.csv";




        public static string Fullfilepath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filepath"]}\\{fileName}";

        }


        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();


        }


        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> prizeModel = new List<PrizeModel>();

            foreach (var line in lines)
            {
                List<string> model = line.Split(',').ToList();
                PrizeModel singleModel = new PrizeModel();

                singleModel.Id = int.Parse(model[0]);
                singleModel.PlaceNumber = int.Parse(model[1]);
                singleModel.PlaceName = model[2];
                singleModel.PrizeAmount = decimal.Parse(model[3]);
                singleModel.PrizePercentage = double.Parse(model[4]);
                prizeModel.Add(singleModel);

            }

            return prizeModel;

        }


        public static void SavePrizesToTextFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (var model in models)
            {
                lines.Add($"{model.Id},{ model.PlaceNumber},{model.PlaceName},{model.PrizeAmount},{model.PrizePercentage}");
            }

            File.WriteAllLines(fileName.Fullfilepath(), lines);
        }




        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();

            foreach (var line in lines)
            {
                List<string> model = line.Split(',').ToList();

                PersonModel singleModel = new PersonModel();
                singleModel.Id = int.Parse(model[0]);
                singleModel.Firstname = model[1];
                singleModel.Lastname = model[2];
                singleModel.Emailaddress = model[3];
                singleModel.CellphoneNumber = model[4];

                personModels.Add(singleModel);

            }

            return personModels;

        }


        public static void SavePersonToTextFile(this List<PersonModel> people, string filename)
        {
            List<string> lines = new List<string>();

            foreach (var p in people)
            {
                lines.Add($"{p.Id},{p.Firstname},{p.Lastname},{p.Emailaddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(filename.Fullfilepath(), lines);
        }


        public static List<TeamModel> ConvertToTeamModel(this List<string> teamModelsFile, string PeopleFile, string teamAndMembersFile)
        {
            List<TeamModel> teams = new List<TeamModel>();
            List<PersonModel> personModels = PeopleFile.Fullfilepath().LoadFile().ConvertToPersonModel();
            List<string> teamAndMembers = teamAndMembersFile.Fullfilepath().LoadFile();


            foreach (var line in teamModelsFile)
            {
                List<string> model = line.Split(',').ToList();

                TeamModel singleModel = new TeamModel();
                singleModel.Id = int.Parse(model[0]);
                singleModel.TeamName = model[1];


                teams.Add(singleModel);
            }
            //TODO--It's really confusing here, might change it later on
            for (int i = 0; i < teamAndMembers.Count(); i++)
            {
                //convert from format 1|2|3 to List<PersonModel> TeamMembers
                List<string> model = teamAndMembers[i].Split(',').ToList();
                string[] TeamMembers = model[2].Split('|');
                foreach (string t in TeamMembers)
                {

                    teams[i].TeamMembers.Add(personModels.Where(x => x.Id == int.Parse(t)).First());

                }


            }



            return teams;
        }

        public static void SaveTeamToTextFile(this List<TeamModel> teams, string filename, string filename2)
        {
            List<string> linesForTeamModelFile = new List<string>();
            List<string> linesForTeamMembersFile = new List<string>();

            foreach (var p in teams)
            {
                linesForTeamModelFile.Add($"{p.Id},{p.TeamName}");
                linesForTeamMembersFile.Add($"{p.Id},{p.Id},{ConvertMemberNamesTo(p.TeamMembers)}");
            }

            File.WriteAllLines(filename.Fullfilepath(), linesForTeamModelFile);
            File.WriteAllLines(filename2.Fullfilepath(), linesForTeamMembersFile);

        }

        public static void SaveRoundToTextFile(this TournamentModel tournament, string MatchupEntryFile, string MatchupFile)
        {

            //loop through round in rounds in tournament
            //loop through matches in round
            //loop through entries in match


            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach (MatchupModel match in round)
                {
                    //save matchup info to textfile
                    //open matchup file 
                    //id,matchupentries_id(2),winner_id,matchupround
                    List<MatchupModel> matchupModels = MatchupFile.Fullfilepath().LoadFile().ConvertToMatchupModel();
                    int ID = 0;
                    if (matchupModels != null && !matchupModels.Any())
                    {
                        ID = 1;
                    }
                    else
                    {
                        ID = matchupModels.OrderByDescending(x => x.Id).First().Id + 1;
                    }

                    match.Id = ID;
                    
                    //Until this step, you dont know the matchupentries id yet.



                    foreach (MatchupEntryModel matchupEntry in match.Entries)
                    {
                        //save matchupentry info to textfile
                        //open matchupentry file
                        List<MatchupEntryModel> matchupEntryModels = MatchupEntryFile.Fullfilepath().LoadFile().ConvertToMatchupEntryModel();
                        int Id = 0;
                        if (matchupEntryModels != null && !matchupEntryModels.Any())
                        {
                            Id = 1;
                        }
                        else
                        {
                            Id = matchupEntryModels.OrderByDescending(x => x.Id).First().Id + 1;
                        }
                        matchupEntry.MatchupId = ID;
                        matchupEntry.Id = Id;
                        matchupEntryModels.Add(matchupEntry);
                        matchupEntryModels.SaveMatchupEntryToTextFile(MatchupEntryFile);
                        matchupEntryModels = new List<MatchupEntryModel>();


                    }
                    matchupModels.Add(match);
                    matchupModels.SaveMatchupToTextFile(MatchupFile);
                    matchupModels = new List<MatchupModel>();
                }

            }

        }


        //1,2|3,null,1
        //3,2|1,null,2
        //2,1|,null,1
        //2,|,null,1
        
        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {
            List<MatchupModel> matchupModels = new List<MatchupModel>();
            MatchupModel singlemodel = new MatchupModel();
            List<string> model = new List<string>();
            List<string> teams = new List<string>();
            MatchupEntryModel entry = new MatchupEntryModel();
            foreach (var line in lines)
            {
                model = line.Split(',').ToList();
                singlemodel.Id = int.Parse(model[0]);

                teams = model[1].Split('|').ToList();

                foreach (var team in teams)
                {
                    if (team != "")
                    {
                        if (team != "null")
                            entry.TeamCompeting = GlobalConfig.connection.Get_ALL_Team().Where(x => x.Id == int.Parse(team)).First();
                        else
                            entry.TeamCompeting = null;
                        singlemodel.Entries.Add(entry);
                        entry = new MatchupEntryModel();
                    }


                }


                if (model[2]=="null")
                {
                    singlemodel.Winner = null;
                }
                else
                {
                    singlemodel.Winner= GlobalConfig.connection.Get_ALL_Team().Where(x => x.Id == int.Parse(model[2])).First();
                }

                singlemodel.MatchupRound = int.Parse(model[3]);


               // singlemodel.Entries = MatchupEntryFile.Fullfilepath().LoadFile().ConvertToMatchupEntryModel().Where(x => x.Id == singlemodel.Id).ToList();

                matchupModels.Add(singlemodel);

                singlemodel = new MatchupModel();

            }



            return matchupModels;
        }

        //1,2|3,null,1
        //3,2|1,null,2
        public static void SaveMatchupToTextFile(this List<MatchupModel> matchupModels, string filename)
        {
            List<string> lines = new List<string>();

            foreach (var matchup in matchupModels)
            {
                if (matchup.Winner != null)
                    lines.Add($"{matchup.Id},{ConverMatchupentryTo(matchup.Entries)},{matchup.Winner.Id},{matchup.MatchupRound}");
                else
                    lines.Add($"{matchup.Id},{ConverMatchupentryTo(matchup.Entries)},{"null"},{matchup.MatchupRound}");
            }


            File.WriteAllLines(filename.Fullfilepath(), lines);

        }

        public static string ConverMatchupentryTo(List<MatchupEntryModel> matchupEntryModels)
        {

            string lines = "";

           
            foreach (var entry in matchupEntryModels)
            {
                if (entry.TeamCompeting != null)
                    lines += $"{entry.TeamCompeting.Id}|";
                else
                    lines += $"{"null"}|";
            }

            if (lines=="")
            {
                return lines;
            }
            else
            {
                if (matchupEntryModels.Count() > 1)
                    lines = lines.Substring(0, lines.Length - 1);
                else
                    return lines;
            }


            return lines;


        }


        //{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{matchupentrymodel.Score},{matchupentrymodel.ParentMatchup.Id}
        //1,1,1,null,null
        //or 1,1,null,null,null, means this is a bot
        //1,1,1,1,1 if the score and parentmatchup is updated
        public static List<MatchupEntryModel> ConvertToMatchupEntryModel(this List<string> lines)
        {
            List<MatchupEntryModel> matchupEntryModels = new List<MatchupEntryModel>();
            MatchupEntryModel matchupEntry = new MatchupEntryModel();
            MatchupModel parentmatchup = new MatchupModel();
            List<string> model;
            foreach (var line in lines)
            {
                model = line.Split(',').ToList();
                matchupEntry.Id = int.Parse(model[0]);
                matchupEntry.MatchupId = int.Parse(model[1]);
                if (model[2] == "null"||model[2]=="bot")
                    matchupEntry.TeamCompeting = null;
                else 
                    matchupEntry.TeamCompeting= GlobalConfig.connection.Get_ALL_Team().Where(x => x.Id == int.Parse(model[2])).First();
                if (model[3] != "null")
                    matchupEntry.Score = int.Parse(model[3]);


                if (model[4] == "null")
                    matchupEntry.ParentMatchup = null;
                else
                {
                    parentmatchup.Id = int.Parse(model[4]);
                  
                   
                    matchupEntry.ParentMatchup = parentmatchup;
                    //have to refreash parentmatchup id here because if you dont, the next time parenmactchupid changes, its pointing to
                    //last matchup entry's parentmatchup where the value is gonna change because parentmatchup is a pointer
                    //so even if you refresh matchupentry, the parent matchup still points to the last matchupentry
                    parentmatchup = new MatchupModel();
                }

                matchupEntryModels.Add(matchupEntry);
                matchupEntry = new MatchupEntryModel();
            }



            return matchupEntryModels;
        }

        public static void SaveMatchupEntryToTextFile(this List<MatchupEntryModel> matchupEntryModels,string filename)
        {
            List<string> lines = new List<string>();
            

            foreach (var matchupentrymodel in matchupEntryModels)
            {
                //so for the very first entry, it should look like this in textfile 1,1,1,null,null
     
                    if(matchupentrymodel.TeamCompeting!=null)
                    {
                    //here depends on the game rule you can change the score condition
                    //if the winner is decided than record score
                    //    if (All_Matchups.Count()!=0)
                    //    {
                    //         if (All_Matchups.Where(x => x.Id == matchupentrymodel.MatchupId).First().Winner != null)
                    //            lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{matchupentrymodel.Score},{"null"}");
                    //    }
                 
                    ////if not then score is null
                    //     else
                            lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{"null"},{"null"}");
                    }
                    else
                        lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{"null"},{"null"},{matchupentrymodel.ParentMatchup.Id}");
                
            }
            File.WriteAllLines(filename.Fullfilepath(), lines);
        }


        public static void UpdateMatchupEntryToTextFile(this List<MatchupEntryModel> matchupEntryModels, string filename)
        {
            List<string> lines = new List<string>();
            List<MatchupModel> All_Matchups = MatchupFile.Fullfilepath().LoadFile().ConvertToMatchupModel();

            foreach (var matchupentrymodel in matchupEntryModels)
            {
                if(matchupentrymodel.TeamCompeting!=null)
                {
                    //if the matchup has more than 1 team which means it's a normal matchup then you can put a score and there is a winner
                    if (All_Matchups.Where(x => x.Id == matchupentrymodel.MatchupId).First().Entries.Count() > 1 && All_Matchups.Where(x => x.Id == matchupentrymodel.MatchupId).First().Winner != null)
                        if (matchupentrymodel.ParentMatchup != null)
                            lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{matchupentrymodel.Score},{matchupentrymodel.ParentMatchup.Id}");
                        else
                            lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{matchupentrymodel.Score},{"null"}");
                    //else it's still null
                    else
                    {
                        if (matchupentrymodel.ParentMatchup == null)
                            lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{"null"},{"null"}");
                        else
                            lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{matchupentrymodel.TeamCompeting.Id},{"null"},{matchupentrymodel.ParentMatchup.Id}");


                    }

                }
                else
                {
                    lines.Add($"{matchupentrymodel.Id},{matchupentrymodel.MatchupId},{"null"},{"null"},{matchupentrymodel.ParentMatchup.Id}");
                }

            }

            File.WriteAllLines(filename.Fullfilepath(), lines);

        }

        //format membernames to 1|2|3 format 
        private static string ConvertMemberNamesTo(List<PersonModel> People)
        {
            string lines = "";


            foreach(PersonModel p in People)
            {
                lines += $"{p.Id}|";

            }

            if (lines == "")
            {
                return lines;
            }
            else
            {
                lines = lines.Substring(0, lines.Length - 1);
            }

            return lines;
        }


        public static List<TournamentModel> ConvertToTournamentModel(this List<string> lines,string prizeFile,string matchupFile)
        {
            List<TournamentModel> tournaments = new List<TournamentModel>();
            //get all the teams
            List<TeamModel> AllTeams = GlobalConfig.connection.Get_ALL_Team();
            //get all the prizes
            List<PrizeModel> AllPrizes = prizeFile.Fullfilepath().LoadFile().ConvertToPrizeModel();
            //id,TournamentName,EntryFee,EnteredTeams,Prizes,Rounds
            //id,TournamentName,EntryFee,1|2|3,1|2|3,1*2*3|4*5*6--what each line looks like in textfile
            List<MatchupModel> AllMatchups = matchupFile.Fullfilepath().LoadFile().ConvertToMatchupModel();

            List<MatchupEntryModel> AllMatchupentries = MatchupEntryFile.Fullfilepath().LoadFile().ConvertToMatchupEntryModel();

            foreach (var line in lines)
            {
                TournamentModel tournament = new TournamentModel();
                List<string> model = line.Split(',').ToList();

                tournament.Id = int.Parse(model[0]);//here use int.parse instead of int.tryparse 
                tournament.TournamentName = model[1];
                tournament.EntryFee = decimal.Parse(model[2]);

                List<string> enteredTeams = model[3].Split('|').ToList();
                foreach(var Id_number in enteredTeams)
                {
                    tournament.EnteredTeams.Add(AllTeams.Where(x => x.Id == int.Parse(Id_number)).First());

                }

                List<string> EnteredPrizes = model[4].Split('|').ToList();
                foreach(var Id_Number in EnteredPrizes)
                {
                    tournament.Prizes.Add(AllPrizes.Where(x => x.Id == int.Parse(Id_Number)).First());
                }


                //id,TournamentName,EntryFee,1|2|3,1|2|3,1*2*3|4*5*6--what each line looks like in textfile
                //I think theres gonna be a matchupentries file.csv 
                List<string> EnteredRounds = model[5].Split('|').ToList();
                List<string> matchupsInEachRound = new List<string>();
                List<MatchupModel> Round = new List<MatchupModel>();
                MatchupEntryModel matchupEntry = new MatchupEntryModel();
                MatchupModel _model = new MatchupModel();
                foreach (var eachRound in EnteredRounds)
                {
                    //get the id of matchups here
                    if (eachRound.Contains('*'))
                        matchupsInEachRound = eachRound.Split('*').ToList();
                    else
                        matchupsInEachRound.Add(eachRound);
                    //search matchups by id here 
                    //1*2*3
                    foreach (var matchid in matchupsInEachRound)
                    {
                        //fill up matchup

                        if(matchid!="")
                        {
                            _model = AllMatchups.Where(x => x.Id == int.Parse(matchid)).First();
                            _model.Entries = AllMatchupentries.Where(x => x.MatchupId == int.Parse(matchid)).ToList();
                            Round.Add(_model);
                            _model = new MatchupModel();
                        }
                            

                    }
 
                    tournament.Rounds.Add(Round);
                    Round = new List<MatchupModel>();
                    matchupsInEachRound = new List<string>();
                }



                tournaments.Add(tournament);

            }


            
            return tournaments;
        }

    
        public static List<TournamentModel> SaveTournamentToTextFile(this List<TournamentModel> tournaments,string tournamentsFile)
        {

            //id,TournamentName,EntryFee,1|2|3,1|2|3,1*2*3|4*5*6--what each line looks like in textfile
            //1,name,10,1|2|3(teamid),1|2|3(prizes),1*2*3|4*5*6(matchupid)
            List<string> lines = new List<string>();
            foreach (var tournament in tournaments)
            {
                lines.Add($"{tournament.Id}," +
                    $"{tournament.TournamentName}," +
                    $"{tournament.EntryFee}," +
                    $"{ConvertTeamsto(tournament.EnteredTeams)},"+
                    $"{ConvertPrizesto(tournament.Prizes)},"+
                    $"{ConvertRoundsto(tournament.Rounds)}"
                    );

            }
            //save to textfile here
            File.WriteAllLines(tournamentsFile.Fullfilepath(), lines);

            return tournaments;
        }


        //Convert all data to one string according to the format
        private static string ConvertRoundsto(List<List<MatchupModel>> rounds)
        {
            string line = "";

            //1*2*3|4*5*6
            foreach(List<MatchupModel> round in rounds)
            {
                foreach (MatchupModel match in round)
                {
                    line += $"{match.Id}*";
                }


                if(line=="")
                {
                    return line;
                }
                else
                {
                    line = line.Substring(0, line.Length - 1);
                    line += $"|";
                }
               

            }

            line = line.Substring(0, line.Length - 1);
            return line;

        }

        private static string ConvertPrizesto(List<PrizeModel> prizes)
        {
            //1|2|3
            string line = "";
            foreach(var p in prizes)
            {
                line += $"{p.Id}|";

            }

            if(line=="")
            {
                return line;
            }
            else
            {
                line = line.Substring(0, line.Length-1);
            }

            return line;
        }

        private static string ConvertTeamsto(List<TeamModel> enteredTeams)
        {
            string line = "";
            foreach(var t in enteredTeams)
            {
                line += $"{t.Id}|";

            }


            if(line=="")
            {
                return line;
            }
            else
            {
                line = line.Substring(0, line.Length - 1);
            }
            
            return line;
        }
    }
}
