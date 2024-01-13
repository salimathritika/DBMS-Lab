using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_q2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "User";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Rs. 50,000";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1/1/2024";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text= "Rs.1000, Rs.100, Rs.2314, Rs.200, rs.378";
        }
    }
}
