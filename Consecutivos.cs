using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplofibonacciconherencia
{
     public class Consecutivos : Valor
    {
        public List<long> listarConsecutivos()
        {
            long numero;
            long contador;
            List<long> listanumeros = new List<long>();
            
            numero = this.getNumero();
            contador = 0;

            for (int i=0; i<numero; i++)
            {
                contador++;
                listanumeros.Add(contador);
            }

            return listanumeros;
        }
    }
}
