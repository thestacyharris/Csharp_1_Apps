using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables to count the nubmer of tosses, heads, and tails
        double numToss = 0;
        double numHeads = 0;
        double numTails = 0;
        double percentHeads = 0;
        double percentTails = 0;

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Count number of tosses
            numToss++;
            tossNumTextBox.Text = numToss.ToString();

            //Variable to indicate which side is up
            int sideUp;

            //Create a Random object
            Random rand = new Random();

            //Get a random integer in the range of 0 to 1
            //0 means tails up, 1 means heads up
            sideUp = rand.Next(2);

            //Display the side that is up
            if (sideUp == 0)
            {
                //Count tails
                numTails++;
                tailsTextBox.Text = numTails.ToString();
                
                //Display tails up
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                //Count heads
                numHeads++;
                headsTextBox.Text = numHeads.ToString();
                
                //Display heads up
                tailsPictureBox.Visible = false;
                headsPictureBox.Visible = true;
            } 

            //Generate percentage of landing on heads
            percentHeads = (numHeads / numToss);
            percentHeads = Math.Round(percentHeads, 2);
            percentHeadsTextBox.Text = percentHeads.ToString() + "%";

            //Generate percentage of landing on tails
            percentTails = (numTails / numToss);
            percentTails = Math.Round(percentTails, 2);
            percentTailsTextBox.Text = percentTails.ToString() + "%";
        } //end tossButton_Click

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        } //end exitButton_Click
    } //end Class
} //end Namespace
