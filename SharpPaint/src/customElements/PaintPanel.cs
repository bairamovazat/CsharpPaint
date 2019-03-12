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

        public Graphics PanelDraftGraphics { get => panelDraftGraphics; set => panelDraftGraphics = value; }
        public Bitmap Bitmap { get => bitmap; set => bitmap = value; }
        private int test = 1;

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
                this.Image = bitmap;
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

        private void PaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            currentPaintObject = new PaintImage(PanelDraftGraphics, this);
            //currentPaintObject = new PaintCurve(PanelDraftGraphics);
            currentPaintObject.StartMove(new Point(e.X, e.Y));
        }

        private void PaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (currentPaintObject != null)
            {
                currentPaintObject.EndMove(new Point(e.X, e.Y));
                paintObjectList.Add(currentPaintObject);
                currentPaintObject = null;
            }
        }

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint && currentPaintObject != null)
            {
                currentPaintObject.Move(new Point(e.X, e.Y));
            }
        }

        private void PaintPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
                test = test + numberOfTextLinesToMove;
                Console.WriteLine(test);
            }
        }
    }
}
