using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___Chapter_12_Programming_Exercises
{
    public class NegativeException : ApplicationException
    {
        public NegativeException(string str) : base(str)
        {

        }
    }

}

