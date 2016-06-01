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

namespace Forms_App_1
{
    public partial class SokForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=85.24.245.191;port=3306;database=bussapp;username=bussapp;password=123456");
        MySqlCommand command;

        MySqlDataReader reader;

        int lineCounter;
        int selectedTripID;

        int fromIndex;
        int toIndex;

        List<int> tripIDs = new List<int>();

        public SokForm()
        {
            InitializeComponent();

            lineCounter = 0;

            listBox1.Visible = false;

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

        public void ExecuteSearch(string query)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string departureTime = reader.GetString("departuretime");

                    listBox1.Items.Add(departureTime);

                    lineCounter++;

                    int tripID;

                    tripID = reader.GetInt32("tripID");

                    tripIDs.Add(tripID);
                }

                if (lineCounter > 8)
                {
                    listBox1.Height = 160;
                }
                else
                {
                    listBox1.Height = 20 * lineCounter;
                }

                if (lineCounter == 0)
                {
                    listBox1.Visible = false;

                    outputText.Text = "Vi har inga bussar som går från " + fromBox.Text + " till " + toBox.Text + ".";
                }
                else
                {
                    listBox1.Visible = true;
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

        // Sök resa
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();

            string query = "select departuretime, arrivaltime, tripID from bussapp.bustrip b " +
                "join city cOrigin on b.origin = cOrigin.cityID " +
                "join city cDestination on b.destination = cDestination.cityID " +
                "where cOrigin.cityID = " + fromIndex + " and cDestination.cityID = " + toIndex + ";";
            ExecuteSearch(query);
        }
        private void Reset()
        {
            listBox1.Items.Clear();

            lineCounter = 0;

            outputText.Text = "";
        }

        private void infobutton1_Click(object sender, EventArgs e)
        {
            SelectedTrip();

            InfoForm infoForm = new InfoForm(selectedTripID);
            infoForm.Show();
        }
        private void SelectedTrip()
        {
            selectedTripID = tripIDs[listBox1.SelectedIndex];
        }

        private void SokForm_Load(object sender, EventArgs e)
        {

        }

        private void tillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void fromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromIndex = fromBox.SelectedIndex + 1;
        }
        private void toBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toIndex = toBox.SelectedIndex + 1;
        }        
    }
}
