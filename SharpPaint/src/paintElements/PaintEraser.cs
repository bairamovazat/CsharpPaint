using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPaint.src.paintElements
{
    class PaintEraser : IPaintObject
    {
        private int x;
        private int y;
        private Color color = Color.White;
        private int lineSize = 10;
        private Graphics graphics;
        private List<Point> pointLists = new List<Point>();

        public PaintEraser(Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public PaintEraser(Graphics graphics, Color color, int size)
        {
            this.Graphics = graphics;   
            this.Color = color;
            this.LineSize = size;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Color Color { get => color; set => color = value; }
        public Graphics Graphics { get => graphics; set => graphics = value; }
        public int LineSize { get => lineSize; set => lineSize = value; }

        public void Draw()
        {
            if (pointLists.Count >= 2)
            {
                Pen pen = new Pen(Color.White, this.LineSize);
                graphics.DrawLines(pen, pointLists.ToArray());
            }

        }

        public void EndMove(Point point)
        {

        }

        public void Move(Point point)
        {
            pointLists.Add(point);
            Draw();
        }

        public bool BackAndNeedDelete()
        {
            return true;
        }

        public void StartMove(Point point)
        {
            Move(point);
        }
    }
}
