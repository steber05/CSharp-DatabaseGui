using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class Sheep : LiveStock
    {
        public double wool { get; set; }
        string type { get; set; }
        //end of getter setters
        public Sheep(int id, double water, double cost, double weight, int age, string colour, double wool) : base(id, water, cost, weight, age, colour)
        {
			this.id = id;
			this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
            this.wool = wool;
            this.type = "Sheep";
        }//end of constructor

        public override void DisplayInfo()
        {
            MessageBox.Show(type + " details\n--------\nID: " + id + "\nAmount of water: " + water +
                            "\nDaily cost: " + cost + "\nWeight: " + weight + "\nAge: " + age +
                            "\nColour: " + colour + "\nAmount of wool: " + wool);
        }//end of overriden displayInfo

        public override double CalculateProfit()
        {
            double profit = 0;
            profit += wool * (Pricing.sheepWoolPrice * 365);
            profit -= water * Pricing.waterPrice;
            profit -= Pricing.generalTax * weight;
            return profit;
        }//end of overviden calculateProfit

        public override double CalculateTax()
        {
            double tax = 0;
            tax += Pricing.generalTax * weight;
            return tax;
        }//end of overriden calculateTax

        public override bool IsRed()
        {
            bool red = false;

            if (this.colour.ToLower() == "red") red = true;
            else red = false;

            return red;
        }//end of overriden isRed
    }
}
