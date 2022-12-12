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
    public partial class SettingsForm : Form
    {
        MouseDance md = new MouseDance();
        CreateUser cu = new CreateUser();
        private User liu;
        public char chgPage { get; set; }
        public SettingsForm(User liu)
        {
            InitializeComponent();
            this.liu = liu;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.updateConfig("language", languageComboBox.Text);
            Application.Restart();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            cu = new CreateUser();
            cu.Show();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! TSO was developed by James Kawashima and Amanda De Rosa.", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mouseDanceButton_Click(object sender, EventArgs e)
        {
            md = new MouseDance();
            md.Show();
        }
    }
}
