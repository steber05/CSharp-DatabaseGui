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
    public partial class TaxReports : Form
    {
        public TaxReports()
        {
            InitializeComponent();
        }

        private void GeneralTaxButton_Click(object sender, EventArgs e)
        {
            TaskCode.CalculateMonthlyTax();
        }

        private void JerseyCowTaxButton_Click(object sender, EventArgs e)
        {
            TaskCode.JerseyCowTax();
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

        private void TaxReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
