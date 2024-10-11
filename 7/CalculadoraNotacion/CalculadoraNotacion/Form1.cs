using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibraryNotacion;

namespace CalculadoraNotacion
{
    public partial class Form1 : Form
    {
        string c;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = "";
        }

        private void composicion(object sender, EventArgs e)
        {
            c += ((Button)sender).Text;
            textBox1.Text = c;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c = "";
            textBox1.Text = c;
            textBox2.Text = c;
            textBox3.Text = c;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            ClassLibraryNotacion.Class1 cl = new ClassLibraryNotacion.Class1();
            textBox3.Text = cl.ConvertirInfijoAPostfijo(textBox1.Text);
            double resultado = cl.EvaluarPostfijo(textBox3.Text);
            MostrarResultado(resultado);
        }
        private void MostrarResultado(double resultado)
        {
            if (resultado % 1 == 0)
            {
                textBox1.Text = Math.Round(resultado).ToString();
            }
            else
            {
                textBox1.Text = resultado.ToString("F5").TrimEnd('0').TrimEnd('.');
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (c.Length > 0)
            {
                c = c.Substring(0, c.Length - 1); 
                textBox1.Text = c; 
            }
        }

        // Función para calcular la raíz cuadrada
        private void button19_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            if (n >= 0)
            {
                n = Math.Sqrt(n);
                MostrarResultado(n);
            }
        }

        // Función para calcular el cuadrado
        private void button20_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            n = Math.Pow(n, 2);
            MostrarResultado(n);
        }

        // Función para calcular logaritmo base 10
        private void button17_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            if (n > 0)
            {
                n = Math.Log10(n);
                MostrarResultado(n);
            }
        }
    }
}
