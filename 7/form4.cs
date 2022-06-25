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
    public partial class Form4 : Form
    {
        public double z;
        public double y;
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calc ur = new calc();
           y = double.Parse(textBox1.Text);
            ur.first = double.Parse(textBox2.Text);
            ur.second = double.Parse(textBox3.Text);
            z = ur.equation(y);
            textBox4.Text = z.ToString();
        }
    }
    public class calc
    {
        public double first;
        public double second;
        public double equation(double y)
        {
            var x = (y - second) / first;
            return x;
        }
    }
}
