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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    { 
        IPrizeRequester iPrizeRequester;
        public CreatePrizeForm(IPrizeRequester prizeRequester)
        {

            iPrizeRequester = prizeRequester;
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                PrizeModel model = new PrizeModel(
                    PlaceNumberTextBox.Text,
                    PlaceNameTextBox.Text,
                    PrizeAmountTextBox.Text,
                    PrizePercentageTextbox.Text);

                GlobalConfig.connection.createPrize(model);
                iPrizeRequester.PrizeComplete(model);
                this.Close();


                //reset the form 
                PlaceNumberTextBox.Text = "";
                PlaceNameTextBox.Text = "";
                PrizeAmountTextBox.Text = "0";
                PrizePercentageTextbox.Text = "0";

            }


            else
            {
                MessageBox.Show("Invalid input data, please try agian!");
            }


        }

        private bool ValidateForm()
        {

            bool output = true;
           

            int placeNumber = 0;
            bool placeNumberValid = true;
            placeNumberValid=int.TryParse(PlaceNumberTextBox.Text, out placeNumber);

            if(!placeNumberValid)
            {
                output = false;
            }

            if(placeNumber<=0)
            {
                output = false;
            }



            string placeName = PlaceNameTextBox.Text;

            if (placeName.Length==0)
            {
                output = false;
            }


            decimal prizeAmount = 0;
            bool prizeAmountValid = true;
            prizeAmountValid = decimal.TryParse(PrizeAmountTextBox.Text, out prizeAmount);

            if(!prizeAmountValid)
            {
                output = false;
            }

            if(prizeAmount<0)
            {
                output = false;
            }



            double prizePercentage = 0;
            bool prizePercentageValid = true;
            prizePercentageValid = double.TryParse(PrizePercentageTextbox.Text, out prizePercentage);

            if(!prizePercentageValid)
            {
                output = false;
            }

            if(prizePercentage<0|| prizePercentage>100)
            {
                output = false;
            }



            return output;
            
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
