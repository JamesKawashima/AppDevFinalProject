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
    public partial class LogsForm : Form
    {
        public char chgPage { get; set; }
        private User liu;
        public LogsForm(User liu)
        {
            InitializeComponent();
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

        private void tumorLogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tumorLogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSODBDataSet);

        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSODBDataSet.TumorLogs' table. You can move, or remove it, as needed.
            this.tumorLogsTableAdapter.Fill(this.tSODBDataSet.TumorLogs);
            this.tumorLogsDataGridView.Sort(this.tumorLogsDataGridView.Columns[0], ListSortDirection.Descending);
        }

        private void createLogButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                string mouseID = createLogMouseIDTextBox.Text.ToString();
                string height = createLogHeightTextBox.Text.ToString();
                string length = createLogLengthTextBox.Text.ToString();
                string width = createLogWidthTextBox.Text.ToString();
                string comments = createLogCommentsTextBox.Text.ToString();
                string mouseEuthanized = "";

                if (createLogEuthanizedCheckBox.Checked)
                    mouseEuthanized = "Yes";
                else
                    mouseEuthanized = "No";

                decimal heightNum = Decimal.Parse(createLogHeightTextBox.Text.ToString());
                decimal lengthNum = Decimal.Parse(createLogLengthTextBox.Text.ToString());
                decimal widthNum = Decimal.Parse(createLogWidthTextBox.Text.ToString());
                decimal volumeNum = heightNum * lengthNum * widthNum;

                string volume = volumeNum.ToString();

                string updateDBQuery = $"INSERT INTO TumorLogs VALUES (sysdatetime(), sysdatetime(), {mouseID}, {height}, {length}, {width}, {volume}, 'No', '{mouseEuthanized}', '{comments}')";

                SqlCommand command1 = new SqlCommand(updateDBQuery, conn);

                SqlDataReader reader1 = command1.ExecuteReader();

                MessageBox.Show("insert Successful! :D");
                this.tumorLogsTableAdapter.Fill(this.tSODBDataSet.TumorLogs);
                this.tumorLogsDataGridView.Sort(this.tumorLogsDataGridView.Columns[0], ListSortDirection.Descending);
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
