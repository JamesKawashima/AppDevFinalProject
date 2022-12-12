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
            this.liu = liu;
            InitializeComponent();
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

        private void studiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSODBDataSet);

        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSODBDataSet.Studies' table. You can move, or remove it, as needed.
            this.studiesTableAdapter.Fill(this.tSODBDataSet.Studies);
            SqlConnection conn = null;
            try
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TSODB.mdf");
                var connString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                conn = new SqlConnection(connString);

                conn.Open();

                String loggedInUserId = liu.Id.ToString();

                SqlCommand command1 = new SqlCommand($"SELECT * FROM Studies WHERE status = 'Ongoing'", conn);

                SqlDataReader reader1;

                reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    listBox1.Items.Add($"{reader1["leadUser"].ToString()}: Study {reader1["studyId"].ToString()} with Group {reader1["groupId"].ToString()} at {reader1["date"].ToString()}");
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studiesTableAdapter.FillBy1(this.tSODBDataSet.Studies);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studiesTableAdapter.Fill(this.tSODBDataSet.Studies);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studiesTableAdapter.FillBy2(this.tSODBDataSet.Studies);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
