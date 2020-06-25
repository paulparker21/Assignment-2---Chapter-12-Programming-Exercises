using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___Chapter_12_Programming_Exercises
{
    class bankAccount
    {
        public double balance;

        public bankAccount()
        {
            balance = 9999;
        }

        public void withdraw(double amount)
        {
            balance = balance - amount;
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
        }

        public double display()
        {
            return balance;
        }
    }
}




    



