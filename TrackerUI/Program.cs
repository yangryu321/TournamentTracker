using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
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

            //Set up database connection 
            GlobalConfig.InitializeConnections(Enum_Database.sql);

            Application.Run(new TournamentDashboard());
        }
    }
}
