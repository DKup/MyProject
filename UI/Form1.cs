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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrencyExchange сurrencyExchange = new CurrencyExchange();
            сurrencyExchange.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((bool)Settings.Default["isLogged"])
            {
                showHistory.Visible = true;
                setRateOfExchange.Visible = true;
                setLimits.Visible = true;
              
            }
                
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityHistory activityHistory = new ActivityHistory();
            activityHistory.Show();
        }

        private void setLimits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limits limits = new Limits();
            limits.Show();
        }

        private void setRateOfExchange_Click(object sender, EventArgs e)
        {
            this.Hide();
            RateOfExchange rateOfExchange = new RateOfExchange();
            rateOfExchange.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateField_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterAdmin_Click(object sender, EventArgs e)
        {
            
                showHistory.Visible = true;
                setRateOfExchange.Visible = true;
                setLimits.Visible = true;
                Settings.Default["isLogged"] = true;
                Settings.Default.Save();
            
        }

        private void exitAdmin_Click(object sender, EventArgs e)
        {
            showHistory.Visible = false;
            setRateOfExchange.Visible = false;
            setLimits.Visible = false;
            Settings.Default["isLogged"] = false;
            Settings.Default.Save();
            
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
