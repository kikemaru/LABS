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
    public class Rectagle: Figure
    {
        public Rectagle(int x, int y, int w, int h, string name)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.name = name;
        }
        public Rectagle()
        {
            x = 0;
            y = 0;
            w = 0;
            h = 0;
            name = "";
        }
        public override void Draw() 
        {
            Graphics g1 = Graphics.FromImage(Init.bitmap);
            g1.DrawRectangle(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }

        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figureList)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                this.Clear();
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
            if (!((this.x + x< 0 && this.y + y< 0)
                || (this.y + y< 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y< 0) 
                || (this.x + this.w + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height) 
                || (this.y + this.h + y > Init.pictureBox.Height)
                || (this.x + x< 0 && this.y + y> Init.pictureBox.Height) 
                || (this.x + x< 0)))
                {
                    this.x += x;
                    this.y += y;
                    this.DeleteF(this, false);
                    this.Draw();
                }
        }
    }
    public class Square : Rectagle
    {
        public Square(int x, int y, int w, string name) : base(x, y, w, w, name) { }
        
    }
}
