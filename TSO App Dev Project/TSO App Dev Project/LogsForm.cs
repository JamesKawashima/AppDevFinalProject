using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }
    }
}
