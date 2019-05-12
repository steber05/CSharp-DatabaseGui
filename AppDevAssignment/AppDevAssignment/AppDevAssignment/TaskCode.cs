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


        //Task 4 Display the total amount of milk per day for goats and cows
        public static void CalculateGoatCowMilk()
        {
            double goatCowMilk = 0;

            //loop through all cows and goats and collect amountOfMilk
            for (int i = 0; i < Auxilary.jerseyCows.Length; i++)
            {
                goatCowMilk += Auxilary.jerseyCows[i].AmountOfMilk();
            }
            for (int j = 0; j < Auxilary.cows.Length; j++)
            {
                goatCowMilk += Auxilary.cows[j].AmountOfMilk();
            }
            for (int k = 0; k < Auxilary.goats.Length; k++)
            {
                goatCowMilk += Auxilary.goats[k].AmountOfMilk();
            }

            //display amount of milk for all cows and goats
            MessageBox.Show("Cow and goat milk\n" + "---------------------\n" + goatCowMilk.ToString());
        }

        //task 5 Display the average age of all animal farms(dog excluded)
        public static void CalculateAvgAge()
        {
            int ages = 0;
            int avgAge = 0;

            //loop through all animals except dogs
            for (int i = 0; i < Auxilary.jerseyCows.Length; i++)
            {
                ages += Auxilary.jerseyCows[i].CalculateAge();
            }
            for (int j = 0; j < Auxilary.cows.Length; j++)
            {
                ages += Auxilary.cows[j].CalculateAge();
            }
            for (int k = 0; k < Auxilary.goats.Length; k++)
            {
                ages += Auxilary.goats[k].CalculateAge();
            }
            for (int l = 0; l < Auxilary.sheep.Length; l++)
            {
                ages += Auxilary.sheep[l].CalculateAge();
            }

            avgAge = ages / (Auxilary.animalCount - Auxilary.dogCount);

            //display amount of milk for all cows and goats
            MessageBox.Show("Average age\n" + "---------------------\n" + avgAge.ToString());
        }

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
            for (int i = 0; i < Auxilary.jerseyCows.Length; i++)
            {
                jerseyCowProfit += Auxilary.jerseyCows[i].CalculateProfit();
            }
            for (int j = 0; j < Auxilary.cows.Length; j++)
            {
                cowProfit += Auxilary.cows[j].CalculateProfit();
            }
            for (int k = 0; k < Auxilary.goats.Length; k++)
            {
                goatProfit += Auxilary.goats[k].CalculateProfit();
            }
            for (int l = 0; l < Auxilary.sheep.Length; l++)
            {
                sheepProfit += Auxilary.sheep[l].CalculateProfit();
            }

            avgCowGoatProfit = (jerseyCowProfit + cowProfit + goatProfit) / (Auxilary.jerseyCowCount + Auxilary.cowCount + Auxilary.goatCount);
            avgSheepProfit = sheepProfit / Auxilary.sheepCount;

            //display amount of milk for all cows and goats
            MessageBox.Show("Average cow/goat profit\n" + "--------------------------------\n" + avgCowGoatProfit.ToString() +
                            "\nAverage sheep profit\n" + "--------------------------------\n" + avgSheepProfit.ToString());
        }

        //Task 7 Display the ratio of Dogs’ cost compared to the total cost
        public static void CalculateCostDifference()
        {
            double animalCosts = 0;
            double dogCosts = 0;
            double ratio = 0;

            for (int i = 0; i < Auxilary.jerseyCows.Length; i++)
            {
                animalCosts += Auxilary.jerseyCows[i].CalculateCost();
            }
            for (int j = 0; j < Auxilary.cows.Length; j++)
            {
                animalCosts += Auxilary.cows[j].CalculateCost();
            }
            for (int k = 0; k < Auxilary.goats.Length; k++)
            {
                animalCosts += Auxilary.goats[k].CalculateCost(); ;
            }
            for (int l = 0; l < Auxilary.sheep.Length; l++)
            {
                animalCosts += Auxilary.sheep[l].CalculateCost();
            }
            for (int m = 0; m < Auxilary.dogs.Length; m++)
            {
                dogCosts += Auxilary.dogs[m].CalculateCost();
            }

            ratio = animalCosts / dogCosts;

            MessageBox.Show("Other animal costs\n" + "--------------------------------\n$" + animalCosts.ToString() +
                            "\nDog costs\n" + "--------------------------------\n$" + dogCosts.ToString() +
                            "\nDog cost ratio\n" + "--------------------------------\n$" + ratio.ToString());
        }

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
                    for (int i = 0; i < Auxilary.allStock.Length; i++)
                    {
                        writer.Write(Auxilary.allStock[i].CalculateAge() + "\n");
                    }
                }
            }
        }
    }
}
