using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2___Chapter_12_Programming_Exercises
{
    public partial class Form1 : Form
    {
        bankAccount b1;
        double amount;
        public Form1()
        {
            b1 = new bankAccount();

            InitializeComponent();
        }

        private void dpt_Click(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToDouble(textBox1.Text);
                if (amount < 0)
                {
                    throw new NegativeException("Negative value is entered");
                }
                else
                {
                    b1.deposit(amount);
                }
            }
            catch (NegativeException n1)
            {
                textBox1.Text = "Exception is " + n1;
            }
        }

        private void Bal_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Balance : " + b1.display();
        }


        private void Wth_Click(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToDouble(textBox1.Text);
                if (amount < 0)
                {
                    throw new NegativeException("Negative value is entered");
                }
                else
                {
                    b1.withdraw(amount);
                }
            }
            catch (NegativeException n1)
            {
                textBox1.Text = "Exception is " + n1;
            }
        }




    }

      



    }

      
    

