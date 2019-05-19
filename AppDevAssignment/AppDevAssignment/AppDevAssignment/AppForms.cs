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
        public static Miscellaneous miscellaneousReport = new Miscellaneous();
        public static PartialReports partialReport = new PartialReports();
        public static TotalReports totalReport = new TotalReports();
    }
}
