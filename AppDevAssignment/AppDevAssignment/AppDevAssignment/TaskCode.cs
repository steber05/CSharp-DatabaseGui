using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppDevAssignment
{
    class TaskCode
    {

        //Task 2 Display the total profitability/loose of the farm per day
        public static void TotalDailyProfitLoss()
        {
            double totalProfit = 0;

            for(int i=0;i<Auxiliary.allStock.Length;i++)
            {
                totalProfit += Auxiliary.allStock[i].CalculateProfit() / 365;
            }

            MessageBox.Show("Total daily profit/loss\n" + "---------------------\n$" + Math.Round(totalProfit, 2).ToString());
        }//end of Task 2

        //Task 3 Display the total tax paid to the government per month 
        public static void CalculateMonthlyTax()
        {
            double tax = 0;

            for (int i = 0; i < Auxiliary.allStock.Length; i++)
            {
                tax += Auxiliary.allStock[i].CalculateTax() / 12;
            }

            MessageBox.Show("Tax per month\n" + "---------------------\n$" + Math.Round(tax, 2).ToString());
        }//end of Task 3

        //Task 4 Display the total amount of milk per day for goats and cows
        public static void CalculateGoatCowMilk()
        {
            double goatCowMilk = 0;

            //loop through all cows and goats and collect amountOfMilk
            for (int i = 0; i < Auxiliary.jerseyCows.Length; i++)
            {
                goatCowMilk += Auxiliary.jerseyCows[i].AmountOfMilk();
            }
            for (int j = 0; j < Auxiliary.cows.Length; j++)
            {
                goatCowMilk += Auxiliary.cows[j].AmountOfMilk();
            }
            for (int k = 0; k < Auxiliary.goats.Length; k++)
            {
                goatCowMilk += Auxiliary.goats[k].AmountOfMilk();
            }

            //display amount of milk for all cows and goats
            MessageBox.Show("Cow and goat milk\n" + "---------------------\n" + Math.Round(goatCowMilk, 2).ToString() + "Kg's");
        }//end of Task 4

        //task 5 Display the average age of all animal farms(dog excluded)
        public static void CalculateAvgAge()
        {
            int ages = 0;
            int avgAge = 0;

            //loop through all animals except dogs
            for (int i = 0; i < Auxiliary.jerseyCows.Length; i++)
            {
                ages += Auxiliary.jerseyCows[i].age;
            }
            for (int j = 0; j < Auxiliary.cows.Length; j++)
            {
                ages += Auxiliary.cows[j].age;
            }
            for (int k = 0; k < Auxiliary.goats.Length; k++)
            {
                ages += Auxiliary.goats[k].age;
            }
            for (int l = 0; l < Auxiliary.sheep.Length; l++)
            {
                ages += Auxiliary.sheep[l].age;
            }

            avgAge = ages / (Auxiliary.animalCount - Auxiliary.dogCount);

            //display amount of milk for all cows and goats
            MessageBox.Show("Average age\n" + "---------------------\n" + avgAge.ToString());
        }//end of Task 5

        //Task 6 Display the average profitability of “Goats and Cow” Vs. Sheep
        public static void CalculateProfitDifference()
        {
            double jerseyCowProfit = 0;
            double cowProfit = 0;
            double goatProfit = 0;
            double sheepProfit = 0;
            double avgCowGoatProfit = 0;
            double avgSheepProfit = 0;

            //loop through all cows and goats and collect amountOfMilk
            for (int i = 0; i < Auxiliary.jerseyCows.Length; i++)
            {
                jerseyCowProfit += Auxiliary.jerseyCows[i].CalculateProfit();
            }
            for (int j = 0; j < Auxiliary.cows.Length; j++)
            {
                cowProfit += Auxiliary.cows[j].CalculateProfit();
            }
            for (int k = 0; k < Auxiliary.goats.Length; k++)
            {
                goatProfit += Auxiliary.goats[k].CalculateProfit();
            }
            for (int l = 0; l < Auxiliary.sheep.Length; l++)
            {
                sheepProfit += Auxiliary.sheep[l].CalculateProfit();
            }

            avgCowGoatProfit = (jerseyCowProfit + cowProfit + goatProfit) / (Auxiliary.jerseyCowCount + Auxiliary.cowCount + Auxiliary.goatCount);
            avgSheepProfit = sheepProfit / Auxiliary.sheepCount;

            //display amount of milk for all cows and goats
            MessageBox.Show("Average cow/goat profit\n" + "--------------------------------\n$" + Math.Round(avgCowGoatProfit, 2).ToString() +
                            "\nAverage sheep profit\n" + "--------------------------------\n$" + Math.Round(avgSheepProfit, 2).ToString());
        }//end of Task 6

        //Task 7 Display the ratio of Dogs’ cost compared to the total cost
        public static void CalculateCostDifference()
        {
            double animalCosts = 0;//all animals except dogs
            double dogCosts = 0;
            double ratio = 0;

            for (int i = 0; i < Auxiliary.jerseyCows.Length; i++)
            {
                animalCosts += Auxiliary.jerseyCows[i].cost;
            }
            for (int j = 0; j < Auxiliary.cows.Length; j++)
            {
                animalCosts += Auxiliary.cows[j].cost;
            }
            for (int k = 0; k < Auxiliary.goats.Length; k++)
            {
                animalCosts += Auxiliary.goats[k].cost;
            }
            for (int l = 0; l < Auxiliary.sheep.Length; l++)
            {
                animalCosts += Auxiliary.sheep[l].cost;
            }
            for (int m = 0; m < Auxiliary.dogs.Length; m++)
            {
                dogCosts += Auxiliary.dogs[m].cost;
            }

            ratio = animalCosts / dogCosts;

            MessageBox.Show("Other animal costs\n" + "--------------------------------\n$" + Math.Round(animalCosts, 2).ToString() +
                            "\nDog costs\n" + "--------------------------------\n$" + Math.Round(dogCosts, 2).ToString() +
                            "\nDog cost ratio\n" + "--------------------------------\n$" + Math.Round(ratio, 2).ToString());
        }//end of Task 7

        //Task 8 Generate a file that contains the ID of all animal ordered by their profitability
        //(You are not allowed to use built-in sorting algorithm – Your code must do the sorting). Dogs are excluded
        public static void PrintIDToFile()//chose to use bubble sort and put up with the O(n^2)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text file|*.txt|All files|*.*";
            file.Title = "Save a text File";
            file.ShowDialog();
            if(file.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(file.FileName))
                {
                    writer.WriteLine("ID ordered by profit (Highest to lowest)\n----------------------------------------");
                    for (int i = 0; i < Auxiliary.allStock.Length; i++)
                    {
                        writer.Write(Auxiliary.allStock[i].id + "\n");
                    }
                }
            }
        }//end of Task 8

        //Task 9 Display the ratio of livestock with the color red 
        public static void CalculateAllRed()
        {
            double amountOfRed = 0;
            double redRatio = 0;

            //loop through and find all red animals
            for (int i = 0; i < Auxiliary.allStock.Length; i++)
            {
                if (Auxiliary.allStock[i].IsRed())
                {
                    amountOfRed++;
                }
            }
            for (int j = 0; j < Auxiliary.dogs.Length; j++)
            {
                if (Auxiliary.dogs[j].IsRed())
                {
                    amountOfRed++;
                }
            }

            //calculate ratio
            redRatio = (amountOfRed / Auxiliary.animalCount);
            redRatio *= 100;

            MessageBox.Show("Number of animals\n" + "-----------------------------\n" + Auxiliary.animalCount.ToString() +
                            "\nNumber of red animals\n" + "-----------------------------\n" + amountOfRed.ToString() +
                            "\nRed animal ratio\n" + "-----------------------------\n" + "%" + redRatio.ToString() + " of animals are red");
        }//end of Task 9

        //Task 10 Display the total tax paid for Jersey Cows
        public static void JerseyCowTax()
        {
            double jerseyCowTax = 0;

            for (int i = 0; i < Auxiliary.jerseyCows.Length; i++)
            {
                jerseyCowTax += Auxiliary.jerseyCows[i].CalculateTax();
            }

            MessageBox.Show("Total jersey cow tax\n--------------------------\n$" + Math.Round(jerseyCowTax, 2).ToString());
        }//end of Task 10

        //Task 11 The user enter a threshold (number of years), and the program displays the ratio of 
        //the number of animal farm where the age is above this threshold.
        public static void DisplayAgesAbove(int num)
        {
            double aboveAge = 0;
            double ratio = 0;

            for (int i = 0; i < Auxiliary.allStock.Length; i++)
            {
                if (Auxiliary.allStock[i].age > num)
                {
                    aboveAge++;
                }
            }
            for (int j = 0; j < Auxiliary.dogs.Length; j++)
            {
                if (Auxiliary.dogs[j].age > num)
                {
                    aboveAge++;
                }
            }

            ratio = aboveAge / Auxiliary.animalCount;
            ratio *= 100;

            MessageBox.Show("Number of animals\n" + "-----------------------------\n" + Auxiliary.animalCount.ToString() +
                            "\nNumber of animals above the age of: " + num.ToString() + "\n" + "-----------------------------\n" + aboveAge.ToString() +
                            "\nRatio\n-----------\n%" + ratio.ToString());
        }//end of Task 11

        //Task 12 Display the total profitability of all Jersey Cows.
        public static void JerseyCowProfit()
        {
            double jerseyCowProfit = 0;
            for (int i = 0; i < Auxiliary.jerseyCows.Length; i++)
            {
                jerseyCowProfit += Auxiliary.jerseyCows[i].CalculateProfit();
            }

            MessageBox.Show("Total jersey cow profit\n" + "---------------------\n$" + Math.Round(jerseyCowProfit, 2).ToString());
        }//end of Task 12
    }
}
