using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPaint.src.paintElements
{
    class PaintImage : IPaintObject
    {
        private Graphics graphics;
        private PaintPanel paintPanel;
        private Point startPoint;
        private Point movedPoint;

        private Bitmap bitmap;
        private Bitmap emptyBitmap;

        private bool hasBack = true;

        public Graphics Graphics { get => graphics; set => graphics = value; }

        public Point StartPoint { get => startPoint; set => startPoint = value; }
        public Point MovedPoint { get => movedPoint; set => movedPoint = value; }

        public Bitmap Bitmap {
            get  {
                return bitmap;
            }
            set {
                this.emptyBitmap = new Bitmap(value.Width, value.Height);
                bitmap = value;
            }
        }

        public bool HasBack { get => hasBack; set => hasBack = value; }
        public PaintPanel PaintPanel { get => paintPanel; set => paintPanel = value; }

        public PaintImage(Graphics graphics, PaintPanel paintPanel) {
            this.graphics = graphics;
            this.PaintPanel = paintPanel;
        }

        public PaintImage(Graphics graphics, PaintPanel paintPanel, Bitmap bitmap, Point startPoint)
        {
            this.graphics = graphics;
            this.PaintPanel = paintPanel;
            this.StartPoint = startPoint;
            this.MovedPoint = startPoint;
            this.Bitmap = bitmap;
        }

        public bool BackAndNeedDelete()
        {
            return HasBack;
        }

        public void Draw()
        {
          
            if (this.Bitmap != null && this.MovedPoint != null) {
                this.graphics.DrawImage(this.Bitmap, this.MovedPoint);
            }
        }

        public void EndMove(Point point)
        {
            int x = Math.Min(startPoint.X, point.X);
            int y = Math.Min(startPoint.Y, point.Y);
            int width = Math.Abs(startPoint.X - point.X);
            int height = Math.Abs(startPoint.Y - point.Y);

            Bitmap bmp = new Bitmap(width, height);
            Rectangle rect = new Rectangle(x, y, width, height);
            PaintPanel.DrawToBitmap(bmp, rect);

            this.Bitmap = bmp;
            this.graphics.Clear(Color.White);
            this.Draw();
        }

        public void Move(Point point)
        {
            this.MovedPoint = new Point(point.X, point.Y);
        }

        public void StartMove(Point point)
        {
            this.StartPoint = point;
        }

        public bool MouseInImage(Point point) {
            return movedPoint.X >= point.X && movedPoint.X + bitmap.Width <= point.X
                && movedPoint.Y >= point.Y && movedPoint.Y + bitmap.Height <= point.Y;
        }
    }
}
