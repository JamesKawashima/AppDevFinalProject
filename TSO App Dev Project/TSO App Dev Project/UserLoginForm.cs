using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            try 
            {
                //tSODBDataSet.Users.

                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE firstName = 'Amanda'");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        usernameTextBox.Text = reader["firstName"].ToString();
                    }
                }

            } catch (Exception ex)
            { 
                usernameTextBox.Text = ex.Message;
            }
        }
    }
}
