using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSO_App_Dev_Project
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "")
            {
                SqlConnection conn = null;
                try
                {
                    var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                    var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                    conn = new SqlConnection(connString);

                    conn.Open();

                    String UserUsername = usernameTextBox.Text;
                    String UserPassword = passwordTextBox.Text;
                    String FirstName = firstNameTextBox.Text;
                    String LastName = lastNameTextBox.Text;

                    String updateDBQuery = $"INSERT INTO Users VALUES ('{UserUsername}', '{UserPassword}', '{FirstName}', '{LastName}', null)";

                    SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                    SqlDataReader reader1 = command1.ExecuteReader();

                    MessageBox.Show("User Creation Successful!", "Creating New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Hide();
            }
        }
    }
}
