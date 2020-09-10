using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplofibonacciconherencia
{
    public partial class btnidentificarprimos : Form
    {
        Fibonacci fibonacci = new Fibonacci();
        Factorial factorial = new Factorial();
        Primos primos = new Primos();
        Consecutivos consecutivos = new Consecutivos();

        public btnidentificarprimos()
        {
            InitializeComponent();
        }

        private void btnverserie_Click(object sender, EventArgs e)
        {


            fibonacci.setNumero(long.Parse(txtnumero.Text));

            foreach (long valores in fibonacci.calcularFibonacci())
               lb1.Items.Add(valores);
            {

            }
                
            
            

            
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lblfactorial.Visible = false;
        }

        private void btncalcularfactorial_Click(object sender, EventArgs e)
        {
            factorial.setNumero(long.Parse(txtnumero.Text));
            lblfactorial.Visible = true;
            lblfactorial.Text = Convert.ToString(factorial.calcularFactorial());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primos.setNumero(long.Parse(txtnumero.Text));
            if (primos.identificarPrimo() == true)
            {
                MessageBox.Show("Es un numero Primo.");
            }
            else
            {
                MessageBox.Show("No es un numero primo");
            }
        }

        private void btnlistarconsecutivos_Click(object sender, EventArgs e)
        {
            consecutivos.setNumero(long.Parse(txtnumero.Text));
            foreach (long valores in consecutivos.listarConsecutivos())
            {
                dtnumeros.Rows.Add(valores);
            }
               
           
        }

        private void dtnumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
