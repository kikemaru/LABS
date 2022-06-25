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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int n = 12, k = 3;
            int[,] a = new int[k, n];
            for (int i=0; i<k; i++) {
                for (int j=0; j<n; j++) {
                    a[i, j] = (rand.Next() % 35 + 25) * 1000;
                    textBox1.Text += String.Format("{0} ", a[i, j]);
                }
                textBox1.Text += "\n";
            }
            int s = 0;
            for (int i=0; i<k; i++) {
                for (int j=0; j<n; j++) {
                    s += a[i, j];
                }
            }
            textBox2.Text += String.Format("{0} ", s);
            s = 0;
            for (int j=0; j<n; j++) {
                for (int i=0; i<k; i++) {
                    s += a[i, j];
                }
                textBox3.Text += String.Format("{0} ", s);
            }
            for (int i=0; i<k; i++) {
                s = 0;
                for (int j=0; j<n; j++) {
                    s += a[i, j];
                }
                textBox4.Text += String.Format("{0} ", s);
            }
        }


    }
}
