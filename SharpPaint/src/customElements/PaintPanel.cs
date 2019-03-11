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
    class PaintPanel: PictureBox
    {
        private Graphics panelDraftGraphics;
        private bool paint = false;
        private List<IPaintObject> paintObjectList = new List<IPaintObject>();
        private IPaintObject currentPaintObject;
        private Bitmap bitmap;

        public Graphics PanelDraftGraphics { get => panelDraftGraphics; set => panelDraftGraphics = value; }
        public Bitmap Bitmap { get => bitmap; set => bitmap = value; }

        public void Initialize(Bitmap bitmap) {
            this.Bitmap = bitmap;
            this.Size = Bitmap.Size;

            PanelDraftGraphics = Graphics.FromImage(bitmap);

            this.MouseDown -= PaintPanel_MouseDown;
            this.MouseUp -= PaintPanel_MouseUp;
            this.MouseMove -= PaintPanel_MouseMove;

            this.MouseDown += PaintPanel_MouseDown;
            this.MouseUp += PaintPanel_MouseUp;
            this.MouseMove += PaintPanel_MouseMove;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            paintObjectList.ForEach(obj => obj.Draw());
            this.Image = bitmap;
        }

        private void PaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            currentPaintObject = new PaintCurve(PanelDraftGraphics);
            currentPaintObject.StartMove(new Point(e.X, e.Y));
        }

        private void PaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (currentPaintObject != null) {
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
    }
}
