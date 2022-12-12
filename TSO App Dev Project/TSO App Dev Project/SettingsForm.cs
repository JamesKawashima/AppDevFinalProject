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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.updateConfig("language", comboBox1.Text);
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, This project was made by James and Amanda and developped with the help of caffeine and a deadline.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            md = new MouseDance();
            md.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cu = new CreateUser();
            cu.Show();
        }
    }
}
