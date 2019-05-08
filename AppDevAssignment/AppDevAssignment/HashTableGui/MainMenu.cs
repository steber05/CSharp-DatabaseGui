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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        bool databasePassed = false;
        public static bool InitializeFile()
        {
            bool pass = false;
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Choose database file";
            file.Filter = "All files | *.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Database.InitializeDatabase(file.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\tInvalid file!\nPlease choose a valid file\n" + ex.Message);
                    InitializeFile();
                }
                pass = true;
            }
            return pass;
        }

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(InitializeFile())
            {
                databasePassed = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IndividualReportsForm_Click(object sender, EventArgs e)
        {
            AppForms.individualReport.Show();
            this.Hide();
        }
    }
}
