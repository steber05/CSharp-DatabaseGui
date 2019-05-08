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
        
        public static bool InitializeFile()//Make a connection to the database and store relevant objects in hash table and update Pricing class
        {
            bool databasePassed = false;
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
                    MessageBox.Show("\tError!\n" + ex.Message);
                    InitializeFile();
                }
                databasePassed = true;
            }
            MessageBox.Show(Pricing.goatMilkPrice.ToString());
            return databasePassed;
        }

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(InitializeFile())
            {
                Database.databasePassed = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IndividualReportsForm_Click(object sender, EventArgs e)
        {
            if(Database.databasePassed)
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

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
