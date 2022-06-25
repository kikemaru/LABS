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
    public partial class Form2 : Form
    {
        public int x, y, min, max;
        public double z;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            if (x > y) {
                max = x; min = y;
            } else {
                max = y; min = x;
            }
            z = (max + 0.5) / (1 + min);
            label5.Text = z.ToString("0.000");
        }
    }
}
