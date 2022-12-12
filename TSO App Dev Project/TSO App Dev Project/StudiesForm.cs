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
    public partial class StudiesForm : Form
    {
        public char chgPage { get; set; }
        private User liu;
        public StudiesForm(User liu)
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

        private void studiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSODBDataSet);

        }

        private void StudiesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSODBDataSet.Studies' table. You can move, or remove it, as needed.
            this.studiesTableAdapter.Fill(this.tSODBDataSet.Studies);
            this.studiesDataGridView.Sort(this.studiesDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void addStudyButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string leadUserID = createStudyUserIDTextBox.Text.ToString();
                string groupID = createStudyGroupIDTextBox.Text.ToString();
                string doseName = createStudyDoseNameTextBox.Text.ToString();
                string doseVolume = createStudyDoseVolumeTextBox.Text.ToString();

                string updateDBQuery = $"INSERT INTO Studies VALUES ('{leadUserID}', '{groupID}', '{doseName}', {doseVolume}, sysdatetime(), 'Pending', null)";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Study Creation Successful!", "Creating New Study", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.studiesTableAdapter.Fill(this.tSODBDataSet.Studies);
                this.studiesDataGridView.Sort(this.studiesDataGridView.Columns[0], ListSortDirection.Ascending);
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

        private void editStudyButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string studyID = editStudyStudyIDTextBox.Text.ToString();
                string leadUserID = editStudyUserIdTextBox.Text.ToString();
                string groupID = editStudyGroupIdTextBox.Text.ToString();
                string doseName = editStudyDoseNameTextBox.Text.ToString();
                string doseVolume = editStudyDoseVolTextBox.Text.ToString();
                string comments = editStudyCommentsTextBox.Text.ToString();
                string status = "";

                if (editStudyStatusComboBox.SelectedIndex == 0)
                    status = "Pending";
                else if (editStudyStatusComboBox.SelectedIndex == 1)
                    status = "Ongoing";
                else if (editStudyStatusComboBox.SelectedIndex == 2)
                    status = "Previous";

                string updateDBQuery = $"UPDATE Studies SET leadUser = {leadUserID}, groupId = '{groupID}', doseName = '{doseName}', dose_mL_Per_g = {doseVolume}, status = '{status}', comments = '{comments}' WHERE studyId = {studyID}";
                
                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Study Edit Successful!", "Editing Study Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.studiesTableAdapter.Fill(this.tSODBDataSet.Studies);
                this.studiesDataGridView.Sort(this.studiesDataGridView.Columns[0], ListSortDirection.Ascending);
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

        private void assignMyselfToStudyButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string userID = liu.Id.ToString();
                string studyId = assignMyselfToStudyStudyIDTextBox.Text.ToString();

                string updateDBQuery = $"UPDATE Studies SET leadUser = '{userID}' WHERE studyId = {studyId}";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);
                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Self-Assignment Successful!", $"Assigning {liu.Id} : {liu.FirstName} {liu.LastName} to Study", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.studiesTableAdapter.Fill(this.tSODBDataSet.Studies);
                this.studiesDataGridView.Sort(this.studiesDataGridView.Columns[0], ListSortDirection.Ascending);
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
