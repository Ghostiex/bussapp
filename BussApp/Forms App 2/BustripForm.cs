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
    public partial class BustripForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=85.24.245.191;port=3306;database=bussapp;username=bussapp;password=123456");
        MySqlCommand command;

        DateTime nextFromDate;
        DateTime nextToDate;

        int fromIndex;
        int toIndex;

        public BustripForm()
        {
            InitializeComponent();

            LoadCities();
        }

        private void LoadCities()
        {
            string cities = "select * from city;";

            ExecuteLoadCities(cities);
        }
        public void ExecuteLoadCities(string cities)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(cities, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fromBox.Items.Add(reader.GetString("name"));
                    toBox.Items.Add(reader.GetString("name"));
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

        public void ExecuteQuery(string bustrip)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(bustrip, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Lagt till ny bussresa!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            nextFromDate = DateTime.Parse(fromDateBox.Text);
            nextToDate = DateTime.Parse(toDateBox.Text);

            for (int v = 1; v <= 52; v++)
            {
                string bustrip = "insert into bussapp.bustrip (totalspots, availableseats, departuretime, arrivaltime, destination, origin, price) values(" + seatsBox.Text + "," + seatsBox.Text + ",'" + nextFromDate + "','" + nextToDate + "'," + toIndex + "," + fromIndex + "," + priceBox.Text + ")";

                ExecuteQuery(bustrip);

                nextFromDate = nextFromDate.AddDays(7);
                nextToDate = nextToDate.AddDays(7);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromIndex = fromBox.SelectedIndex + 1;
        }
        private void toBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toIndex = toBox.SelectedIndex + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
