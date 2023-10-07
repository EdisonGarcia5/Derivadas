using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Derivadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtExtremoInferior.Text);
                double b = double.Parse(txtExtremoSuperior.Text);
                int n = int.Parse(txtNumRectangulos.Text);

                double resultado = CalcularIntegral(a, b, n);
                lblResultado.Text = "Estimación de la integral: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la integral: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularIntegral(double a, double b, int n)
        {
            double h = (b - a) / n;
            double integral = 0.0;

            for (int i = 0; i < n; i++)
            {
                double xi = a + i * h;
                integral += FuncionAIntegrar(xi) * h;
            }

            return integral;
        }

        private double FuncionAIntegrar(double x)
        {
            // Define la función a integrar (por ejemplo, f(x) = x^2)
            return x * x;
        }




    }
}
