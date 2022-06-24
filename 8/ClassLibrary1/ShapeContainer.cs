using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class ShapeContainer
    {
        public static List<Figure> figureList;
        static ShapeContainer()
        {
            figureList = new List<Figure>();
        }
        public static void AddFigure(Figure figure)
        {
            figureList.Add(figure);
        }
    }
}
