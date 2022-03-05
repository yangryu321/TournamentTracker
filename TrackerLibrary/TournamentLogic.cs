using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //random number generater?
        private static Random rng = new Random();
        public static void CreateRounds(TournamentModel model)
        {
           
            //how many rounds is the tournament gonna have
            int num_round = Num_Round(model.EnteredTeams.Count());
            //how many bots we need to fill in the first round;
            int num_bots = Num_Bots(num_round, model.EnteredTeams.Count());


            //randomize the teams for first round
            List<TeamModel> teamModels_BR = model.EnteredTeams;//teams before randomized

            List<TeamModel> teamModels_R = RadomizeTeams(model);//teams after randomized



            createFirstRound(model,num_bots);
            CreateOtherRounds(num_round,model);

       


            //there will always be 1 and only 1 bot if the number of team is not even?
            //About round2 and so on, the logic here is to create new matchup model with matchupentries that use 
            //winners as the competing teams,also set round to new round number
            //So in TournamentViewer Form, Create new match up, set winner to null but need to update winner of match
            //of parent matchup's winner property.
            //Create new matchupentries using winner teams
            //Update parent matchup's matchupentries score using users inputs
            //add newly created matchup to another round which is List<matchup>
            //after the whole is finished, which is to checked the winner property of all the matchups 
            //add new round to Rounds




        }




        private static int Num_Bots(int num_round,int num_teams)
        {
            //About bots, how many bots do I need? I think I always need 1 or 0 bot, 1 if the number is odd
            
            int _base = 2;
            while(_base<num_teams)
            {
                _base *= 2;

            }

            return _base - num_teams;


        }

        private static int Num_Round(int num_teams)
        {
            int roundNumber = 1;
            int i = 2;

            while (i < num_teams)
            {
                i *= 2;
                roundNumber += 1;

            }

            return roundNumber;

        }
      
        private static void CreateOtherRounds(int num_round, TournamentModel tournament)
        {
            //other rounds start from round2
            int currentRound = 2;
            //create a round
            List<MatchupModel> round = new List<MatchupModel>();

            //create a matchup
            MatchupModel matchup = new MatchupModel();
         
            //where is matchupentries from? From last round (winner of the last round),starting from round 1
            List<MatchupModel> previousRound = tournament.Rounds[0];

            //create new entry using the winner of last round matchup
            MatchupEntryModel winner_of_last_round= new MatchupEntryModel();
            //couple of things 
            //dont instantiate new objetct inside a loop? reuse the same name but assigning it new value?
            while (currentRound<=num_round)
            {

                //fill this matchup with matchupentries
                //where is matchupentries from? From last round (winner of the last round),starting from round 1
                

                foreach (var match in previousRound)
                {
                    //have to update winner and matchupround id here becase whenever you go to the next round you should update the roundid to the matchup roundid
                    matchup.Winner = null;
                    matchup.MatchupRound = currentRound;

                    //dont know score yet but we do know the parentMatchup
                    winner_of_last_round.ParentMatchup = match;
                    //TODO--do you have to set the score here to -1
                    winner_of_last_round.TeamCompeting = null;
                    //add the entry to the newly created matchup

                    matchup.Entries.Add(winner_of_last_round);
                    //One match can only hold 2 entries, So need to creat new matchup when its full
                    if(matchup.Entries.Count()>=2)
                    {
                        //when its full, add it to the new round
                        round.Add(matchup);
                        matchup = new MatchupModel();
                        //cant put them here becase here doesnt update matchuproundid when it first comes to the next round
                        //matchup.Winner = null;
                        //matchup.MatchupRound = currentRound;


                    }

                    winner_of_last_round = new MatchupEntryModel();

                }

                tournament.Rounds.Add(round);
                currentRound++;
                
                previousRound = round;
                round = new List<MatchupModel>();

            }
        }

        private static void createFirstRound(TournamentModel tournament,int num_bots)
        {
            //round1
            List<MatchupModel> Round_1 = new List<MatchupModel>();

            //create a new match
            MatchupModel matchup = new MatchupModel();
            matchup.MatchupRound = 1;
            matchup.Winner = null;

            foreach (var t in tournament.EnteredTeams)
            {

                //create a new matchupentry
                MatchupEntryModel matchupEntry = new MatchupEntryModel();
                matchupEntry.TeamCompeting = t;
                //TODO--changed this, might cause a problem later
                //matchupEntry.Score = 0;
                matchupEntry.ParentMatchup = null;

                //add the new matchupentry to matchup
                matchup.Entries.Add(matchupEntry);


                //fill the entry with bots if there is bots available
                if (num_bots> 0||matchup.Entries.Count() >= 2 )
                {
                    Round_1.Add(matchup);
                    matchup = new MatchupModel();
                    matchup.MatchupRound = 1;
                    matchup.Winner = null;
                    num_bots--;
                }
                

            }


            tournament.Rounds.Add(Round_1);
        }

        private static List<TeamModel> RadomizeTeams(TournamentModel model)
        {

            return model.EnteredTeams.OrderBy(a => rng.Next()).ToList();
        }
    }


}
