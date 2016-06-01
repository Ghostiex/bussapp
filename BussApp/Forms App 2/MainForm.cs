using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_App_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CityForm cityForm = new CityForm();
            cityForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BustripForm bustripForm = new BustripForm();
            bustripForm.Show();
        }

    }
}
