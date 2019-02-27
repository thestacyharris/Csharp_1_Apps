using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Class: CIST 2341 Introduction to Java
 * Semester: Spring 2019
 * Instructor: Stevie Prettyman
 * Description: Solution to Major Project 1 (Calculator)
 * Due: 02/03/2019
 *
 * @author Stacy Harris
 * @version 1.0
 * <p>
 * By turning in this code, I Pledge:
 * 1. That I have completed the programming assignment independently.
 * 2. I have not copied the code from a student or any source.
 * 3. I have not given my code to any student.
 */

namespace Calculator
{
    public partial class Form1 : Form
    {
        //initialize variables

        Double result = 0;
        String operatorPerformed = "";
        bool isOperatorPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Display.Text == "0") || isOperatorPerformed)
                textBox_Display.Clear();

            Button button = (Button)sender;
            textBox_Display.Text = textBox_Display.Text + button.Text;
            isOperatorPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorPerformed = button.Text;
            result = Double.Parse(textBox_Display.Text);
            isOperatorPerformed = true;
            labelCurrentOperation.Text = result + " " + operatorPerformed;
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox_Display.Text = "0";
            result = 0;
            operatorPerformed = "";
            labelCurrentOperation.Text = "";
        }

        private void equals_click(object sender, EventArgs e)
        {
            labelCurrentOperation.Text = labelCurrentOperation.Text + " " + textBox_Display.Text + " = ";

            switch (operatorPerformed)
            {
                case "+":
                    textBox_Display.Text = (result + Double.Parse(textBox_Display.Text)).ToString();
                    break;
                case "-":
                    textBox_Display.Text = (result - Double.Parse(textBox_Display.Text)).ToString();
                    break;
                case "*":
                    textBox_Display.Text = (result * Double.Parse(textBox_Display.Text)).ToString();
                    break;
                case "/":
                    textBox_Display.Text = (result / Double.Parse(textBox_Display.Text)).ToString();
                    break;
                default:
                    break;
            }

            labelCurrentOperation.Text = labelCurrentOperation.Text + textBox_Display.Text;

        }
    }
}
