using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplofibonacciconherencia
{
    public class Factorial : Valor
    {
        public long calcularFactorial()
        {
            long factorial;
            long numero;
            factorial = 1;
            numero = this.getNumero();

            for(long i=1; i<=numero; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
            
        }

    }
}
