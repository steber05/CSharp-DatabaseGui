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

        public virtual void DisplayInfo()
        {
        }//end of displayInfo

        public virtual double CalculateProfit()
        {
            return 0;
        }//end of default calculateProfit

        public virtual double AmountOfMilk()
        {
            return 0;
        }//end of amountOfMilk

        public virtual bool IsJersey()
        {
            return false;
        }//end of amountOfMilk

        public virtual int CalculateAge()
        {
            return 0;
        }
        public virtual double CalculateCost()
        {
            return 0;
        }//end of overriden calculateAge

        public virtual bool IsRed()
        {
            return false;
        }//end of isRed
	}
}
