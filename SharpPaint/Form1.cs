using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPaint
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(360, 240);
            panelPaint.Initialize(bitmap); 
            this.DoubleBuffered = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(panelPaint.Width, panelPaint.Height);//to create bmp of same size as panel
            Rectangle rect = new Rectangle(0, 0, panelPaint.Width, panelPaint.Height); //to set bounds to image
            panelPaint.DrawToBitmap(bmp, rect);      // drawing panel1 imgae into bmp of bounds of rect
            bmp.Save(@"C:\Users\Azat\Pictures\image.png", ImageFormat.Png); //save location and type
        }
    }
}
