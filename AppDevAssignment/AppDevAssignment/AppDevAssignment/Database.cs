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

        public static Dictionary<int, LiveStock> allAnimals;
        public static void InitializeDatabase(string file)
        {
            //reinitialize for error checking purposes
            allAnimals = null;//used after error checking to stop duplicate entry attempts. Also should be picked up by garbage collection
            allAnimals = new Dictionary<int, LiveStock>();//re initialize hash table

            //variable database elements
            string[] tableNames = new string[] { "cows", "dogs", "goats", "sheep", "[Commodity Prices]" };//array used to loop through each table
            String tableName;//allows for a loop through the whole database
            string query;//changes based on which table we are on
            double[] commodities = new double[6];//hardcoded because this table is not usually added to or removed from
            int commodityTracker = 0;

            //database structure
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Persist Security Info=False");
            OleDbCommand cmd;//generic DBCommand uses tablename && connection
            OleDbDataReader reader;//executes cmd and traverses database in a while loop 

            LiveStock animal;//temp animal for adding to hash table

            //counts to keep track for creating seperate arrays
            int jerseyCowCount = 0;
            int cowCount = 0;
            int dogCount = 0;
            int goatCount = 0;
            int sheepCount = 0;

            //establish connection to database
            connection.Open();

            //loop through each table and add each row to hash table
            for (int i = 0; i < tableNames.Length; i++)
            {
                //database variations
                tableName = tableNames[i];// Name of the table
                query = "SELECT * FROM " + tableName;
                cmd = new OleDbCommand(query, connection);
                reader = cmd.ExecuteReader();

                //traverse database
                while (reader.Read())//Read each row of each animal table
                {
                    if (i == 0 && Convert.ToBoolean(reader["Is Jersy"]))//jersey cows
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new JerseyCow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                               Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                               Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                               Convert.ToDouble(reader["Amount of milk"]), Convert.ToBoolean(reader["Is Jersy"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);////add temp animal to hash table
                        jerseyCowCount++;//increment counter for seperate arrays
                    }//end of jersey cows
                    else if (i == 0)//cows
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Cow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                         Convert.ToDouble(reader["Amount of milk"]), Convert.ToBoolean(reader["Is Jersy"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        cowCount++;//increment counter for seperate arrays
                    }//end of cows
                    else if (i == 1)//dogs
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Dog(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString());
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                        dogCount++;//increment counter for seperate arrays
                    }//end of dogs
                    else if (i == 2)//goats
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Goat(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                          Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                          Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                          Convert.ToDouble(reader["Amount of milk"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        goatCount++;//increment counter for seperate arrays
                    }//end of goats
                    else if (i == 3)//sheep
                    {
                        animal = new Sheep(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                           Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                           Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                           Convert.ToDouble(reader["Amount of wool"]));
                        
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        sheepCount++;//increment counter for seperate arrays
                    }//end of sheep
                    else if (i == 4)//commodities
                    {
                        commodities[commodityTracker] = Convert.ToDouble(reader["Price"]);
                        commodityTracker++;//increment counter for seperate arrays
                    }//end of commodities
                }//end of reader loop
            }//end of table loop

            //close connection
            connection.Close();

            //initialize auxilary arrays
            Auxilary.jerseyCows = new LiveStock[jerseyCowCount];
            Auxilary.cows = new LiveStock[cowCount];
            Auxilary.dogs = new LiveStock[dogCount];
            Auxilary.goats = new LiveStock[goatCount];
            Auxilary.sheep = new LiveStock[sheepCount];
            int genericCounter = 0;
            int jCowCounter = 0;
            //update auxilary arrays based on IDs. If ID structure changes it can be reflected here
            for (int i = 1001; i < ((1001 + cowCount) + jerseyCowCount) + 50; i++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
            {
                try
                {
                    animal = allAnimals[i];
                }
                catch (Exception)
                {
                    continue;
                } 
                //check if jersey cow or not
                if (animal.IsJersey())
                {
                    Auxilary.jerseyCows[jCowCounter] = animal;
                    jCowCounter++;
                }
                else
                {
                    Auxilary.cows[genericCounter] = animal;
                    genericCounter++;
                }
            }//end of jersey cows and cows
            genericCounter = 0;//reset counter
            for (int j = 5000; j < (5000 + dogCount) + 50; j++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
            {
                try
                {
                    animal = allAnimals[j];
                }
                catch (Exception)
                {
                    continue;
                }
                Auxilary.dogs[genericCounter] = animal;
                genericCounter++;
            }//end of dogs
            genericCounter = 0;
            for (int k = 1101; k < (1101 + goatCount) +50; k++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
            {
                try
                {
                    animal = allAnimals[k];
                }
                catch (Exception)
                {
                    continue;
                }
                Auxilary.goats[genericCounter] = animal;
                genericCounter++;
            }//end of goats
            genericCounter = 0;
            for (int l = 3001; l < (3001 + sheepCount) + 50; l++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
            {
                try
                {
                    animal = allAnimals[l];
                }
                catch (Exception ex)
                {
                    continue;
                }
                Auxilary.sheep[genericCounter] = animal;
                genericCounter++;
            }//end of sheep loop reminder to add the id 0
            Auxilary.sheep[genericCounter] = allAnimals[0];//bad database design based on ID structure
        }//end of initializeDatabase
    }//end of class Database
}//end of namespace
