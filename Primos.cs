using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplofibonacciconherencia
{
    public class Primos : Valor
    { 
        public bool identificarPrimo()
        {
            long numero;
            int contador;
            int divisible;

            numero = this.getNumero();

            //especificar que se inicia en uno la division
            divisible = 1;

            //las veces en el que el numero es divisible
            contador = 0;

            while (divisible <= numero)
            {
               if ((numero % divisible) == 0 ){
                    contador++;
                }
                divisible++;
            }
            if(contador ==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
