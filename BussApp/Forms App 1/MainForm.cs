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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SokForm sokForm = new SokForm();
            sokForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
