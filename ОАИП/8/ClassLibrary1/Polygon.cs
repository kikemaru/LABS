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
    public class Polygon: Figure
    {
        public PointF[] points { get; set; }
        public Polygon(PointF[] points)
        {
            this.points = points;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public void DeleteF(Figure figure, bool flag = true)
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
                || (x + w + x > Init.pictureBox.Width)
                || (x + x > Init.pictureBox.Width && y + y > Init.pictureBox.Height)
                || (y + h + y > Init.pictureBox.Height)
                || (x + x < 0 && y + y > Init.pictureBox.Height)
                || (x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false);
                Draw();
            }
        }
    }
    public class Triangle : Figure
    {
        public PointF[] points { get; set; }
        public Triangle(PointF[] points, string name)
        {
            this.name = name;
            this.points = points;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public void DeleteF(Figure figure, bool flag = true)
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
                || (x + w + x > Init.pictureBox.Width)
                || (x + x > Init.pictureBox.Width && y + y > Init.pictureBox.Height)
                || (y + h + y > Init.pictureBox.Height)
                || (x + x < 0 && y + y > Init.pictureBox.Height)
                || (x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false);
                Draw();
            }
        }
    }
}
