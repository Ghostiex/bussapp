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
    public partial class InfoForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=85.24.245.191;port=3306;database=bussapp;username=bussapp;password=123456");
        MySqlCommand command;

        int tripID;

        public InfoForm(int tripID)
        {
            InitializeComponent();

            this.tripID = tripID;

            LoadBusTrip();

            emailBox.Text = "Skriv din email här";
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

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

        private void LoadBusTrip()
        {
            string query = "select c1.name name1, c2.name name2, b.departuretime, b.arrivaltime, b.availableseats, b.price, c2.country, c2.language, c2.currency from bustrip b " +
                "join city c1 on (b.origin = c1.cityID) " +
                "join city c2 on (b.destination = c2.cityID)" +
                "where b.tripID = " + tripID;

            ExecuteLoadInfo(query);
        }
        public void ExecuteLoadInfo(string query)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    originLabel.Text = reader.GetString("name1");
                    destinationLabel.Text = reader.GetString("name2");
                    originDateLabel.Text = reader.GetString("departuretime");
                    destinationDateLabel.Text = reader.GetString("arrivaltime");
                    availableLabel.Text = reader.GetString("availableseats");
                    priceLabel.Text = reader.GetString("price");
                    countryLabel.Text = reader.GetString("country");
                    languageLabel.Text = reader.GetString("language");
                    currencyLabel.Text = reader.GetString("currency");
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

        private void bokaBtn_Click(object sender, EventArgs e)
        {
            GetEmailCustomerID();
        }

        private void CreateTicket(int customerID)
        {
            string ticket = "insert into ticket (type, ticketCustomerID) values ('Enkel', " + customerID + ");";

            ExecuteCreateTicket(ticket);

            string seat = "update bustrip set availableseats = availableseats - 1 where tripID = " + tripID + ";";

            ExecuteFillSeat(seat);

            GetTicketID();
        }
        private void ExecuteCreateTicket(string ticket)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(ticket, connection);
                
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Tack för bokad resa, din biljett kommer att skickas till " + emailBox.Text);
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
        private void ExecuteFillSeat(string seat)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(seat, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Seats Updated");
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

        private void GetTicketID()
        {
            string ticketID = "select max(ticketID) from ticket;";

            ExecuteTicketID(ticketID);
        }
        private void ExecuteTicketID(string ticketID)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(ticketID, connection);

                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                int gotTicketID = reader.GetInt32("max(ticketID)");

                reader.Close();

                ValidateTicketID(gotTicketID);
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
        private void ValidateTicketID(int gotTicketID)
        {
            string validity = "insert into validity (ticketID, tripID) values (" + gotTicketID + ", " + tripID + ");";

            ExecuteValidity(validity);
        }
        private void ExecuteValidity(string validity)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(validity, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Ticket validated");
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

        private void GetEmailCustomerID()
        {
            string checkEmail = "select customerID from customer where email = '" + emailBox.Text + "';";

            ExecuteCheckEmail(checkEmail);
        }
        private void ExecuteCheckEmail(string checkEmail)
        {
            try
            {
                OpenCon();

                command = new MySqlCommand(checkEmail, connection);

                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                if (reader.HasRows)
                {
                    int customerID = reader.GetInt32("customerID");

                    reader.Close();

                    CreateTicket(customerID);
                }
                else
                {
                    MessageBox.Show("Det finns ingen registrerad medlem med email: " + emailBox.Text);
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
            this.Close();
        }
        private void destinationText_Click(object sender, EventArgs e)
        {

        }
    }
}
