using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using UI.Properties;
using System.IO;

namespace UI
{
    public partial class CurrencyExchange : Form
    {
        string currency = "USD";
        string type = "Покупка";
        SqlConnection sqlConnection;
        
        DateTime date = DateTime.Today; 
        public CurrencyExchange()
        {
            InitializeComponent();
        }

        private bool CheckDayLimit(string operUserID, DateTime operDate, string operCurrency, double operAmountOfCurrency, string operType)
        {
            double sumOfOperations = operAmountOfCurrency;
            bool flag = false;
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Table]", sqlConnection);
            
                sqlReader =  command.ExecuteReader();
            while (sqlReader.Read())
            {
                if (((string)sqlReader["ClientID"]).Equals(operUserID) && ((DateTime)sqlReader["Date"]).Equals(operDate) &&
                ((string)sqlReader["Currency"]).Equals(operCurrency))//поиск операции, подходящей по айди, дате и валюте
                {
                    if (((string)sqlReader["Type"]).Equals("Покупка"))//если тип операции - покупка
                    {
                        sumOfOperations += Convert.ToDouble(sqlReader["Got"]);
                    }
                    else if (((string)sqlReader["Type"]).Equals("Продажа"))//если тип операции - продажа
                    {
                        sumOfOperations += Convert.ToDouble(sqlReader["Given"]);
                    }
                }
                if (sumOfOperations > Convert.ToDouble((string)Settings.Default[operCurrency + "client"]))
                    {
                        flag = true;
                        //sumLabel.Text = sumOfOperations.ToString();
                        break;
                    }
            }
            
                if (sqlReader != null)
                    sqlReader.Close();
           
            return flag;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double amountOfCurrency;
            if (type.Equals("Продажа"))
            {
                amountOfCurrency = Convert.ToDouble(givenValue.Text);
            }
            else
            {
                amountOfCurrency = Convert.ToDouble(gotValue.Text);
            }
            if (label6.Visible) label6.Visible = false;
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrWhiteSpace(clientName.Text) ||
                string.IsNullOrEmpty(givenValue.Text) || string.IsNullOrWhiteSpace(givenValue.Text)
               )
            {
                label6.Visible = true;
                label6.Text = "Проверьте, чтобы поля не были пустыми!";
            }
            else if (amountOfCurrency > Convert.ToDouble((string)Settings.Default[currency + "oper"]))//проверка на соответствие лимиту на операцию
            {
                label6.Visible = true;
                label6.Text = "Проверьте, чтобы значения валюты соответствовали лимитам на операцию!";
            }
            else if (CheckDayLimit(userID.Text, date, currency, amountOfCurrency, type))//проверка на соответствие дневному лимиту
            {
                label6.Visible = true;
                label6.Text = "Вероятно, вы превышаете лимит на день!";
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO [TABLE] (Date, Client, ClientID, Cashier, Type, Currency, Given, Got)VALUES(@Date, @Client, @ClientID, @Cashier, @Type, @Currency, @Given, @Got)", sqlConnection);
                command.Parameters.AddWithValue("Date", date);
                command.Parameters.AddWithValue("Client", clientName.Text);
                command.Parameters.AddWithValue("ClientID", userID.Text);
                command.Parameters.AddWithValue("Cashier", cashierName.Text);
                command.Parameters.AddWithValue("Type", type);
                command.Parameters.AddWithValue("Currency", currency);
                command.Parameters.AddWithValue("Given", givenValue.Text);
                command.Parameters.AddWithValue("Got", gotValue.Text);
                
                
                await command.ExecuteNonQueryAsync();

                StreamWriter sw = new StreamWriter("Transaction.txt");
                sw.WriteLine(date.ToShortDateString());
                sw.WriteLine(clientName.Text);
                sw.WriteLine(userID.Text);
                sw.WriteLine(cashierName.Text);
                sw.WriteLine(type);
                sw.WriteLine(currency);
                sw.WriteLine("Отдано " + givenValue.Text);
                sw.WriteLine("Получено " + gotValue.Text);
                sw.Close();
                label6.Visible = true;
                label6.Text = "Операция прошла успешно!";
            }
        }

        private async void CurrencyExchange_Load(object sender, EventArgs e)
        {
            limOpUSDValue.Text = Settings.Default["USDoper"].ToString();
            limClUSDValue.Text = Settings.Default["USDclient"].ToString();
            limOpEURValue.Text = Settings.Default["EURoper"].ToString();
            limClEURValue.Text = Settings.Default["EURclient"].ToString();
            limOpRUBValue.Text = Settings.Default["RUBoper"].ToString();
            limClRUBValue.Text = Settings.Default["RUBclient"].ToString();

            if ((bool)Settings.Default["isLogged"])
            {
                nextDayButton.Visible = true;
            }
                try
            {
                dateBox.Items.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dima\source\repos\Currency_Exchange-main\UI\bin\Debug\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                await sqlConnection.OpenAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//перейти на след. день
        {

            date = date.AddDays(1);
            dateBox.Items.Clear();
            try
            {
                dateBox.Items.Add(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void givenValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (currency)
                {
                    case "USD":
                        if (toBuyRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(givenValue.Text) / Convert.ToDouble(Settings.Default["USDBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(Settings.Default["USDSell"].ToString()) * Convert.ToDouble(givenValue.Text)).ToString();
                        }
                        break;
                    case "EUR":
                        if (toBuyRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(givenValue.Text) / Convert.ToDouble(Settings.Default["EURBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(Settings.Default["EURSell"].ToString()) * Convert.ToDouble(givenValue.Text)).ToString();
                        }
                        break;
                    case "RUB":
                        if (toBuyRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(givenValue.Text) / Convert.ToDouble(Settings.Default["RUBBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            gotValue.Text = (Convert.ToDouble(Settings.Default["RUBSell"].ToString()) * Convert.ToDouble(givenValue.Text)).ToString();
                        }
                        break;
                }
            }
            catch
            {

            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (currency)
                {
                    case "USD":
                        if (toBuyRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) * Convert.ToDouble(Settings.Default["USDBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) / Convert.ToDouble(Settings.Default["USDSell"].ToString())).ToString();
                        }
                        break;
                    case "EUR":
                        if (toBuyRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) * Convert.ToDouble(Settings.Default["EURBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) / Convert.ToDouble(Settings.Default["EURSell"].ToString())).ToString();
                        }
                        break;
                    case "RUB":
                        if (toBuyRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) * Convert.ToDouble(Settings.Default["RUBBuy"].ToString())).ToString();
                        }
                        if (toSellRB.Checked)
                        {
                            givenValue.Text = (Convert.ToDouble(gotValue.Text) / Convert.ToDouble(Settings.Default["RUBSell"].ToString())).ToString();
                        }
                        break;
                }
            }
            catch 
            {
            
            }

        }

        private void usdRB_CheckedChanged(object sender, EventArgs e)
        {
            givenValue.Text = "";
            gotValue.Text = "";
            currency = "USD";
        }

        private void eurRB_CheckedChanged(object sender, EventArgs e)
        {
            givenValue.Text = "";
            gotValue.Text = "";
            currency = "EUR";
        }

        private void rubRB_CheckedChanged(object sender, EventArgs e)
        {
            givenValue.Text = "";
            gotValue.Text = "";
            currency = "RUB";
        }

        private void toBuyRB_CheckedChanged(object sender, EventArgs e)//зануляем поля валют, если выбран новый тип обмена
        {
            givenValue.Text = "";
            gotValue.Text = "";
            type = "Покупка";
        }

        private void toSellRB_CheckedChanged(object sender, EventArgs e)//зануляем поля валют, если выбран новый тип обмена
        {
            givenValue.Text = "";
            gotValue.Text = "";
            type = "Продажа";
        }
    }
}
