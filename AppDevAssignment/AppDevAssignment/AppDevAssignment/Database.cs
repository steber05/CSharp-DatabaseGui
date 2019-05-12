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
                        Auxilary.jerseyCowCount++;//increment counter for seperate arrays
                        Auxilary.animalCount++;
                    }//end of jersey cows
                    else if (i == 0)//cows
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Cow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]), 
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]), 
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString(), 
                                         Convert.ToDouble(reader["Amount of milk"]), Convert.ToBoolean(reader["Is Jersy"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        Auxilary.cowCount++;//increment counter for seperate arrays
                        Auxilary.animalCount++;
                    }//end of cows
                    else if (i == 1)//dogs
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Dog(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString());
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                        Auxilary.dogCount++;//increment counter for seperate arrays
                        Auxilary.animalCount++;
                    }//end of dogs
                    else if (i == 2)//goats
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Goat(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                          Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                          Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                          Convert.ToDouble(reader["Amount of milk"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        Auxilary.goatCount++;//increment counter for seperate arrays
                        Auxilary.animalCount++;
                    }//end of goats
                    else if (i == 3)//sheep
                    {
                        animal = new Sheep(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                           Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                           Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                           Convert.ToDouble(reader["Amount of wool"]));
                        
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        Auxilary.sheepCount++;//increment counter for seperate arrays
                        Auxilary.animalCount++;
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
            Auxilary.jerseyCows = new LiveStock[Auxilary.jerseyCowCount];
            Auxilary.cows = new LiveStock[Auxilary.cowCount];
            Auxilary.dogs = new LiveStock[Auxilary.dogCount];
            Auxilary.goats = new LiveStock[Auxilary.goatCount];
            Auxilary.sheep = new LiveStock[Auxilary.sheepCount];
            Auxilary.allStock = new LiveStock[Auxilary.animalCount - Auxilary.dogCount];
            int allStockCounter = 0;
            int genericCounter = 0;
            int jCowCounter = 0;
            //update auxilary arrays based on IDs. If ID structure changes it can be reflected here
            for (int i = 1001; i < ((1001 + Auxilary.cowCount) + Auxilary.jerseyCowCount) + 50; i++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
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
                    Auxilary.allStock[allStockCounter] = animal;
                    allStockCounter++;
                    jCowCounter++;
                    
                }
                else
                {
                    Auxilary.cows[genericCounter] = animal;
                    Auxilary.allStock[allStockCounter] = animal;
                    allStockCounter++;
                    genericCounter++;
                }
            }//end of jersey cows and cows
            genericCounter = 0;//reset counter
            for (int j = 5000; j < (5000 + Auxilary.dogCount) + 50; j++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
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
            for (int k = 1101; k < (1101 + Auxilary.goatCount) +50; k++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
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
                Auxilary.allStock[allStockCounter] = animal;
                allStockCounter++;
                genericCounter++;
            }//end of goats
            genericCounter = 0;
            for (int l = 3001; l < (3001 + Auxilary.sheepCount) + 50; l++)//+50 to create leverage for deleted animals from database (Not all ids were in order)
            {
                try
                {
                    animal = allAnimals[l];
                }
                catch (Exception)
                {
                    continue;
                }
                Auxilary.sheep[genericCounter] = animal;
                Auxilary.allStock[allStockCounter] = animal;
                allStockCounter++;
                genericCounter++;
            }//end of sheep loop reminder to add the id 0
            Auxilary.sheep[genericCounter] = allAnimals[0];//bad database design based on ID structure
            Auxilary.allStock[allStockCounter] = allAnimals[0];

            //sort allStock array
            LiveStock tempStock;
            for (int i = 0; i < Auxilary.allStock.Length; i++)
            {
                for (int j = 0; j < Auxilary.allStock.Length - 1; j++)
                {
                    if (Auxilary.allStock[j].CalculateAge() < Auxilary.allStock[j + 1].CalculateProfit())
                    {
                        tempStock = Auxilary.allStock[j + 1];
                        Auxilary.allStock[j + 1] = Auxilary.allStock[j];
                        Auxilary.allStock[j] = tempStock;
                    }
                }
            }
        }//end of initializeDatabase
    }//end of class Database
}//end of namespace
