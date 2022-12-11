using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSO_App_Dev_Project
{
    internal static class Program
    {

        private static User loggedInUser = null;
        private static UserLoginForm usf = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            usf = new UserLoginForm();
            Application.Run(usf);
            //Application.Run(new MainScreenForm(null));
        }

        public static User LoggedInUser
        {
            get
            {
                return loggedInUser;
            }
            set
            {
                loggedInUser = value;
            }
        }

        public static void closeLogInScreen() 
        {
            usf.Close();
        }

    }
}
