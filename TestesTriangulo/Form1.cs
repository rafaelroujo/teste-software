using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesTriangulo
{
    public partial class Form1 : Form
    {
        int ladoA, ladoB, ladoC;
        string retorno;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            teste novoTeste = new teste();
            ladoA = Convert.ToInt32(tbxLado1.Text);
            ladoB = Convert.ToInt32(tbxLado2.Text);
            ladoC = Convert.ToInt32(tbxLado3.Text);

            retorno = novoTeste.calculo(ladoA,ladoB,ladoC);
            lblResultado.Text = retorno;
            
        }
        
    }
    public class teste
    {
        public string calculo(int lado1, int lado2, int lado3)
        {


            string type = "ESCALENO";

            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
                type = "INEXISTENTE";
            else if (!((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1)))
                type = "INEXISTENTE";
            else if (lado1 == lado2)
            {
                type = "ISOCELES";
                if (lado2 == lado3)
                    type = "EQUILATERO";
            }
            else if (lado2 == lado3 || lado1 == lado3)
            {
                type = "ISOCELES";
            }

            return type;



        }

        public string GetType(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
