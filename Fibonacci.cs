using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplofibonacciconherencia
{
     public class Fibonacci: Valor

    {
        public List<long> calcularFibonacci()
        {
            List<long> fibonacci = new List<long>();

            long numero;

            numero = this.getNumero();


            long a;
            long b;
            long c;

            a = 0;
            b = 1;
            c = 0;



            for (long i = 0; i < numero; i++)
            {

                if (i == 0)
                {
                    //i es lo que sale en la lista
                    fibonacci.Add(i);

                }

                a = a + c;
                b = c;
                c = a;

                fibonacci.Add(a);

            }

            return fibonacci;


        } 
    }
}
