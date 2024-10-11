using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetectarBorde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos PNG|*.png|Archivos JPG|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap resultado = new Bitmap(bmp.Width, bmp.Height);
            int[,] X = new int[,] {{ -1, 0, 1 },{ -2, 0, 2 },{ -1, 0, 1 }};

            int[,] Y = new int[,] {{ 1, 2, 1 },{ 0, 0, 0 },{ -1, -2, -1 }};

            int umbral = 100; // SeEnsibilidad del bodes de la imagen
            for (int x = 1; x < bmp.Width - 1; x++)
            {
                for (int y = 1; y < bmp.Height - 1; y++)
                {
                    int gradienteX = 0, gradienteY = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color c = bmp.GetPixel(x + i, y + j);
                            int valorGris = (c.R + c.G + c.B) / 3;

                            gradienteX += valorGris * X[i + 1, j + 1];
                            gradienteY += valorGris * Y[i + 1, j + 1];
                        }
                    }

                    int t = (int)Math.Sqrt(gradienteX * gradienteX + gradienteY * gradienteY);

                    if (t > umbral)
                    {
                        t = LimitarValor(t, 0, 255);
                        resultado.SetPixel(x, y, Color.FromArgb(t, t, t));
                    }
                    else
                    {
                        resultado.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox2.Image = resultado;
        }


        private int LimitarValor(int valor, int min, int max)
        {
            return Math.Min(Math.Max(valor, min), max);
        }
    }
}
