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
        //end of getter setter
        public LiveStock(int id)
        {
            this.id = id;
        }//end of constructor

        public virtual void calculateProfit()
        {
        }//end of default calculateProfit

		public virtual void displayInfo()
		{

		}
	}
}
