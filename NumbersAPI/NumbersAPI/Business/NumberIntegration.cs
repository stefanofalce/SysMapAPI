using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumbersAPI.Number;
using NumbersAPI.Models;

namespace NumbersAPI.Business
{
    public class NumberIntegration
    {
        INumber iNum;
        public Numbers Num;

        //Classe de integração ao recurso Number para garantir o encapsulamento e a modularização através da interface do recurso.

        public int Sum()
        {
            if (Num.NumbersArr.Length < 1)
            {
                return 0;
            }
            else
            {
                int sum = Num.NumbersArr[0];
                for(int i = 1; i < Num.NumbersArr.Length; i++)
                {
                    sum = iNum.Sum(sum, Num.NumbersArr[i]);
                }
                return sum;
            }
        }

        public float Average()
        {
            if (Num.NumbersArr.Length < 1) return 0;

            int sum = Sum();
            return iNum.Divide(sum, Num.NumbersArr.Length);
        }

    }
}
