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
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=bussapp;password=123456");
        MySqlCommand mcd;


        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        public void OpenCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }
        public void CloseCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }

        public void ExecuteQuery(string q)
        {
            try
            {
                OpenCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
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
