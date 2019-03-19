using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPaint.src.paintElements
{
    class PaintLine : IPaintObject
    {
        private Point startPoint;
        private Point endPoint;

        private Color color = Color.Black;
        private int lineSize = 1;
        private Graphics graphics;

        public PaintLine(Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public PaintLine(Graphics graphics, Color color, int size)
        {
            this.Graphics = graphics;
            this.Color = color;
            this.LineSize = size;
        }

        public Color Color { get => Color1; set => Color1 = value; }
        public int Size { get => LineSize; set => LineSize = value; }
        public Graphics Graphics { get => graphics; set => graphics = value; }
        public Color Color1 { get => color; set => color = value; }
        public int LineSize { get => lineSize; set => lineSize = value; }

        public void Draw()
        {
            Pen pen = new Pen(this.Color, this.LineSize);
            graphics.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
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
