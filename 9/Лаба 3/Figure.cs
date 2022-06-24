using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Лаба_4
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public string name;
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figurelist.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figurelist.Remove(figure);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.figurelist)
                {
                    f.Draw();
                }
                ShapeContainer.figurelist.Add(figure);
            }
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.AliceBlue);
        }
    }
}
