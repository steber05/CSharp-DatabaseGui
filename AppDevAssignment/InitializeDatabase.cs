using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class InitializeDatabase
    {
        public static Dictionary<int,Cow> allAnimals = new Dictionary<int,Cow>();
        public static void DatabaseSetup()
        {
            string[] animals = new string[] { "cows", "goats", "sheep", "dogs" };
            string query;
            LiveStock animal;

            for(int i=0;i<animals.Length;i++)
            {
                query = "SELECT * FROM " + animals[i];
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\stevi\\Desktop\\wintec\\farm\\FarmInfomation.accdb;Persist Security Info=False");
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if(i == 0)
                    {
                        animal = new Cow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), Convert.ToInt32(reader["age"]), reader["color"].ToString(), Convert.ToDouble(reader["Amount of milk"]));
                        allAnimals.Add(Convert.ToInt32(reader["id"], animal);
                    }
                    else if(i == 1)
                    {

                    }
                    else if(i == 2)
                    {

                    }
                    else if(i == 3)
                    {

                    }

                }
            }
            MessageBox.Show(allAnimals[1004]);
        }
    }
}
