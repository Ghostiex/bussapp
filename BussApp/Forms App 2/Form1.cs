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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=85.24.245.191;port=3306;username=bussapp;password=123456");
        MySqlCommand command;

        DateTime nextFromDate;
        DateTime nextToDate;

        public Form1()
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

        public void ExecuteQuery(string bustrip)
        {
            try
            {
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
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nextFromDate = DateTime.Parse(fromDateBox.Text);
            nextToDate = DateTime.Parse(toDateBox.Text);

            OpenCon();

            for (int v = 1; v <= 52; v++)
            {
                string bustrip = "insert into bussapp.bustrip (totalspots, availableseats, departuretime, arrivaltime, destination, origin, price) values(" + seatsBox.Text + "," + seatsBox.Text + ",'" + nextFromDate + "','" + nextToDate + "'," + toBox.Text + "," + fromBox.Text + "," + priceBox.Text + ")";

                ExecuteQuery(bustrip);

                nextFromDate = nextFromDate.AddDays(7);
                nextToDate = nextToDate.AddDays(7);
            }

            CloseCon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
