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
    public partial class AccountForm : Form
    {
        public char chgPage { get; set; }
        private User liu;

        public AccountForm(User liu)
        {
            InitializeComponent();
            this.liu = liu;
        }

        private void homeFormLabel_Click(object sender, EventArgs e)
        {
            chgPage = 'm';
            Close();
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

        }

        private void settingsFormLabel_Click(object sender, EventArgs e)
        {
            SettingsForm s = new SettingsForm(liu);
            s.Show();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string loggedInUserId = liu.Id.ToString();

                SqlCommand command1 = new SqlCommand($"SELECT * FROM Users WHERE id = '{loggedInUserId}'", conn);

                SqlDataReader reader1;

                reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    accountFirstNameTextBox.Text = reader1["firstName"].ToString();
                    accountLastNameTextBox.Text = reader1["lastName"].ToString();
                    accountUsernameTextBox.Text = reader1["username"].ToString();
                    accountPasswordTextBox.Text = reader1["password"].ToString();
                    accountNotesTextBox.Text = reader1["privateNotes"].ToString();
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

        private void editButton_Click(object sender, EventArgs e)
        {
            accountFirstNameTextBox.ReadOnly = false;
            accountLastNameTextBox.ReadOnly = false;
            accountUsernameTextBox.ReadOnly = false;
            accountPasswordTextBox.ReadOnly = false;
            accountNotesTextBox.ReadOnly = false;
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                String loggedInUserId = liu.Id.ToString();
                String loggedInUserUsername = accountUsernameTextBox.Text;
                String loggedInUserPassword = accountPasswordTextBox.Text;
                String loggedInUserFirstName = accountFirstNameTextBox.Text;
                String loggedInUserLastName = accountLastNameTextBox.Text;
                String loggedInUserNotes = accountNotesTextBox.Text;

                String updateDBQuery = $"UPDATE Users SET username = '{loggedInUserUsername}', password = '{loggedInUserPassword}', firstName = '{loggedInUserFirstName}', lastName = '{loggedInUserLastName}', privateNotes = '{loggedInUserNotes}' WHERE id = {loggedInUserId}";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Save Successful!", "Saving Account Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            accountFirstNameTextBox.ReadOnly = true;
            accountLastNameTextBox.ReadOnly = true;
            accountUsernameTextBox.ReadOnly = true;
            accountPasswordTextBox.ReadOnly = true;
            accountNotesTextBox.ReadOnly = true;
            saveButton.Enabled = false;
        }
    }
}
