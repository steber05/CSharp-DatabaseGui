using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class JerseyCow : LiveStock
    {
        public double milk { get; set; }
        bool jersey { get; set; }
        string type { get; set; }
        //end of getter setters
        public JerseyCow(int id, double water, double cost, double weight, int age, string colour, double milk, bool jersey) : base(id, water, cost, weight, age, colour)
        {
			this.id = id;
			this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
            this.milk = milk;
            this.jersey = jersey;
            this.type = "Jersey cow";
        }//end of constructor

        public override void DisplayInfo()
        {
            MessageBox.Show(type + " details\n--------\nID: " + id + "\nAmount of water: " + water +
                            "\nDaily cost: " + cost + "\nWeight: " + weight + "\nAge: " + age +
                            "\nColour: " + colour + "\nAmount of milk: " + milk);
        }//end of overriden displayInfo

        public override double CalculateProfit()
        {
            double profit = 0;
            profit += milk * (Pricing.cowMilkPrice * 365);
            profit -= water * Pricing.waterPrice;
            profit -= Pricing.generalTax * weight;
            profit -= Pricing.jerseyCowTax;
            return profit;
        }//end of overriden calculateProfit

        public override double CalculateTax()
        {
            double tax = 0;
            tax += (Pricing.generalTax * weight) * 365;
            tax += Pricing.jerseyCowTax;
            return tax;
        }//end of overriden calculateTax

        public override double AmountOfMilk()
        {
            return this.milk;
        }//end of overriden amountOfMilk

        public override bool IsJersey()
        {
            return this.jersey;
        }//end of overriden isJersey

        public override bool IsRed()
        {
            bool red = false;

            if (this.colour.ToLower() == "red") red = true;
            else red = false;

            return red;
        }//end of overriden isRed
    }
}