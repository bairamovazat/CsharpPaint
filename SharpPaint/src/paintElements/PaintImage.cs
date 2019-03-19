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

        private Point lastMovePoint;
        private Bitmap bitmap;
        private Bitmap emptyBitmap;
        private bool paintEmptyBlock = false;

        private bool hasBack = true;

        private bool showRectangle = false;

        private int lineSize;
        private Color color;

        public Graphics Graphics { get => graphics; set => graphics = value; }

        public Point StartPoint { get => startPoint; set => startPoint = value; }
        public Point MovedPoint { get => movedPoint; set => movedPoint = value; }

        public Bitmap Bitmap
        {
            get
            {
                return bitmap;
            }
            set
            {
                this.emptyBitmap = new Bitmap(value.Width, value.Height);
                Graphics graphics = Graphics.FromImage(emptyBitmap);
                graphics.Clear(Color.White);
                graphics.Dispose();
                bitmap = value;
            }
        }

        public bool HasBack { get => hasBack; set => hasBack = value; }
        public PaintPanel PaintPanel { get => paintPanel; set => paintPanel = value; }
        public bool PaintEmptyBlock { get => paintEmptyBlock; set => paintEmptyBlock = value; }
        public int LineSize { get => lineSize; set => lineSize = value; }
        public Color Color { get => color; set => color = value; }
        public bool ShowRectangle { get => showRectangle; set => showRectangle = value; }

        public PaintImage(Graphics graphics, PaintPanel paintPanel)
        {
            this.graphics = graphics;
            this.PaintPanel = paintPanel;
        }

        public PaintImage(Graphics graphics, PaintPanel paintPanel, bool paintEmptyBlock)
        {
            this.graphics = graphics;
            this.PaintPanel = paintPanel;
            this.PaintEmptyBlock = paintEmptyBlock;
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
            if (!this.startPoint.Equals(this.movedPoint) && this.emptyBitmap != null && PaintEmptyBlock)
            {
                this.graphics.DrawImage(this.emptyBitmap, this.StartPoint);
            }

            if (ShowRectangle && this.Bitmap == null)
            {
                int x = Math.Max(0, Math.Min(startPoint.X, lastMovePoint.X));
                int y = Math.Max(0, Math.Min(startPoint.Y, lastMovePoint.Y));
                int width = Math.Abs(startPoint.X - lastMovePoint.X);
                int height = Math.Abs(startPoint.Y - lastMovePoint.Y);
                Pen pen = new Pen(Color.Black, 1);
                this.graphics.DrawRectangle(pen, x - 1, y - 1, width + 1, height + 1);
            }
            else if(ShowRectangle && this.Bitmap != null) {
                Pen pen = new Pen(Color.Black, 1);
                this.graphics.DrawRectangle(pen, this.movedPoint.X - 1, this.movedPoint.Y - 1,
                    this.Bitmap.Size.Width + 1, this.Bitmap.Height + 1);
            }

            if (this.Bitmap != null && this.MovedPoint != null)
            {
                this.graphics.DrawImage(this.Bitmap, this.MovedPoint);
            }
        }

        public void EndMove(Point point)
        {
            if (startPoint.X == point.X || startPoint.Y == point.Y)
            {
                this.movedPoint = startPoint;
            }
            else if (Bitmap == null && !startPoint.Equals(point))
            {
                int x = Math.Max(0, Math.Min(startPoint.X, point.X));
                int y = Math.Max(0, Math.Min(startPoint.Y, point.Y));
                int width = Math.Abs(startPoint.X - point.X);
                int height = Math.Abs(startPoint.Y - point.Y);

                var rect = PaintPanel.ClientRectangle;
                using (var output = new Bitmap(rect.Width, rect.Height, PaintPanel.Image.PixelFormat))
                {
                    PaintPanel.DrawToBitmap(output, rect);
                    this.Bitmap = output.Clone(new Rectangle(x + 1, y + 1, width, height), output.PixelFormat);
                }
                this.MovedPoint = new Point(x, y);
                this.StartPoint = new Point(x, y);

                this.graphics.Clear(Color.White);
                this.Draw();
            }
        }

        public void Move(Point point)
        {
            if (this.Bitmap != null)
            {
                //TODO Доделать
                int newX = point.X - this.startPoint.X;
                int newY = point.Y - this.startPoint.Y;
                this.movedPoint = new Point(point.X, point.Y);
            }
            this.lastMovePoint = new Point(point.X, point.Y);
        }

        public void StartMove(Point point)
        {
            this.ShowRectangle = true;

            if (Bitmap == null)
            {
                this.StartPoint = point;
                this.lastMovePoint = point;
            }
        }

        public bool MouseInImage(Point point)
        {
            return bitmap != null && movedPoint.X <= point.X && movedPoint.X + bitmap.Width >= point.X
                && movedPoint.Y <= point.Y && movedPoint.Y + bitmap.Height >= point.Y;
        }
    }
}
