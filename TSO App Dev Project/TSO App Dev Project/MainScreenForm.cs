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
    public partial class MainScreenForm : Form
    {
        public char chgPage { get; set; }
        private User liu;

        public MainScreenForm(User liu)
        {
            InitializeComponent();
            this.liu = liu;
        }

        private void homeFormLabel_Click(object sender, EventArgs e)
        {
            //if not already on the mainscreenform, bring to the home
        }

        private void studiesFormLabel_Click(object sender, EventArgs e)
        {
            chgPage = 's';
            Close();
        }

        private void miceFormLabel_Click(object sender, EventArgs e)
        {
            chgPage = 'r';
            Close();
        }

        private void logsFormLabel_Click(object sender, EventArgs e)
        {
            chgPage = 'l';
            Close();
        }

        private void accountFormLabel_Click(object sender, EventArgs e)
        {
            chgPage = 't';
            Close();
        }

        private void settingsFormLabel_Click(object sender, EventArgs e)
        {
            SettingsForm s = new SettingsForm(liu);
            s.Show();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                // Filling in first list box for current studies info
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                SqlCommand command1 = new SqlCommand($"SELECT * FROM Studies WHERE status = 'Ongoing'", conn);

                SqlDataReader reader1;

                reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    currentStudiesListBox.Items.Add($"{reader1["leadUser"].ToString()}: Study {reader1["studyId"].ToString()} with Group {reader1["groupId"].ToString()} at {reader1["date"].ToString()}");
                }

                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filling in second list box for User info
                database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                SqlCommand command2 = new SqlCommand($"SELECT * FROM Users", conn);

                SqlDataReader reader2;

                reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    string userInfo = $"{reader2["id"]} : {reader2["firstName"]} {reader2["lastName"]}";
                    allUsersListBox.Items.Add(userInfo);
                }
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
        }
    }
}
