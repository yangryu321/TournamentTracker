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

    public partial class CreateTournamentForm : Form, IPrizeRequester,ITeamRequester
    {
        private List<TeamModel> TeamsInCombobox = new List<TeamModel>();
        private List<PrizeModel> PrizesSelected = new List<PrizeModel>();
        private List<TeamModel> TeamsSelected = new List<TeamModel>();

        ITournamentRequester ITournamentRequester;
       
        public CreateTournamentForm(ITournamentRequester requester)
        {
            ITournamentRequester = requester;
            InitializeComponent();

            TeamsInCombobox=GlobalConfig.connection.Get_ALL_Team();

            WireUpList();
        }

        private void WireUpList()
        {
            PrizeListbox.DataSource = null;
            PrizeListbox.DataSource = PrizesSelected;
            PrizeListbox.DisplayMember = "PlaceName";

            TournamentTeamsListBox.DataSource = null;
            TournamentTeamsListBox.DataSource = TeamsSelected;
            TournamentTeamsListBox.DisplayMember = "TeamName";

            SelectTeamComboBox.DataSource = null;
            SelectTeamComboBox.DataSource = TeamsInCombobox;
            SelectTeamComboBox.DisplayMember = "TeamName";




        }

        private void CreateNewLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();


        }

        public void PrizeComplete(PrizeModel prizemodel)
        {
            PrizesSelected.Add(prizemodel);
            WireUpList();
        }

        private void CreatPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel teammodel)
        {
            TeamsSelected.Add(teammodel);
            WireUpList();
        }

        private void AddteamButton_Click(object sender, EventArgs e)
        {
     
            TeamModel SelectedItem =(TeamModel)SelectTeamComboBox.SelectedItem;

            if (SelectedItem != null)
            {
                TeamsInCombobox.Remove(SelectedItem);
                TeamsSelected.Add(SelectedItem);
                WireUpList();
            }
        }

        private void DeleteSelectedTeamsButton_Click(object sender, EventArgs e)
        {
            TeamModel SelectedItem = (TeamModel)TournamentTeamsListBox.SelectedItem;

            if (SelectedItem != null)
            {
                TeamsSelected.Remove(SelectedItem);
                TeamsInCombobox.Add(SelectedItem);
                WireUpList();
            }
        }

        private void DeleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel SelectedItem = (PrizeModel)PrizeListbox.SelectedItem;

            if (SelectedItem != null)
            {
                PrizesSelected.Remove(SelectedItem);
                WireUpList();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            // Create Tournament model


            TournamentModel model = new TournamentModel();

            model.TournamentName = TournamentNameTextbox.Text;

            decimal entryFee = 0;
            bool entryFeeIsvalid = false;
            entryFeeIsvalid = decimal.TryParse(EntryfeeTextbox.Text, out entryFee);

            if(entryFeeIsvalid&&entryFee>=0)
            {
                model.EntryFee = entryFee;
            }
            else
            {
                MessageBox.Show("You need to enter a valid entry fee","Invalid Fee",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //teams for the first round
            model.EnteredTeams = TeamsSelected;

            model.Prizes = PrizesSelected;


            //model.Rounds=GenerateRounds(model.EnteredTeams);
            //Loose coupling here, so you can change the frontend in the future to web or wpf
            //By creating another file and put the logic(function) in there and just add the namespace
            //when you need to use it
            TournamentLogic.CreateRounds(model);
            

            GlobalConfig.connection.createTournament(model);

            ITournamentRequester.TournamentComplete(model);

            this.Close();

            // Create Tournament entry
            // Create all of the prizes entries
            // create all of the team entries

        }







        //private List<List<MatchupModel>> GenerateRounds(List<TeamModel> enteredTeams)
        //{
        //    //randomize teams and generate first round with it
        //    //create MatchupEntries using each team
        //    //create Mathcups using matchupEntries

        //    List<List<MatchupModel>> Rounds = new List<List<MatchupModel>>();
            

        //    MatchupModel matchModel;

            
        //    //teams in random order
        //    List<TeamModel> teamModels_R = RadomizeTeams(enteredTeams);
          

        //    //number of teams 
        //    int numberOfTeams = enteredTeams.Count();

        //    // This part decides how many rounds to play
        //    int roundNumber= 1;
        //    int i = 2;

        //    while (i < numberOfTeams)
        //    {
        //        i *= 2;
        //        roundNumber += 1;

        //    }

        //    //About bots, how many bots do I need? I think I always need 1 or 0 bot, 1 if the number is odd
        //    int bot = 0;
        //    if (numberOfTeams / 2 != 0)
        //    {
        //        bot = 1;
        //    }


        //    //generate the first round

        //    //round1
        //    List<MatchupModel> Round_1 = new List<MatchupModel>();

        //    MatchupModel model = new MatchupModel();
        //    model.MatchupRound = 1;
        //    model.Winner = null;

        //    foreach (var t in teamModels_R)
        //    {

        //        if (model.Entries.Count() >= 2)
        //        {
        //            Round_1.Add(model);
        //            model = new MatchupModel();
        //            model.MatchupRound = 1;
        //            model.Winner = null;

        //        }

        //        MatchupEntryModel matchupEntry = new MatchupEntryModel();
        //        matchupEntry.TeamCompeting = t;
        //        matchupEntry.Score = 0;
        //        matchupEntry.ParentMatchup = null;

        //        model.Entries.Add(matchupEntry);

        //        //if t is the last team and its by itselft, use the bot to it

        //    }


        //    //there will always be 1 and only 1 bot if the number of team is not even?
        //    if (bot > 0)
        //    {
        //        MatchupEntryModel matchupEntry = new MatchupEntryModel();
        //        matchupEntry.TeamCompeting = null;//this is a bot, no actual team for the entry
        //        matchupEntry.Score = 0;
        //        matchupEntry.ParentMatchup = null;
        //        model.Entries.Add(matchupEntry);
        //        Round_1.Add(model);

        //    }

        //    Rounds.Add(Round_1);

        //    //About round2 and so on, the logic here is to create new matchup model with matchupentries that use 
        //    //winners as the competing teams,also set round to new round number
        //    //So in TournamentViewer Form, Create new match up, set winner to null but need to update winner of match
        //    //of parent matchup's winner property.
        //    //Create new matchupentries using winner teams
        //    //Update parent matchup's matchupentries score using users inputs
        //    //add newly created matchup to another round which is List<matchup>
        //    //after the whole is finished, which is to checked the winner property of all the matchups 
        //    //add new round to Rounds
            




        //    return Rounds;


        //}

        //private List<TeamModel> RadomizeTeams(List<TeamModel> enteredTeams)
        //{
           
        //    return enteredTeams.OrderBy(a=>rng.Next()).ToList();
        //}


    }
}
