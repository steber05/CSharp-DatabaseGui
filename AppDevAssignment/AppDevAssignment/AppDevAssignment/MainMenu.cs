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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        public static void InitializeFile()//Make a connection to the database and store relevant objects in hash table and update Pricing class
        {
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
                    MessageBox.Show("Error initializing database please try again\n" + ex.Message);
                }
                Database.databasePassed = true;
            }
        }

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                InitializeFile();
                connectToolStripMenuItem.IsDisabled;
                AppForms.mainMenu.connectToolStripMenuItem.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error initializing database");
            }
            this.Cursor = Cursors.Default;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void IndividualReportForm_Click(object sender, EventArgs e)
        {
            if (Database.databasePassed)
            {
                AppForms.individualReport.Show();
                this.Hide();
                AppForms.mainMenuVisible = false;
            }
            else
            {
                MessageBox.Show("Please connect to database first\n\t  Press F4");
            }
        }

        private void MiscellaneousForm_Click(object sender, EventArgs e)
        {
            if (Database.databasePassed)
            {
                AppForms.miscellaneousReport.Show();
                this.Hide();
                AppForms.mainMenuVisible = false;
            }
            else
            {
                MessageBox.Show("Please connect to database first\n\t  Press F4");
            }
        }

        private void PartialReportForm_Click(object sender, EventArgs e)
        {
            if (Database.databasePassed)
            {
                AppForms.partialReport.Show();
                this.Hide();
                AppForms.mainMenuVisible = false;
            }
            else
            {
                MessageBox.Show("Please connect to database first\n\t  Press F4");
            }
        }

        private void TotalReportForm_Click(object sender, EventArgs e)
        {
            if (Database.databasePassed)
            {
                AppForms.totalReport.Show();
                this.Hide();
                AppForms.mainMenuVisible = false;
            }
            else
            {
                MessageBox.Show("Please connect to database first\n\t  Press F4");
            }
        }
    }
}
