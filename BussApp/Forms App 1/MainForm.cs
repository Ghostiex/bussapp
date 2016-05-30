using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_App_1
{
    public partial class MainForm : Form
    {
        RegForm regForm = new RegForm();
        SokForm sokForm = new SokForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sokForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            regForm.Show();
        }
    }
}
