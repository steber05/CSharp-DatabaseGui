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
    public partial class Miscellaneous : Form
    {
        public Miscellaneous()
        {
            InitializeComponent();
        }

        private void AgeThreshHoldButton_Click(object sender, EventArgs e)
        {
            try
            {
                TaskCode.DisplayAgesAbove(Convert.ToInt32(ageTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid age threshold");
            }
        }

        private void AverageAgeButton_Click(object sender, EventArgs e)
        {
            TaskCode.CalculateAvgAge();
        }

        private void AmountRedButton_Click(object sender, EventArgs e)
        {
            TaskCode.CalculateAllRed();
        }

        private void AverageCostDifferenceButton_Click(object sender, EventArgs e)
        {
            TaskCode.CalculateCostDifference();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
            AppForms.mainMenuVisible = true;
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
            AppForms.mainMenuVisible = true;
        }

        private void Miscellaneous_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
