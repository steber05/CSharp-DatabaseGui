using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevAssignment
{
    class Cow : LiveStock
    {
        public double water { get; set; }
        public double cost { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public string colour { get; set; }
        public double milk { get; set; }
        string type { get; set; }
        //end of getter setters
        public Cow(int id, double water, double cost, double weight, int age, string colour, double milk) : base(id)
        {
			this.id = id;
            this.water = water;
            this.cost = cost;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
            this.milk = milk;
        }//end of constructor

        public override void calculateProfit()
        {
        }//end of overriden calculateProfit
		public override void displayInfo()
		{
            MessageBox.Show("Cow details\n--------\nID: " + id + "\nAmount of water: " + water +
                            "\nDaily cost: " + cost + "\nWeight: " + weight + "\nAge: " + age +
                            "\nColour: " + colour + "\nAmount of milk: " + milk);
        }
    }
}