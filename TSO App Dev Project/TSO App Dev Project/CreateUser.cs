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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                SqlConnection conn = null;
                try
                {
                    var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                    var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                    conn = new SqlConnection(connString);

                    conn.Open();

                    String UserUsername = textBox2.Text;
                    String UserPassword = textBox3.Text;
                    String FirstName = textBox4.Text;
                    String LastName = textBox5.Text;

                    String updateDBQuery = $"INSERT INTO Users VALUES ('{UserUsername}', '{UserPassword}', '{FirstName}', '{LastName}', null)";

                    SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                    SqlDataReader reader1 = command1.ExecuteReader();

                    MessageBox.Show("insert Successful! :D");
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
                Hide();

            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
