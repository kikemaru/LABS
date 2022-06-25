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
    public class MyFigure : Figure
    {
        Triangle triangle1;
        Triangle triangle2;
        Triangle triangle3;
        Triangle triangle4;
        Rectagle rectagle1;
        Circle circle1;
        Circle circle2;
        Circle circle3;
        public MyFigure() 
        {
            PointF[] tr1 = {
                new PointF(25, 200),
                new PointF(100, 275),
                new PointF(100, 200)
            };
            triangle1 = new Triangle(tr1, "tr1");

            rectagle1 = new Rectagle(101, 200, 150, 76, "rec");
            circle1 = new Circle(161, 219, 30, "circ1");
            circle2 = new Circle(116, 219, 30, "circ2");
            circle3 = new Circle(206, 219, 30, "circ3");

            PointF[] tr2 = {
                new PointF(327, 200),
                new PointF(252, 275),
                new PointF(252, 200)
            };
            triangle2 = new Triangle(tr2, "tr2");

            PointF[] tr3 = {
                new PointF(277, 200),
                new PointF(202, 50),
                new PointF(202, 200)
            };
            triangle3 = new Triangle(tr3, "tr3");

            PointF[] tr4 = {
                new PointF(150, 75),
                new PointF(200, 47),
                new PointF(200, 75)
            };
            triangle4 = new Triangle(tr4, "tr4");

        }

        
        public static void DeleteFigure()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            triangle1.Draw();
            triangle2.Draw();
            triangle3.Draw();
            triangle4.Draw();
            rectagle1.Draw();
            circle1.Draw();
            circle2.Draw();
            circle3.Draw();

            ShapeContainer.figureList.Add(triangle1);
            ShapeContainer.figureList.Add(triangle2);
            ShapeContainer.figureList.Add(triangle3);
            ShapeContainer.figureList.Add(triangle4);
            ShapeContainer.figureList.Add(rectagle1);
            ShapeContainer.figureList.Add(circle1);
            ShapeContainer.figureList.Add(circle2);
            ShapeContainer.figureList.Add(circle3);
            Init.pictureBox.Image = Init.bitmap;
        }

        public void DeleteFigure(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                ShapeContainer.figureList.Remove(figure);
                Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
            }
            else
            {
                ShapeContainer.figureList.Remove(figure);
                Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
                ShapeContainer.figureList.Add(figure);
            }
        }
        public override void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
        public override void MoveTo(int x, int y)
        {
            if (!((x + x < 0 && y + y < 0)
                || (y + y < 0)
                || (x + x > Init.pictureBox.Width && y + y < 0)
                || (x + this.w + x > Init.pictureBox.Width)
                || (x + x > Init.pictureBox.Width && y + y > Init.pictureBox.Height)
                || (y + this.h + y > Init.pictureBox.Height)
                || (x + x < 0 && y + y > Init.pictureBox.Height)
                || (x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteFigure(this, false);
                Draw();
            }
        }
    }
}
