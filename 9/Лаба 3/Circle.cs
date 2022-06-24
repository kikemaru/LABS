using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Лаба_4
{
    public class Circle : Ellipse
    {
        public string createcircle;
        public Circle(int w, int y, int x, string name) : base(x, y, w, w)
        {
            this.createcircle = "Создалась окружность ";
            this.name = name;
            this.createcircle += Convert.ToString(name);
        }
    }
}
