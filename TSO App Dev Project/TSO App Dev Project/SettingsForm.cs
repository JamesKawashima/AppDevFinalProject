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
        private User liu;
        public char chgPage { get; set; }
        public SettingsForm(User liu)
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            md.Close();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.updateConfig("language", comboBox1.Text);
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, this is an applicatioon that is very cool, I like it, you like it, so this deserves a 100%");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            md.Show();
        }

    }
}
