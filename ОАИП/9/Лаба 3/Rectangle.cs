using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Лаба_4
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0) || (this.y + y < 0) || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
            || (this.x + this.w + x > Init.pictureBox.Width) || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
            || (this.y + this.h + y > Init.pictureBox.Height) || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false);
                Draw();
            }
            else
            {
                MessageBox.Show("Фигура не может выйти за границу");
            }
        }
    }
}
