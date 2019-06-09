using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class Dog : LiveStock
    {
        string type { get; set; }
        //end of getter setters
        public Dog(int id, double water, double cost, double weight, int age, string colour) : base(id, water, cost, weight, age, colour)
        {
			this.id = id;
			this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
            this.type = "Dog";
        }//end of constructor

        public override void DisplayInfo()
        {
            MessageBox.Show(type + " details\n--------\nID: " + id + "\nAmount of water: " + water +
                            "\nDaily cost: " + cost + "\nWeight: " + weight + "\nAge: " + age +
                            "\nColour: " + colour);
        }//end of overriden displayInfo

        public override bool IsRed()
        {
            bool red = false;

            if (this.colour.ToLower() == "red") red = true;
            else red = false;

            return red;
        }//end of overriden isRed

    }
}

