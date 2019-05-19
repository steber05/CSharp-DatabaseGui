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
    public partial class PartialReports : Form
    {
        public PartialReports()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppForms.mainMenu.Show();
            this.Hide();
            AppForms.mainMenuVisible = true;
        }
    }
}
