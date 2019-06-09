using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    public partial class IndividualReports : Form
    {
        public IndividualReports()
        {
            InitializeComponent();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                TaskCode.IndividualReport(Convert.ToInt32(idTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid ID!");
            }
            idTextBox.Text = "";
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

        private void BackButtonIR_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
            AppForms.mainMenuVisible = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IndividualReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
            AppForms.mainMenuVisible = true;
        }
    }
}
//have to add file reading and error checking and read database after file reading instead of on load
