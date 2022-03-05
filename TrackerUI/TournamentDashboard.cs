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
    public partial class TournamentDashboard : Form,ITournamentRequester,ITournamentSender
    {

        public TournamentModel selectedTournament;
        private List<TournamentModel> tournamentToSelect = new List<TournamentModel>();
        public TournamentDashboard()
        {
            InitializeComponent();
            tournamentToSelect = GlobalConfig.connection.Get_ALL_Tournaments();
            WireUpList();
        }

        private void WireUpList()
        {
            LoadingExistingTournamentDropList.DataSource = null;
            LoadingExistingTournamentDropList.DataSource = tournamentToSelect;
            LoadingExistingTournamentDropList.DisplayMember = "TournamentName";



        }
        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm form = new CreateTournamentForm(this);
            form.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            selectedTournament = (TournamentModel)LoadingExistingTournamentDropList.SelectedItem;
            TournamentViewerForm form = new TournamentViewerForm(this);
            form.Show();
        }

        public void TournamentComplete(TournamentModel model)
        {
            tournamentToSelect.Add(model);
            WireUpList();
        }

        public TournamentModel Get_selected_TournamentModel()
        {
            return selectedTournament;
        }

        private void TournamentDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
