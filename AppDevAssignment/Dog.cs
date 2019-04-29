using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevAssignment
{
    class Dog : LiveStock
    {
        public double water { get; set; }
        public double cost { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public string colour { get; set; }
        //end of getter setters
        public Dog(int id, double water, double cost, double weight, int age, string colour) : base(id)
        {
            this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }//end of constructor

        public override void calculateProfit()
        {
        }//end of overviden calculateProfit
    }
}

