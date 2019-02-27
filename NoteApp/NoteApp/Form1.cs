using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Class: CIST 2341 Introduction to C#
 * Semester: Spring 2019
 * Instructor: Stevie Prettyman
 * Description: Solution to Assignment 9 (Note App)
 * Due: 02/17/2019
 *
 * @author Stacy Harris
 * @version 1.0
 * 
 * By turning in this code, I Pledge:
 * 1. That I have completed the programming assignment independently.
 * 2. I have not copied the code from a student or any source.
 * 3. I have not given my code to any student.
 */

namespace NoteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("MyText.txt");
            sw.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            StreamWriter outputFile;
            outputFile = File.CreateText("MyText.txt");
            outputFile.WriteLine(userNameTextBox.Text);
            outputFile.WriteLine(msgTitleTextBox.Text);
            outputFile.WriteLine(messageTextBox.Text);
            outputFile.Close();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                userNameTextBox.Text = sr.ReadLine();
                msgTitleTextBox.Text = sr.ReadLine();
                messageTextBox.Text = sr.ReadLine();
                sr.Dispose();
            }
            else
            {

            }
        }
    }
}
