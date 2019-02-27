using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All we have to decide is what to do with the time that is given us.  - Gandalf:  The Fellowship of the Ring");
        }

        private void funButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For fun, I enjoy working out every morning.  I find lifting weights both fun and theraputic.");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's a dangerous business, Frodo, going out your door.  You step onto the road, and if you don't keep your feet, there's no knowing where you might be swept off to.");

            //Close the form.
            this.Close();
        }
    }
}
