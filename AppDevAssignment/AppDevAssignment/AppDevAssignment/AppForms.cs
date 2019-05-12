using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevAssignment
{
    class AppForms
    {
        public static bool mainMenuVisible;
        public static MainMenu mainMenu = new MainMenu();
        public static IndividualReports individualReport = new IndividualReports();
        public static Miscellaneous miscellaneous = new Miscellaneous();
    }
}
