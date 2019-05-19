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
    public partial class ProfitReports : Form
    {
        public ProfitReports()
        {
            InitializeComponent();
        }

        private void AmountOfMilkButton_Click(object sender, EventArgs e)
        {
            TaskCode.CalculateGoatCowMilk();
        }

        private void JerseyCowProfitButton_Click(object sender, EventArgs e)
        {
            TaskCode.JerseyCowProfit();
        }

        private void ProfitDifferenceButton_Click(object sender, EventArgs e)
        {
            TaskCode.CalculateProfitDifference();
        }

        private void TotalProfitLossButton_Click(object sender, EventArgs e)
        {
            TaskCode.TotalDailyProfitLoss();
        }

        private void PrintToFileButton_Click(object sender, EventArgs e)
        {
            TaskCode.PrintIDToFile();
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfitReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
