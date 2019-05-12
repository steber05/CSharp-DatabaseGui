using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class Goat : LiveStock
    {
        public double water { get; set; }
        public double cost { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public string colour { get; set; }
        public double milk { get; set; }
        //end of getter setters
        public Goat(int id, double water, double cost, double weight, int age, string colour, double milk) : base(id)
        {
			this.id = id;
			this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
            this.milk = milk;
        }//end of constructor

        public override void DisplayInfo()
        {
            MessageBox.Show("Goat details\n--------\nID: " + id + "\nAmount of water: " + water +
                            "\nDaily cost: " + cost + "\nWeight: " + weight + "\nAge: " + age +
                            "\nColour: " + colour + "\nAmount of milk: " + milk);
        }//end of overriden displayInfo

        public override double CalculateProfit()
        {
            double profit = (milk * Pricing.cowMilkPrice) - (water * Pricing.waterPrice);
            return profit;
        }//end of overviden calculateProfit
        public override double AmountOfMilk()
        {
            return this.milk;
        }//end of overriden amountOfMilk

        public override bool IsRed()
        {
            bool red = false;

            if (this.colour == "red") red = true;
            else red = false;

            return red;
        }//end of overriden isRed

    }
}
