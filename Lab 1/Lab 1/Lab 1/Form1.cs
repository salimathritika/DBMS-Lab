﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        string input = string.Empty; //to read the input when clicked 
        string Op1 = string.Empty; //First operand
        string Op2 = string.Empty; //Second operand 
        char Operator; //Operator
        double res = 0.0; //Final result
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Op2 = input;
            double num1, num2; 
            double.TryParse(Op1, out num1); 
            //if(Operator != '#' || Operator != 's' || Operator != 'c')  
             //  double.TryParse(Op2, out num2); 
            if (Operator == '+')
            {
                double.TryParse(Op2, out num2); 
                res = num1 + num2; 
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '-')
            {
                double.TryParse(Op2, out num2); 
                res = num1 - num2; 
                textBox1.Text = res.ToString();
            }
            else if (Operator == '*')
            {
                double.TryParse(Op2, out num2); 
                res = num1 * num2; 
                textBox1.Text = res.ToString();
            }
            else if (Operator == '/')
            {
                double.TryParse(Op2, out num2); 
                if (num2 != 0)
                {
                    res = num1 / num2; textBox1.Text = res.ToString();
                }
               else
               {
                    textBox1.Text = "DIV/Zero!";
               }
            }
            
           else if (Operator == '#')
            {
                res = Math.Sqrt(num1); 
                textBox1.Text = res.ToString();
            }
            else if (Operator == '^')
            {
                double.TryParse(Op2, out num2);
                res = Math.Pow(num1,num2);
                textBox1.Text = res.ToString();
            }
            else if (Operator == 's')
            {
                res = Math.Sin(num1);
                textBox1.Text = res.ToString();
            }
            else if (Operator == 'c')
            {
                res = Math.Cos(num1);
                textBox1.Text = res.ToString();
            }
            else if (Operator == 't')
            {
                res = Math.Tan(num1);
                textBox1.Text = res.ToString();
            }
            else if (Operator == 'l')
            {
                res = Math.Log(num1);
                textBox1.Text = res.ToString();
            }

            input = string.Empty;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty; 
            input = input + "2"; 
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty; 
            input = input + "1"; 
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Op1 = input; 
            Operator = '+';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '#';
            input=string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '^';
            input = string.Empty;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 's';
            input = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'c';
            input = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 't';
            input = string.Empty;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'l';
            input = string.Empty;
        }
    }
}
