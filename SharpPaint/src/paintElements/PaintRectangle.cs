using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPaint.src.paintElements
{
    class PaintRectangle : IPaintObject
    {
        private Point startPoint;
        private Point endPoint;

        private Color color = Color.Black;
        private int lineSize = 1;
        private Graphics graphics;

        public PaintRectangle(Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public PaintRectangle(Graphics graphics, Color color, int size)
        {
            this.Graphics = graphics;
            this.Color = color;
            this.LineSize = size;
        }

        public Color Color { get => color; set => color = value; }
        public Graphics Graphics { get => graphics; set => graphics = value; }
        public int LineSize { get => lineSize; set => lineSize = value; }

        public void Draw()
        {
            int x = Math.Max(0, Math.Min(startPoint.X, endPoint.X));
            int y = Math.Max(0, Math.Min(startPoint.Y, endPoint.Y));
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);
            Pen pen = new Pen(this.Color, this.LineSize);
            graphics.DrawRectangle(pen, new Rectangle(x, y, width, height));
        }

        public void EndMove(Point point)
        {
            this.endPoint = point;
        }

        public void Move(Point point)
        {
            this.endPoint = point;
            this.Draw();
        }

        public bool BackAndNeedDelete()
        {
            return true;
        }

        public void StartMove(Point point)
        {
            this.startPoint = point;
            this.endPoint = this.startPoint;
        }
    }
}
