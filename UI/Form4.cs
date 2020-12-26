using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class RateOfExchange : Form
    {
        public RateOfExchange()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RateOfExchange_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default["USDBuy"].ToString();
            textBox3.Text = Settings.Default["USDSell"].ToString();
            textBox2.Text = Settings.Default["EURBuy"].ToString();
            textBox4.Text = Settings.Default["EURSell"].ToString();
            textBox5.Text = Settings.Default["RUBBuy"].ToString();
            textBox6.Text = Settings.Default["RUBSell"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["USDBuy"] = textBox1.Text;
            Settings.Default["USDSell"] = textBox3.Text;
            Settings.Default["EURBuy"] = textBox2.Text;
            Settings.Default["EURSell"] = textBox4.Text;
            Settings.Default["RUBBuy"] = textBox5.Text;
            Settings.Default["RUBSell"] = textBox6.Text;
            Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
