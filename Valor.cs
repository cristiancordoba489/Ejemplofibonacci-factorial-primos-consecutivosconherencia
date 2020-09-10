using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplofibonacciconherencia
{
    public  class Valor
    {
        //atributo
        //long= es un entero como int pero soporta un valor mas largo

        private long numero;

        //metodos setter y getter

        //setter
        public void setNumero(long valor)
        {
            this.numero = valor;
        }
        //getter
        public long getNumero()
        {
            return this.numero;
        }



    }
}
