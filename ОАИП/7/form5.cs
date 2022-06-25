using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace оаип_1_лаба
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x_A = double.Parse(textBox1.Text);
            double y_A = double.Parse(textBox2.Text);
            double x_B = double.Parse(textBox3.Text);
            double y_B = double.Parse(textBox4.Text);
            double x_C = double.Parse(textBox5.Text);
            double y_C = double.Parse(textBox6.Text);
            double x_D = double.Parse(textBox7.Text);
            double y_D = double.Parse(textBox8.Text);
            double d1, d2, d3, d4, S, P;
            d1 = Math.Sqrt(Math.Pow(x_B - x_A, 2) + Math.Pow(y_B - y_A, 2));
            d2 = Math.Sqrt(Math.Pow(x_C - x_B, 2) + Math.Pow(y_C - y_B, 2));
            d3 = Math.Sqrt(Math.Pow(x_D - x_C, 2) + Math.Pow(y_D - y_C, 2));
            d4 = Math.Sqrt(Math.Pow(x_A - x_D, 2) + Math.Pow(y_A - y_D, 2));
            S = d1 * d2;
            P = d1 + d2 + d3 + d4;
            label7.Text = S.ToString("0.000");
            label9.Text = P.ToString("0.000");
        }

    }
}
