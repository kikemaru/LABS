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

    abstract public class Figure
    {
        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        abstract public void Clear();

    }
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
    }
    
}
