using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void assignTenTextBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = assignTenTextBox.Text;

            if (assignTenTextBox.Text == "exit")
            {
                MessageBox.Show("Please sir, can I have some more...input??");
                Close();
            }

            if (string.IsNullOrWhiteSpace(userInput) == false)
            {
                char[] specialChar = new char[] { '#', '@', '!', '$', '%', '^', '&', '*' };

                foreach (char input in userInput)
                {
                    bool isInputValid = char.IsDigit(input) || 
                                        char.IsLetter(input) || 
                                        specialChar.Contains(input);

                    if(isInputValid == true)
                    {
                        if (char.IsDigit(input))
                        {
                            displayNumber(input);
                        }
                        if (char.IsLetter(input))
                        {
                            displayLetter(input);
                        }
                        else if (specialChar.Contains(input))
                        {
                            displaySpecial(input);
                        }
                    }
                    
                    else
                    {
                        MessageBox.Show("Please enter a letter (A-Za-z), number (0-9), or special symbol (#@!$%^&*)");
                        assignTenTextBox.Text = "";
                    }
                }
            }

        } //end assignTexTextBox

        private void displayLetter(char letter)
        {
            //draws stick figure using the letter in input box
            MessageBox.Show("      " + letter + letter + "  " +"\n"+
                "    "+ letter +"    "+ letter+" "+"\n"+
                "    " + letter + "    " + letter + " " + "\n" +
                "      " + letter + letter + "  " + "\n"+
                "       "+letter+"   "+"\n"+
                "       "+letter+"   "+"\n"+
                letter+ letter + letter + letter + letter + letter + letter + letter + "\n"+
                "       " + letter + "\n" +
                "       " + letter  + "\n" +
                "       " + letter + "\n" +
                "       " + letter + "\n"+
                "     " + letter + "   " +letter+ "\n"+
                "    " + letter + "     " + letter + "\n" +
                "   " + letter + "       " + letter + "\n" +
                "  " + letter + "         " + letter + "\n");

        } //end displayLetter

        private void displayNumber(char number)
        {
            int count = Convert.ToInt32(new string(number, 1));

            //repeats "I love C#" according to number in text box
            if (count > 0)
            {
                StringBuilder message = new StringBuilder();

                for (int i = 1; i <= count; i++)
                {
                    message.Append("I love C# ");
                }
                MessageBox.Show(message.ToString());
            }
        } //end displayNumber

        private void displaySpecial(char special)
        {
            //displays different message for each special character
            switch (special){
                case '@':
                MessageBox.Show("Is that an eye staring at me?");
                break;
                case '!':
                MessageBox.Show("Are you yelling at me?");
                break;
                case '#':
                MessageBox.Show("In my day, we called that the pound sign.");
                break;
                case '$':
                MessageBox.Show("Show me the money!!!!");
                break;
                case '%':
                MessageBox.Show("60 percent of the time, this works every time.");
                break;
                case '^':
                MessageBox.Show("The people's eyebrow.");
                break;
                case '&':
                MessageBox.Show("....and another thing....");
                break;
                case '*':
                MessageBox.Show("A star shines on the hour of our meeting");
                break;

            }

        }//end displaySpecial
    } //end Class
} //end Namespace
