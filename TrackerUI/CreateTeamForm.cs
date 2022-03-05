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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> teamMembersToSelect = new List<PersonModel>();
        private List<PersonModel> teamMemberSelected = new List<PersonModel>();

        ITeamRequester ITeamRequester;

        public CreateTeamForm(ITeamRequester teamRequester)
        {
            ITeamRequester = teamRequester;

            InitializeComponent();

            Load_People();
         
        }

        private void Load_People()
        {
            teamMembersToSelect=GlobalConfig.connection.Get_All_Person();
            WireUpList();
        }



        private void testdropdownlist()
        {
            PersonModel guy1 = new PersonModel("dsf", "dsf", "df", "dsfs");
            PersonModel guy2 = new PersonModel("435", "345", "888", "000");

            PersonModel guy3 = new PersonModel("77", "dsf", "df", "dsfs");
            PersonModel guy4 = new PersonModel("88", "345", "888", "000");

            teamMemberSelected.Add(guy1);
            teamMemberSelected.Add(guy2);

            teamMembersToSelect.Add(guy3);
            teamMembersToSelect.Add(guy4);



            WireUpList();
        }

        private void WireUpList()
        {
            TeamMemberDroplist.DataSource = null;
            TeamMemberDroplist.DataSource = teamMembersToSelect;
            TeamMemberDroplist.DisplayMember = "Fullname";

            TeamMemberListBox.DataSource = null;
            TeamMemberListBox.DataSource = teamMemberSelected;
            TeamMemberListBox.DisplayMember = "Fullname";

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            //validate data
     
            if(ValidateForm())
            {
                //call createMember(personModel)

                PersonModel personModel = new PersonModel(
                    FirstNameTextBox.Text, 
                    LastNameTextBox.Text, 
                    EmailTextBox.Text, 
                    CellphoneTextBox.Text
                    );

                GlobalConfig.connection.createPerson(personModel);
                teamMemberSelected.Add(personModel);
                

                WireUpList();


                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextBox.Text = "";
                CellphoneTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Invalid input data, please try agian!");

            }

        }

        private bool ValidateForm()
        {
            bool output = true;

            if(FirstNameTextBox.Text.Length==0)
            {
                output = false;
            }

            if(LastNameTextBox.Text.Length==0)
            {
                output = false;
            }

            if(EmailTextBox.Text.Length==0)
            {
                output = false;
            }

            if(CellphoneTextBox.Text.Length==0||!CellphoneTextBox.Text.All(char.IsDigit))
            {
                output = false;
            }
            


            return output;
            
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();
            person = (PersonModel)TeamMemberDroplist.SelectedItem;

            if (person != null)
            {
                teamMembersToSelect.Remove(person);
                teamMemberSelected.Add(person);
                WireUpList();
            }
            //TODO--fix this
            //if you select the bottom item and click the button, the droplist shows no item and you have to click for it to show
           

        }

        private void DeleteSelectedTeamsMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();
            person = (PersonModel)TeamMemberListBox.SelectedItem;

            if (person != null)
            {
                teamMemberSelected.Remove(person);
                teamMembersToSelect.Add(person);
                WireUpList();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = new TeamModel();

            if (TeamNameTextbox.Text.Length != 0)
            {
                model.TeamName = TeamNameTextbox.Text;
                model.TeamMembers = teamMemberSelected;
                GlobalConfig.connection.createTeam(model);

                ITeamRequester.TeamComplete(model);
                
                //TeamNameTextbox.Text = "";
                //TeamMemberListBox.DataSource = null;
                this.Close();


            }
            else
            {
                MessageBox.Show("Invalid input data, please try agian!");
            }

            
        }

   
    }
}
