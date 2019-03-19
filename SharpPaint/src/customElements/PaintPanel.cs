using SharpPaint.src.paintElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPaint
{
    public class PaintPanel : PictureBox
    {
        private Graphics panelDraftGraphics;
        private bool paint = false;
        private List<IPaintObject> paintObjectList = new List<IPaintObject>();
        private IPaintObject currentPaintObject;
        private Bitmap bitmap;
        private PointF zoomPoint = new PointF(1.0F, 1.0F);
        private MouseType mouseType = MouseType.Pencil;
        private Color color = Color.Black;
        private int lineSize = 3;

        public Graphics PanelDraftGraphics { get => panelDraftGraphics; set => panelDraftGraphics = value; }
        public Bitmap Bitmap { get => bitmap; set => bitmap = value; }
        internal IPaintObject CurrentPaintObject { get => currentPaintObject; set => currentPaintObject = value; }
        public PointF ZoomPoint { get => zoomPoint; set => zoomPoint = value; }
        public MouseType MouseType { get => mouseType; set => mouseType = value; }
        public Color Color { get => color; set => color = value; }
        public int LineSize { get => lineSize; set => lineSize = value; }

        public void Initialize(Bitmap bitmap)
        {
            this.Bitmap = new Bitmap(bitmap.Size.Width, bitmap.Size.Height);
            this.Size = Bitmap.Size;

            PanelDraftGraphics = Graphics.FromImage(this.Bitmap);
            PaintImage paintImage = new PaintImage(PanelDraftGraphics, this, bitmap, new Point(0, 0));
            paintImage.HasBack = false;
            paintObjectList.Add(paintImage);

            this.MouseDown -= PaintPanel_MouseDown;
            this.MouseUp -= PaintPanel_MouseUp;
            this.MouseMove -= PaintPanel_MouseMove;

            this.MouseDown += PaintPanel_MouseDown;
            this.MouseUp += PaintPanel_MouseUp;
            this.MouseMove += PaintPanel_MouseMove;
            this.MouseWheel += PaintPanel_MouseWheel;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            paintObjectList.ForEach(obj => obj.Draw());
            if (this.bitmap != null)
            {
                if (this.Image != null)
                {
                    this.Image.Dispose();
                }
                Image image = bitmap;
                this.Image = new Bitmap(image, ScaleSize(image.Size));
            }
        }

        public void BackAction()
        {
            if (paintObjectList.Count > 0)
            {
                if (paintObjectList.Last().BackAndNeedDelete())
                {
                    paintObjectList.RemoveAt(paintObjectList.Count - 1);
                    this.panelDraftGraphics.Clear(Color.White);
                }
            }
        }

        public void InsertImage(Bitmap bitmap)
        {
            this.paint = false;
            CurrentPaintObject = new PaintImage(PanelDraftGraphics, this, bitmap, new Point(0, 0));
            paintObjectList.Add(CurrentPaintObject);
        }

        private IPaintObject GetCurrentPaintObject()
        {
            switch (mouseType)
            {
                case (MouseType.Pencil):
                    return new PaintCurve(PanelDraftGraphics);
                case (MouseType.HotSpot):
                    return new PaintImage(PanelDraftGraphics, this, true);
                case (MouseType.Rectangle):
                    return new PaintRectangle(PanelDraftGraphics);
                case (MouseType.Ellipse):
                    return new PaintEllipse(PanelDraftGraphics);
                case (MouseType.Line):
                    return new PaintLine(PanelDraftGraphics);
                case (MouseType.Eraser):
                    return new PaintEraser(PanelDraftGraphics);
                default: return null;
            }
        }
        private void PaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            if (CurrentPaintObject == null || !(CurrentPaintObject is PaintImage)
                || !((PaintImage)CurrentPaintObject).MouseInImage(ScalePoint(new Point(e.X, e.Y))))
            {
                CurrentPaintObject = GetCurrentPaintObject();
                if (CurrentPaintObject != null) {
                    CurrentPaintObject.LineSize = LineSize;
                    CurrentPaintObject.Color = Color;
                    paintObjectList.Add(CurrentPaintObject);
                }
            }
            CurrentPaintObject.StartMove(ScalePoint(new Point(e.X, e.Y)));
        }

        private void PaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (CurrentPaintObject != null)
            {
                CurrentPaintObject.EndMove(ScalePoint(new Point(e.X, e.Y)));
            }
        }

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint && CurrentPaintObject != null)
            {
                CurrentPaintObject.Move(ScalePoint(new Point(e.X, e.Y)));
            }
        }

        private void PaintPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                float deltaZoom = e.Delta / 1200.0F;
                if (ZoomPoint.X + deltaZoom >= 1.0 && ZoomPoint.Y + deltaZoom >= 1.0)
                {
                    ZoomPoint = new PointF(ZoomPoint.X + deltaZoom, ZoomPoint.Y + deltaZoom);
                    UpdatePanelScale();
                }
            }
        }

        private void UpdatePanelScale()
        {
            this.Size = ScaleSize(this.Bitmap.Size);
        }

        public Point ScalePoint(Point point)
        {
            int newX = Convert.ToInt32(point.X / ZoomPoint.X);
            int newY = Convert.ToInt32(point.Y / ZoomPoint.Y);
            return new Point(newX, newY);
        }

        public Size ScaleSize(Size size)
        {
            int newWidth = Convert.ToInt32(size.Width * ZoomPoint.X);
            int newHeight = Convert.ToInt32(size.Height * ZoomPoint.Y);
            return new Size(newWidth, newHeight);
        }

        public Rectangle ScaleRectangle(Rectangle rectangle)
        {
            return new Rectangle(ScalePoint(rectangle.Location), ScaleSize(rectangle.Size));
        }

        public Point ReScalePoint(Point point)
        {
            int newX = Convert.ToInt32(point.X * ZoomPoint.X);
            int newY = Convert.ToInt32(point.Y * ZoomPoint.Y);
            return new Point(newX, newY);
        }

        public Size ReScaleSize(Size size)
        {
            int newWidth = Convert.ToInt32(size.Width / ZoomPoint.X);
            int newHeight = Convert.ToInt32(size.Height / ZoomPoint.Y);
            return new Size(newWidth, newHeight);
        }

        public Rectangle ReScaleRectangle(Rectangle rectangle)
        {
            return new Rectangle(ReScalePoint(rectangle.Location), ReScaleSize(rectangle.Size));
        }
    }
}
