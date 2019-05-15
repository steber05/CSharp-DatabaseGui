using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevAssignment
{
    class Auxiliary
    {
        //counts to keep track of each seperate animal
        public static int jerseyCowCount = 0;
        public static int cowCount = 0;
        public static int dogCount = 0;
        public static int goatCount = 0;
        public static int sheepCount = 0;
        public static int animalCount = 0;
        //seperate animals based on type
        public static LiveStock[] jerseyCows;
        public static LiveStock[] cows;
        public static LiveStock[] dogs;
        public static LiveStock[] goats;
        public static LiveStock[] sheep;
        public static LiveStock[] allStock;
    }
}
