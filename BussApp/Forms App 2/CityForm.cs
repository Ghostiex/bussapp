using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Forms_App_2
{
    public partial class CityForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=85.24.245.191;port=3306;database=bussapp;username=bussapp;password=123456");
        MySqlCommand command;

        public CityForm()
        {
            InitializeComponent();
        }

        public void OpenCon()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseCon()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void CityForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addCity = "insert into bussapp.city (name, language, currency, country, timezone) values ('" + 
                cityBox.Text + "', '" + languageBox.Text + "', '" + currencyBox.Text + "', '" + countryBox.Text +
                "', '" + timezoneBox.Text + "')";

            ExecuteAddCity(addCity);
        }

        private void ExecuteAddCity(string addCity)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(addCity, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Lagt till ny stad!");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
