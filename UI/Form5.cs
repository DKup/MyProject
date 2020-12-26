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
    public partial class Limits : Form
    {
        public Limits()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["USDoper"] = USDoper.Text;
            Settings.Default["USDclient"] = USDclient.Text;
            Settings.Default["EURoper"] = EURoper.Text;
            Settings.Default["EURclient"] = EURclient.Text;
            Settings.Default["RUBoper"] = RUBoper.Text;
            Settings.Default["RUBclient"] = RUBclient.Text;
            Settings.Default.Save();
        }

        private void Limits_Load(object sender, EventArgs e)
        {
            USDoper.Text = Settings.Default["USDoper"].ToString();
            USDclient.Text = Settings.Default["USDclient"].ToString();
            EURoper.Text = Settings.Default["EURoper"].ToString();
            EURclient.Text = Settings.Default["EURclient"].ToString();
            RUBoper.Text = Settings.Default["RUBoper"].ToString();
            RUBclient.Text = Settings.Default["RUBclient"].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
