using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploConversorTemperatura.clase
{
     public class Temperatura//o temperatura
    {
        //los atributos tienen que ser privados
        //1.Atributos
        private double grados;

        //metos setter y getter
        //getter
        //setter: entrega valor a / al atributo(s)
        public void setGrados(double valor )
        {
            this.grados = valor;
        }
        //getter:Consulta que valor hay en el atributo

        public double getGrados()
        {
            return this.grados;
        }

        //3.crear metodos de acción(el calculo)

        public double covertirAFahrenheit()
        {
            double total;
            total = (this.getGrados()* 9 / 5) +32;
            return total;
        }
      


    }
}
