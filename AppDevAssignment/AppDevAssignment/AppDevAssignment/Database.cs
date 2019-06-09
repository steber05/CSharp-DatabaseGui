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

        /// <summary>
        /// Reset all variables affected by initializeDatabase()
        /// </summary>
        public static void ResetDataStructures()
        {
            //used after error checking to stop duplicate entry attempts.
            allAnimals = null;
            Auxiliary.cows = null;
            Auxiliary.cowCount = 0;
            Auxiliary.dogs = null;
            Auxiliary.dogCount = 0;
            Auxiliary.goats = null;
            Auxiliary.goatCount = 0;
            Auxiliary.jerseyCows = null;
            Auxiliary.jerseyCowCount = 0;
            Auxiliary.sheep = null;
            Auxiliary.sheepCount = 0;
            Auxiliary.animalCount = 0;
            Auxiliary.commodities = null;
            Auxiliary.allStock = null;
        }

        /// <summary>
        /// Initialize all dependencies from a local access database file
        /// </summary>
        /// <param name="file"></param>
        public static void InitializeDatabase(string file)
        {
            //reinitialize for error checking purposes
            ResetDataStructures();
            allAnimals = new Dictionary<int, LiveStock>();//re initialize hash table

            //variable database elements
            string[] tableNames = tableNames = new string[] { "cows", "dogs", "goats", "sheep", "[Commodity Prices]" };//array used to loop through each table

            String tableName;//allows for a loop through the whole database
            string query;//changes based on which table we are on
            Auxiliary.commodities = new double[6];//hardcoded because this table is not usually added to or removed from
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
                        Auxiliary.jerseyCowCount++;//increment counter for seperate arrays
                        Auxiliary.animalCount++;
                    }//end of jersey cows
                    else if (i == 0)//cows
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Cow(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                         Convert.ToDouble(reader["Amount of milk"]), Convert.ToBoolean(reader["Is Jersy"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        Auxiliary.cowCount++;//increment counter for seperate arrays
                        Auxiliary.animalCount++;
                    }//end of cows
                    else if (i == 1)//dogs
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Dog(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                         Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                         Convert.ToInt32(reader["age"]), reader["color"].ToString());
                        //add temp animal to hash table
                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);
                        Auxiliary.dogCount++;//increment counter for seperate arrays
                        Auxiliary.animalCount++;
                    }//end of dogs
                    else if (i == 2)//goats
                    {
                        //create new animal this demonstrates inheritance and polymorphsm
                        animal = new Goat(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                          Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                          Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                          Convert.ToDouble(reader["Amount of milk"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        Auxiliary.goatCount++;//increment counter for seperate arrays
                        Auxiliary.animalCount++;
                    }//end of goats
                    else if (i == 3)//sheep
                    {
                        animal = new Sheep(Convert.ToInt32(reader["id"]), Convert.ToDouble(reader["Amount of water"]),
                                           Convert.ToDouble(reader["Daily cost"]), Convert.ToDouble(reader["weight"]),
                                           Convert.ToInt32(reader["age"]), reader["color"].ToString(),
                                           Convert.ToDouble(reader["Amount of wool"]));

                        allAnimals.Add(Convert.ToInt32(reader["id"]), animal);//add temp animal to hash table
                        Auxiliary.sheepCount++;//increment counter for seperate arrays
                        Auxiliary.animalCount++;
                    }//end of sheep
                    else if (i == 4)//commodities
                    {
                        Auxiliary.commodities[commodityTracker] = Convert.ToDouble(reader["Price"]);
                        commodityTracker++;//increment counter for seperate arrays
                    }//end of commodities
                }//end of reader loop
            }//end of table loop

            //close connection
            connection.Close();

            //update commodities
            Pricing.goatMilkPrice = Auxiliary.commodities[0];
            Pricing.sheepWoolPrice = Auxiliary.commodities[1];
            Pricing.waterPrice = Auxiliary.commodities[2];
            Pricing.generalTax = Auxiliary.commodities[3];
            Pricing.jerseyCowTax = Auxiliary.commodities[4];
            Pricing.cowMilkPrice = Auxiliary.commodities[5];

            //initialize auxilary arrays
            Auxiliary.jerseyCows = new LiveStock[Auxiliary.jerseyCowCount];
            Auxiliary.cows = new LiveStock[Auxiliary.cowCount];
            Auxiliary.dogs = new LiveStock[Auxiliary.dogCount];
            Auxiliary.goats = new LiveStock[Auxiliary.goatCount];
            Auxiliary.sheep = new LiveStock[Auxiliary.sheepCount];
            Auxiliary.allStock = new LiveStock[Auxiliary.animalCount - Auxiliary.dogCount];

            SplitToArrays();
            SortByProfit();
        }//end of initializeDatabase

        /// <summary>
        /// Split allAnimal dictionary into seperate arrays
        /// </summary>
        public static void SplitToArrays()
        {
            int cowCounter = 0;
            int jCowCounter = 0;
            int dogCounter = 0;
            int goatCounter = 0;
            int sheepCounter = 0;
            int allStockCounter = 0;

            foreach(LiveStock animal in allAnimals.Values)
            {
                if(animal.GetType() == typeof(Cow))
                {
                    Auxiliary.cows[cowCounter] = animal;
                    Auxiliary.allStock[allStockCounter] = animal;
                    cowCounter++;
                    allStockCounter++;
                }//end of cows
                else if (animal.GetType() == typeof(JerseyCow))
                {
                    Auxiliary.jerseyCows[jCowCounter] = animal;
                    Auxiliary.allStock[allStockCounter] = animal;
                    jCowCounter++;
                    allStockCounter++;
                }//end of jersey cows
                else if (animal.GetType() == typeof(Dog))
                {
                    Auxiliary.dogs[dogCounter] = animal;
                    dogCounter++;
                }//end of dogs
                else if (animal.GetType() == typeof(Goat))
                {
                    Auxiliary.goats[goatCounter] = animal;
                    Auxiliary.allStock[allStockCounter] = animal;
                    goatCounter++;
                    allStockCounter++;
                }//end of goats
                else if (animal.GetType() == typeof(Sheep))
                {
                    Auxiliary.sheep[sheepCounter] = animal;
                    Auxiliary.allStock[allStockCounter] = animal;
                    sheepCounter++;
                    allStockCounter++;
                }//end of sheep
            }
        }//end of SplitToArrays

        /// <summary>
        /// Sort allStock array by profitability using bubble sort
        /// </summary>
        public static void SortByProfit()
        {
            //sort allStock array
            LiveStock tempStock;
            for (int i = 0; i < Auxiliary.allStock.Length; i++)
            {
                for (int j = 0; j < Auxiliary.allStock.Length - 1; j++)
                {
                    if (Auxiliary.allStock[j].CalculateProfit() < Auxiliary.allStock[j + 1].CalculateProfit())
                    {
                        tempStock = Auxiliary.allStock[j + 1];
                        Auxiliary.allStock[j + 1] = Auxiliary.allStock[j];
                        Auxiliary.allStock[j] = tempStock;
                    }
                }
            }
        } //end of SortByProfit
    }//end of class Database
}//end of namespace
