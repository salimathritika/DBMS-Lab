﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace trial_connection
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ConnectDB()
        {
            conn = new OracleConnection("DATA SOURCE=172.16.54.24:1521/ictorcl;USER ID=CCE428;PASSWORD=student");
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
            // to fetch data from student;
            ConnectDB();

            OracleCommand command1 = conn.CreateCommand();

            command1.CommandText = "select name,id,address from trial";

            command1.CommandType = CommandType.Text;
            OracleDataReader dr = command1.ExecuteReader();
            dr.Read();
            textBox1.Text = dr.GetString(0);
            textBox2.Text = dr.GetString(1);
            textBox3.Text = dr.GetString(2);
            command1.Dispose();


            conn.Close();           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();

            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "insert into trial values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            command1.CommandType = CommandType.Text;
            command1.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            command1.Dispose();
            conn.Close();

        }

    }
}
