using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private ITournamentSender ITournamentSender;
        private TournamentModel CurrentTournament = new TournamentModel();
        private int TournamentId;
        private List<MatchupModel> CurrentRound = new List<MatchupModel>();
        private List<MatchupModel> CurrentRound_GamesNotPlayedYet = new List<MatchupModel>();
        private List<MatchupModel> CurrentRound_AllMatches = new List<MatchupModel>();
        private List<string> round_info = new List<string>();
        private int round_num = 0;
        private string selected_round;
        private MatchupModel CurrentMatchup = new MatchupModel();

        //private string line="";
        //private string line_forSingleEntry = "";

        //private List<string> test = new List<string>(new string[] {"tomo vs charlie","yang vs misheru"});
        //private List<string> matchupAndTeams = new List<string>();
        public TournamentViewerForm(ITournamentSender sender)
        {
            InitializeComponent();
            ITournamentSender = sender;   
            //use interface to communicate between two classess
            CurrentTournament = ITournamentSender.Get_selected_TournamentModel();
            
            //load tournament info
            LoadTournament();
            
            
        }

        private void LoadTournament()
        {
            // record the current tournament id
            TournamentId = CurrentTournament.Id;

            //display tournament name
            TournamentName.Text = CurrentTournament.TournamentName;

            //get number of rounds of the tournament and populate dropdown box round info
            Get_round();

            //wire up matchup list 
            WireUpList();

            //wire up other fields of the form,
            WireupOther();
        }

        private void WireupOther()
        {
            if (CurrentMatchup != null)
            {
                
                if (CurrentMatchup.Entries.Count() > 1)
                {
                    //if theres no teamcompeting in this entry yet, set TeamOneScoreLabel to null 
                    if (CurrentMatchup.Entries[0].TeamCompeting != null)
                    {
                        TeamOneScoreLabel.Text = CurrentMatchup.Entries[0].TeamCompeting.TeamName;
                       
                    }
                    else
                    {
                        TeamOneScoreLabel.Text = "_____";
                       
                    }

                    //if theres no teamcompeting in this entry yet, set TeamTwoScoreLabel to null 
                    if (CurrentMatchup.Entries[1].TeamCompeting != null)
                    {
                        TeamTwoScoreLabel.Text = CurrentMatchup.Entries[1].TeamCompeting.TeamName;

                    }
                    else
                    {
                        TeamTwoScoreLabel.Text = "_____";

                    }


                }

                else
                {
                    if(CurrentMatchup.Entries.Count()!=0)
                    {
                        TeamOneScoreLabel.Text = CurrentMatchup.Entries[0].TeamCompeting.TeamName;
                        TeamTwoScoreLabel.Text = "Bot";

                    }
                    else
                    {
                        MessageBox.Show("This tournament is empty!");
                    }
  
                }
            }
            
          
        }

        private void Get_matchupOfThatRound()
        {
            //matchupAndTeams = new List<string>();
            selected_round = (string)RoundDropdown.SelectedItem;
            //refresh tournament here, it's probably not the most optimized way to do it but it's really easy this way
            //the reason to refresh is because after you update the tournament, teamcompeting of the next matchup gets filled up but it's not
            //stored in the current tournament, so here you can record the current matchupId and get the updated version of the tournament 
            //with the id.
            //Or maybe you can update the matchup of the next round(teamcompeting field) right where you execute the stored processure, but
            // that maybe too complicated so this is probably the better way to do it

            //Not a good spot to update tournament because every time you click the drop down list its gonna connect to database, 
            //might affect speed if theres too many tournaments
            //it's faster if you just get round from local storage
           // CurrentTournament = GlobalConfig.connection.Get_ALL_Tournaments().Where(x => x.Id == TournamentId).First();
           
            CurrentRound = CurrentTournament.Rounds[int.Parse(selected_round) - 1];

            //for checkbox use
            CurrentRound_AllMatches = CurrentRound;

           
            //it's better to get matchupmodels directly instead of putting matchupteam names in another List<string> 
            //cause later on you have to update stuff, it's easier to update with modelId




            //foreach (var match in CurrentRound)
            //{
            //    foreach (var entry in match.Entries)
            //    {
            //        if(match.Entries.Count() > 1)
            //        {
            //            if (entry.TeamCompeting != null)
            //                line += $"{entry.TeamCompeting.TeamName}-VS-";
            //            else
            //                line += $"{"____"}-VS-";
            //        }
            //        else
            //        {
            //            line_forSingleEntry+= $"{entry.TeamCompeting.TeamName}-VS-{"bot"}";
            //        }

            //    }
            //    if (line != "")
            //    {
            //        line = line.Substring(0, line.Length - 4);
            //        matchupAndTeams.Add(line);
            //    }
            //    if(line_forSingleEntry!="")
            //        matchupAndTeams.Add(line_forSingleEntry);
            //    line = "";
            //    line_forSingleEntry = "";
            //}


            //return matchupAndTeams;

        }
       private void Get_round()
        {
            round_info = new List<string>();
            foreach (var round in CurrentTournament.Rounds)
            {
                round_num++;
                round_info.Add(round_num.ToString());

            }

        }



       private void WireUpList()
       {

 
            RoundDropdown.DataSource = null;
            RoundDropdown.DataSource = round_info;

            //MatchupListbox.DataSource = null;
            //MatchupListbox.DataSource = CurrentRound;
            //MatchupListbox.DisplayMember = "Matchupteams";

        }


        private void ScoreButton_Click(object sender, EventArgs e)
        {


            //validate the score and fill up matchup winner
            if (Validate_score())
            {
                GlobalConfig.connection.Update(CurrentMatchup);

                //update tournament here 
                CurrentTournament = GlobalConfig.connection.Get_ALL_Tournaments().Where(x => x.Id == TournamentId).First();
                

            }

            CurrentRound = new List<MatchupModel>();
            

        }

        private bool Validate_score()
        {
            bool isvalid = true;
            bool matchupReady =true;
            //if one of the teams is not decided, then cant input score
            //which means the matchup is not ready 
            foreach (var entry in CurrentMatchup.Entries)
            {
                if (entry.TeamCompeting == null)
                {
                    
                    matchupReady = false;
                    
                }

 
            }


            int output = 0;
            if(matchupReady)
            {
                //if there are two entries in this matchup
                if (CurrentMatchup.Entries.Count() == 2)
                {
                    
                    //score for team1
                    if (int.TryParse(TeamOneScoreText.Text, out output))
                        CurrentMatchup.Entries[0].Score = output;
                    else
                    {
                        MessageBox.Show("Please input a valid score");
                        isvalid = false;
                    }
                        

                    //score for team2
                    if (int.TryParse(TeamTwoScoreText.Text, out output))
                        CurrentMatchup.Entries[1].Score = output;
                    else
                    {
                        MessageBox.Show("Please input a valid score");
                        isvalid = false;
                    }
                       


                    
                    // there can be no tie in this tournament
                    if (CurrentMatchup.Entries[0].Score > CurrentMatchup.Entries[1].Score)
                        CurrentMatchup.Winner = CurrentMatchup.Entries[0].TeamCompeting;
                    else if(CurrentMatchup.Entries[0].Score == CurrentMatchup.Entries[1].Score)
                    {
                        MessageBox.Show("There can be no tie in this tournament!");
                        isvalid = false;
                    }
                        
                    else
                        CurrentMatchup.Winner = CurrentMatchup.Entries[1].TeamCompeting;
                   

                }
                //if there is a bot in this matchup
                else
                {

                    
                    if (TeamOneScoreText.Text.Length != 0 || TeamTwoScoreText.Text.Length != 0)
                    {
                        //reset the score field to ""
                        TeamOneScoreText.Text = "";
                        TeamTwoScoreText.Text = "";

                        MessageBox.Show("No match for this round, please dont input anything for score");
                        CurrentMatchup.Winner = CurrentMatchup.Entries[0].TeamCompeting;
                       
                    }
                       

                }

            }
            else
            {
              
                    MessageBox.Show("No match yet, please dont input anything for score");
                    isvalid = false;
            }

            return isvalid;
        }

        private void RoundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Console.WriteLine(RoundDropdown.SelectedItem);
            Get_matchupOfThatRound();
            //Be careful here, cause you call the wireuplist() its gonna reset the rounddrop down to null, which is gonna return no index
            // you can make another method just for the next two lines, which means you only refresh the matchuplistbox 

 
            Get_matchupUnplayed();

            WireUpMatchupList();

            WireupOther();


            
        }

        private void Get_matchupUnplayed()
        {
            CurrentRound_GamesNotPlayedYet = new List<MatchupModel>();
            foreach (var matchup in CurrentRound)
            {
                if (matchup.Winner == null)
                    CurrentRound_GamesNotPlayedYet.Add(matchup);

            }

        }

        private void WireUpMatchupList()
        {
            if (UnplayedOnly.Checked)
            {

                
                CurrentRound = CurrentRound_GamesNotPlayedYet;
            }
            else
            {
                CurrentRound = CurrentRound_AllMatches;

            }

            MatchupListbox.DataSource = null;
            MatchupListbox.DataSource = CurrentRound;
            MatchupListbox.DisplayMember = "Matchupteams";

            
        }

        private void MatchupListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMatchup =(MatchupModel)MatchupListbox.SelectedItem;
            WireupOther();
            
        }

        private void UnplayedOnly_CheckedChanged(object sender, EventArgs e)
        {
            //update matchups with only one team here
            //automatically calls update() when you check the unplayed only
            foreach (var matchup in CurrentRound)
            {
                if(matchup.Entries.Count()==1&&matchup.Winner==null)
                {
                    matchup.Winner = matchup.Entries[0].TeamCompeting;
                    GlobalConfig.connection.Update(matchup);
                }

            }
           

            Console.WriteLine($"{UnplayedOnly.Checked}");

            //TODO matchup with bots update here?
            //And update matchups with two entries in confirm button
            //After updating matchup, have to update the matchupentry where its parentmatchup is the one that just been updated, 
            //fill in its teamcompeting info

            //implentment unplayed only 
            //get boolean value?
            Get_matchupUnplayed();

            //if true
            //show matchups without bot and matchuped not played
            WireUpMatchupList();

            //if false
            //show all matchups
            

;        }

    }
}
