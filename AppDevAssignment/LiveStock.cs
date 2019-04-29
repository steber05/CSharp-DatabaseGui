using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevAssignment
{
    class LiveStock
    {
        int id { get; set; }
        //end of getter setter
        public LiveStock(int id)
        {
            this.id = id;
        }//end of constructor

        public virtual void calculateProfit()
        {
        }//end of default calculateProfit
    }
}
