using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;

namespace TSO_App_Dev_Project
{
    internal static class Program
    {
        private static bool haha = true;
        private static User loggedInUser = null;
        private static UserLoginForm usf = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Internationalization

            var language = ConfigurationManager.AppSettings["language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            usf = new UserLoginForm();
            Application.Run(usf);
            //Application.Run(new MiceForm(null));
            //Application.Run(new StudiesForm(null));
            //Application.Run(new MainScreenForm(null));



            if (usf.UserAuth)
            {
                MainScreenForm m = new MainScreenForm(loggedInUser);
                StudiesForm s = new StudiesForm(loggedInUser);
                MiceForm r = new MiceForm(loggedInUser);
                LogsForm l = new LogsForm(loggedInUser);
                AccountForm t = new AccountForm(loggedInUser);

                Application.Run(m);

                    switch (m.chgPage)
                    {
                        case 's':
                            Application.Run(s);
                            m.Close();
                            break;
                        case 'r':
                            Application.Run(r);
                            m.Close();
                            break;
                        case 'l':
                            Application.Run(l);
                            m.Close();
                            break;
                        case 't':
                            Application.Run(t);
                            m.Close();
                            break;
                        default: break;
                    }
                    // Studies page
                    switch (s.chgPage)
                    {
                        case 'm':
                            Application.Run(m);
                            s.Close();
                            break;
                        case 'r':
                            Application.Run(r);
                            s.Close();
                            break;
                        case 'l':
                            Application.Run(l);
                            s.Close();
                            break;
                        case 't':
                            Application.Run(t);
                            s.Close();
                            break;
                        default: break;
                    }
                    // Mice
                    switch (r.chgPage)
                    {
                        case 's':
                            Application.Run(s);
                            r.Close();
                            break;
                        case 'm':
                            Application.Run(m);
                            r.Close();
                            break;
                        case 'l':
                            Application.Run(l);
                            r.Close();
                            break;
                        case 't':
                            Application.Run(t);
                            r.Close();
                            break;
                        default: break;
                    }

                    // Logs
                    switch (l.chgPage)
                    {
                        case 's':
                            Application.Run(s);
                            l.Close();
                            break;
                        case 'r':
                            Application.Run(r);
                            l.Close();
                            break;
                        case 'm':
                            Application.Run(m);
                            l.Close();
                            break;
                        case 't':
                            Application.Run(t);
                            l.Close();
                            break;
                        default: break;
                    }
                    // Account
                    switch (t.chgPage)
                    {
                        case 's':
                            Application.Run(s);
                            t.Close();
                            break;
                        case 'r':
                            Application.Run(r);
                            t.Close();
                            break;
                        case 'l':
                            Application.Run(l);
                            t.Close();
                            break;
                        case 'm':
                            Application.Run(m);
                            t.Close();
                            break;
                        default: break;
                    }
                    // Settings
                }


            
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

        public static void createForm(User user)
        {
            MainScreenForm mainScreenForm = new MainScreenForm(user);
            mainScreenForm.Show();
        }

    }
}
