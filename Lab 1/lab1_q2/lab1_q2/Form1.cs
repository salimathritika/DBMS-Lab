using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_q2
{
    public partial class Form1 : Form
    {
        string name=string.Empty;
        string edu=string.Empty;
        string gen=string.Empty;
        string lang=string.Empty;
        string dob = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Name:" + name + "\nGender:" + gen + "\nLanguages:" + lang + "\nEducation qualification:" + edu);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name= this.textBox1.Text; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true)
                gen = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
                gen = "Female";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //dob = monthCalendar1.ToString();
            dob = monthCalendar1.SelectionRange.Start.Date.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:" + name + "\nGender:" + gen + "\nLanguages:" + lang + "\nEducation qualification:" + edu+"\nDate Of Birth:"+dob);
            lang = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            edu = comboBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true)
                lang += " English";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
                lang += " French";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Enabled == true)
                lang += " German";
        }
    }
}
