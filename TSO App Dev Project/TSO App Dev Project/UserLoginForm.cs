using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TSO_App_Dev_Project
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string usernameInputFromTextbox = usernameTextBox.Text;
                
                SqlCommand command1 = new SqlCommand($"SELECT * FROM Users WHERE username = '{usernameInputFromTextbox}'", conn);

                SqlDataReader reader1;

                reader1 = command1.ExecuteReader();

                if (reader1.Read())
                {
                    String usernameInput = reader1["username"].ToString();
                    String passwordInputFromTextbox = passwordTextBox.Text;
                    String passwordInput = reader1["password"].ToString();

                    if (usernameInput == usernameInputFromTextbox && passwordInput == passwordInputFromTextbox)
                    {
                        int id = int.Parse(reader1["id"].ToString());
                        string username = reader1["username"].ToString();
                        string firstName = reader1["firstName"].ToString();
                        string lastName = reader1["lastName"].ToString();
                        string privateNotes = reader1["privateNotes"].ToString();
                        User user = new User(id, username, firstName, lastName, privateNotes);
                        Program.LoggedInUser = user;
                        Program.closeLogInScreen();
                        MainScreenForm msf = new MainScreenForm(user);
                        msf.Show();
                    }
                    else 
                    {
                        MessageBox.Show($"InCorrect Password! {usernameInput} = {usernameInputFromTextbox} : {passwordInput} = {passwordInputFromTextbox}");
                    }
                }
                else
                {
                    MessageBox.Show($"InCorrect Username! {usernameInputFromTextbox}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
