using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class LiveStock
    {
        public int id { get; set; }
        public double water { get; set; }
        public double cost { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public string colour { get; set; }
        //end of getter setter
        public LiveStock(int id, double water, double cost, double weight, int age, string colour)
        {
            this.id = id;
            this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }//end of constructor

        public virtual void DisplayInfo()
        {
        }//end of displayInfo

        public virtual double CalculateProfit()
        {
            return 0;
        }//end of default calculateProfit

        public virtual double CalculateTax()
        {
            return 0;
        }//end of default calculateTax

        public virtual double AmountOfMilk()
        {
            return 0;
        }//end of amountOfMilk

        public virtual bool IsJersey()
        {
            return false;
        }//end of amountOfMilk

        public virtual bool IsRed()
        {
            return false;
        }//end of isRed
	}
}
