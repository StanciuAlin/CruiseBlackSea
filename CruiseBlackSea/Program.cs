using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseBlackSea
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminForm("Heeeei", 0));
            //Application.Run(new UpdateDistanceForm());
            //Application.Run(new TouristForm("pop"));
            Application.Run(new AdminForm("graef"));

        }
    }
}
