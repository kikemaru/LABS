using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pen = new Pen(Color.Black, 5);
            Init.bitmap = bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = pen;
        }

        private void Button_DrawClick(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ShapeContainer.figureList.Clear();
            MyFigure myFigure = new MyFigure();
            myFigure.Draw();
            foreach(Figure f in ShapeContainer.figureList)
                comboBox1.Items.Add(f.name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            comboBox1.Items.Clear();
        }
    }
}
