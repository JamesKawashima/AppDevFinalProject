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
    public partial class MiceForm : Form
    {
        public char chgPage { get; set; }
        private User liu;
        public MiceForm(User liu)
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

        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void editMouseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
