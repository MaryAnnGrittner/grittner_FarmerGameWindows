using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Assignment No:   3A
 * Programmer   :   Mary Ann Grittner
 * Purpose      :   Start and end of program
 */

namespace grittner_FarmerGameWindows
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
            Application.Run(new FarmerGameUI());
        }
    }
}
