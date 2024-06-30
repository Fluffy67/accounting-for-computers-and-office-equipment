using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ааааааааааааааааааааааааааааааааааааааа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Function(double x)
        {
            return x * x - 5 * x + 4;
        }
        private double FindRoot(double a, double b, double eps)
        {
            while (Math.Abs(b - a) >= 2 * eps)
            {
                double c = (a + b) / 2;
                double fa = Function(a);
                double fb = Function(b);
                double fc = Function(c);

                if (fa * fc <= 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }

            return (a + b) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, eps;
            if (!double.TryParse(textBox1.Text, out a) || !double.TryParse(textBox2.Text, out b) ||
                !double.TryParse(textBox3.Text, out eps))
            {
                MessageBox.Show("неправильно");
                return;
            }

            double root = FindRoot(a, b, eps);
            textBox4.Text = String.Format("{0:F5}", root);
        }
    }
    }

