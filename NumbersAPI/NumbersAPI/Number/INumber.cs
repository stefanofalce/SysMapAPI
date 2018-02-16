using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersAPI.Number
{
    public interface INumber
    {

        //Interface do recurso Number para padronizar entrega de métodos independentemente da implementação

        int Sum(int a, int b);
        float Divide(int a, int b);
    }
}
