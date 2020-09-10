
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//para que no me marque error cuando llamo la clase temperatura
using EjemploConversorTemperatura.clase;

namespace EjemploConversorTemperatura
{
    public partial class Form1 : Form
    {
        //instancia de la clase.
        Temperatura temperatura = new Temperatura();



        public Form1()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e)
        {
            double valorGrado;

            valorGrado = double.Parse(txtvalor.Text);
            temperatura.setGrados(valorGrado);
            lbltotal.Text = Convert.ToString(temperatura.covertirAFahrenheit());

            lbltotal.Visible = true;
        }
    }
}
