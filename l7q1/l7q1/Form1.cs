using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace l7q1
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            conn = new OracleConnection("DATA SOURCE=172.16.54.24:1521/ictorcl;USER ID=USER1;PASSWORD=student");
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception e1)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person per = new person();
            per.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car c = new car();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accident acc = new accident();
            acc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            owns o = new owns();
            o.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            participated part = new participated();
            part.Show();
        }
    }
}
