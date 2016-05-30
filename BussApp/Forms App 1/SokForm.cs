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
    public partial class SokForm : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=85.24.245.191;port=3306;username=bussapp;password=123456");
        MySqlCommand mcd;


        public SokForm()
        {
            InitializeComponent();
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

                SearchResults(mcd);

                //if (mcd.ExecuteNonQuery() == 1)
                //{
                //    //MessageBox.Show("Query Executed");
                //    SearchResults(mcd);
                //}
                //else
                //{
                //    MessageBox.Show("Query Not Executed");
                //}
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
            string q = "select departuretime, arrivaltime from bussapp.bustrip b " +
                "join city cOrigin on b.origin = cOrigin.cityID " +
                "join city cDestination on b.destination = cDestination.cityID " +
                "where cOrigin.name = " + fromBox.Text + " and cDestination = " + toBox.Text + ";";
            ExecuteQuery(q);
        }

        private void Translator()
        {

        }

        private void SearchResults(MySqlCommand mcd)
        {
            string output = mcd.CommandText;

            MessageBox.Show(output);
        }


        private void infobutton1_Click(object sender, EventArgs e)
        {

        }





        private void SokForm_Load(object sender, EventArgs e)
        {

        }        
    }
}
