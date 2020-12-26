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


namespace UI
{
    public partial class ActivityHistory : Form
    {
        SqlConnection sqlConnection;
        public ActivityHistory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private async void ActivityHistory_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dima\source\repos\Currency_Exchange-main\UI\bin\Debug\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Table]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(
                        Convert.ToString(sqlReader["Date"]) + "        " +
                        Convert.ToString(sqlReader["Client"]) + "        " +
                        Convert.ToString(sqlReader["ClientID"]) + "        " +
                        Convert.ToString(sqlReader["Cashier"]) + "        " +
                        Convert.ToString(sqlReader["Type"]) + "        " +
                        Convert.ToString(sqlReader["Currency"]) + "        " +
                        Convert.ToString(sqlReader["Given"]) + "        " +
                        Convert.ToString(sqlReader["Got"])
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Table]", sqlConnection);
            var periodFrom = DateTime.Parse(textBox1.Text);//введённая дата для периода истории операций
            var periodTo = DateTime.Parse(textBox2.Text);//введённая дата для периода истории операций
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    var periodNow = DateTime.Parse(Convert.ToString(sqlReader["Date"]));//дата текущей операции
                    if (periodNow >= periodFrom && periodNow <= periodTo)//выбираем данные соответствующие периоду
                    {
                        listBox1.Items.Add(                            
                            Convert.ToString(sqlReader["Date"]) + "        " +
                            Convert.ToString(sqlReader["Client"]) + "        " +
                            Convert.ToString(sqlReader["ClientID"]) + "        " +
                            Convert.ToString(sqlReader["Cashier"]) + "        " +
                            Convert.ToString(sqlReader["Type"]) + "        " +
                            Convert.ToString(sqlReader["Currency"]) + "        " +
                            Convert.ToString(sqlReader["Given"]) + "        " +
                            Convert.ToString(sqlReader["Got"])
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
