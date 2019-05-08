using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AppDevAssignment
{
    class Database
    {
        public static bool databasePassed = false;

        public static Dictionary<int, LiveStock> allAnimals = new Dictionary<int, LiveStock>();
        public static void InitializeDatabase(string file)
        {
            string[] tableNames = new string[] { "cows", "goats", "sheep", "dogs", "[Commodity Prices]" };//array used to loop through each table
            double[] commodities = new double[6];
            int commodityTracker = 0;
            LiveStock animal;//temp animal for adding to hash table
            //establish connection to database
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Persist Security Info=False");
            connection.Open();

            String tableName;
            string query;
            OleDbCommand cmd;
            OleDbDataReader reader;

            //loop through each table and add each row to hash table
            for (int i = 0; i < tableNames.Length; i++)
            {
                // Name of the table
                tableName = tableNames[i];
                query = "SELECT * FROM " + tableName;
                cmd = new OleDbCommand(query, connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())//Read each row of each animal table
                {
                    //differentiate jersey cow
                    if (i == 0 && Convert.ToBoolean(reader["Is Jersy"]))//animals[i] == "jersey cows"
                    {
                        animal = new JerseyCow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                               Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                               Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                               Convert.ToDouble(reader["Amount of milk"]));
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);

                    }
                    else if (i == 0)//animals[i] == "cows"
                    {
                        animal = new Cow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                         Convert.ToDouble(reader["Amount of milk"]));
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                    }
                    else if (i == 1)//animals[i] == "goats"
                    {
                        animal = new Goat(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                          Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                          Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                          Convert.ToDouble(reader["Amount of milk"]));
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                    }
                    else if (i == 2)//animals[i] == "sheep"
                    {
                        animal = new Sheep(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                           Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                           Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                           Convert.ToDouble(reader["Amount of wool"]));
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                    }
                    else if (i == 3)//animals[i] == "dogs"
                    {
                        animal = new Dog(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString());
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                    }
                    else if (i == 4)
                    {
                        commodities[commodityTracker] = Convert.ToDouble(reader["Price"]);
                        commodityTracker++;
                    }
                }
            }//end of table loop
            //update commodities
            Pricing.goatMilkPrice = commodities[0];
            Pricing.sheepWoolPrice = commodities[1];
            Pricing.waterPrice = commodities[2];
            Pricing.generalTax = commodities[3];
            Pricing.jerseyCowTax = commodities[4];
            Pricing.cowMilkPrice = commodities[5];
            //close connection
            connection.Close();
        }//end of initializeDatabase
    }//end of class Database
}//end of namespace
