using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Forms_App_1
{
    public partial class RegForm : Form
    {
        MainForm mainForm = new MainForm();

        MySqlConnection connection = new MySqlConnection("datasource=85.24.245.191;port=3306;username=bussapp;password=123456");
        MySqlCommand command;

        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
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

        public void ExecuteQuery(string q)
        {
            try
            {
                OpenCon();
                command = new MySqlCommand(q, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Welcome to Svenssons DeluxeBusTrips, " + firstnameBox.Text + "!");
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
            string q = "insert into bussapp.customer (firstname, lastname, personID, adress, email, phonenumber) values('" + firstnameBox.Text + "','" + lastnameBox.Text + "','" + personnrBox.Text + "','" + addressBox.Text + "','" + emailBox.Text + "','" + telefonnrBox.Text + "')";
            ExecuteQuery(q);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
