using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Лаба_4
{
    public class Square : Rectangle
    {
        public string createname;
        public Square(int a, int y, int x, string name) : base(x, y, a, a)
        {
            this.createname = "Создался квадрат ";
            this.name = name;
            this.createname += Convert.ToString(name);
        }
    }
}
