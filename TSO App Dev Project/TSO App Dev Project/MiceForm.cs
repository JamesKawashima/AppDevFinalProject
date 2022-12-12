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
    public partial class MiceForm : Form
    {
        public char chgPage { get; set; }
        private User liu;
        public MiceForm(User liu)
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

        private void miceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.miceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSODBDataSet);
        }

        private void MiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSODBDataSet.Mice' table. You can move, or remove it, as needed.
            this.miceTableAdapter.Fill(this.tSODBDataSet.Mice);
            this.miceDataGridView.Sort(this.miceDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void addMouseButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string groupID = createMouseGroupIDTextBox.Text.ToString();
                string dose1Vol = createMouseDose1TextBox.Text.ToString();
                string dose2Vol = createMouseDose2TextBox.Text.ToString();
                string height = createMouseHeightTextBox.Text.ToString();
                string length = createMouseLengthTextBox.Text.ToString();
                string width = createMouseWidthTextBox.Text.ToString();
                string weight = createMouseWeightTextBox.Text.ToString();

                string updateDBQuery = $"INSERT INTO Mice VALUES ('{groupID}', {height}, {length}, {width}, {weight}, {dose1Vol}, 0, {dose2Vol}, 0, null)";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Mouse Creation Successful!", "Creating New Mouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.miceTableAdapter.Fill(this.tSODBDataSet.Mice);
                this.miceDataGridView.Sort(this.miceDataGridView.Columns[0], ListSortDirection.Ascending);
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

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string groupID = addGroupIdTextBox.Text.ToString();

                string updateDBQuery = $"INSERT INTO MiceGroups VALUES ('{groupID}', null)";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Group Creation Successful!", "Creating New Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.miceTableAdapter.Fill(this.tSODBDataSet.Mice);
                this.miceDataGridView.Sort(this.miceDataGridView.Columns[0], ListSortDirection.Ascending);
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

        private void editMouseButton_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string mouseID = editMouseMouseIDTextBox.Text.ToString();
                string groupID = editMouseGroupIDTextBox.Text.ToString();
                string height = editMouseHeightTextBox.Text.ToString();
                string length = editMouseLengthTextBox.Text.ToString();
                string width = editMouseWidthTextBox.Text.ToString();
                string weight = editMouseWeightTextBox.Text.ToString();
                string dose1 = editMouseDose1TextBox.Text.ToString();
                string dose2 = editMouseDose1TextBox.Text.ToString();
                string comments = editMouseCommentsTextBox.Text.ToString();

                string dose1Completed;
                string dose2Completed;

                if (editMouseDose1CheckBox.Checked)
                    dose1Completed = "1";
                else
                    dose1Completed = "0";

                if (editMouseDose2CheckBox.Checked)
                    dose2Completed = "1";
                else
                    dose2Completed = "0";


                String updateDBQuery = $"UPDATE Mice SET groupId = '{groupID}', height_cm = {height}, length_cm = {length}, width_cm = {width}, weight_g = {weight}, dose1Volume_mL = {dose1}, dose1Completed = {dose1Completed}, dose2Volume_mL = {dose2}, dose2Completed = {dose2Completed}, comments = '{comments}' WHERE mouseId = {mouseID}";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("Mouse Edit Successful!", "Editing Mouse Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.miceTableAdapter.Fill(this.tSODBDataSet.Mice);
                this.miceDataGridView.Sort(this.miceDataGridView.Columns[0], ListSortDirection.Ascending);
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
