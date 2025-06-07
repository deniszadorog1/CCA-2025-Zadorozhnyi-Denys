using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lib
{
    public class Calculator
    {
        public int Addition(int a, int b) => a + b;

        public int Minus(int a, int b) => a - b;

        public int Multiplication(int a, int b) => a * b;

        public double Division(int a, int b) => a / b;

        public string ConcatAction(string a, string b)
        {
            return string.Concat(a, b);
        }


    }
}
