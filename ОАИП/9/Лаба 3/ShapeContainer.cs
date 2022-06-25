using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Лаба_4
{
    public class ShapeContainer
    {
        public static List<Figure> figurelist = new List<Figure>();

        public static void AddFigure(Figure figure)
        {
            figurelist.Add(figure);
        }
        public static Figure FindFigure(string name)
        {
            foreach (Figure figure in figurelist)
            {
                if (figure.name == name)
                {
                    return figure;
                }
            }
            return null;
        }
    }
}
