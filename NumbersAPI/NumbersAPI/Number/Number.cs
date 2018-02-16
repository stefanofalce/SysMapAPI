using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersAPI.Number
{
    public class Number : INumber
    {

        //Implementação da interface

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public float Divide(int a, int b)
        {
            return (float)a / b;
        }
    }
}
