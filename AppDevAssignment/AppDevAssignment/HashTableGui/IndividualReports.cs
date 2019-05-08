using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableGui
{
    public partial class IndividualReports : Form
    {
        public IndividualReports()
        {
            InitializeComponent();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            LiveStock animal;
            try
            {
                animal = Database.allAnimals[Convert.ToInt32(idTextBox.Text)];
                animal.displayInfo();
            }
            catch (Exception)
            {
                if(Database.allAnimals.Count > 0)
                {
                    MessageBox.Show("Invalid ID!");
                    idTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please choose a database first\n\t Press F4");
                    idTextBox.Text = "";
                }
                
            }
            
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                queryButton.PerformClick();
            }
        }

        private void QueryIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryButton.PerformClick();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButtonIR_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
        }
    }
}
//have to add file reading and error checking and read database after file reading instead of on load
