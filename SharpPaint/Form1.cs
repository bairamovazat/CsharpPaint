using SharpPaint.src.paintElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPaint
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;

        private string lastFilePath = null;
        private Size defaultSize = new Size(360, 240);
        private PaintPanel pictureBox;

        public Form1()
        {
            InitializeComponent();
            InitPictureBox();
            pictureBox.MouseMove += (source, e) =>
            {
                Point point = pictureBox.ScalePoint(new Point(e.X, e.Y));
                labelMousePositon.Text = (point.X + ", " + point.Y);
                labelMousePositon.Update();
            };
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            this.Global_KeyDown(keyData);
            base.ProcessDialogKey(keyData);
            return true;
        }

        public void InitPictureBox()
        {
            pictureBox = new PaintPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            panelMainPaint.Controls.Add(this.pictureBox);
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(0, 0);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
        }

        public void createNewEmptyPaintPage(Size size)
        {
            bitmap = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox.Initialize(bitmap);
        }

        public void createNewPaintPageFromImage(String imagePath)
        {
            using (Stream s = File.OpenRead(imagePath))
            {
                bitmap = (Bitmap)Bitmap.FromStream(s);
            }
            pictureBox.Initialize(bitmap);
        }


        private void Global_KeyDown(Keys keyData)
        {
            if (ModifierKeys.HasFlag(Keys.Control) && keyData.Equals(Keys.Z))
            {
                pictureBox.BackAction();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && keyData.Equals(Keys.C))
            {
                IPaintObject paintObject = pictureBox.CurrentPaintObject;
                if (paintObject is PaintImage)
                {
                    PaintImage paintImage = (PaintImage)paintObject;
                    Clipboard.SetImage(paintImage.Bitmap);
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && keyData.Equals(Keys.V))
            {
                if (Clipboard.ContainsImage())
                {
                    Image image = Clipboard.GetImage();
                    pictureBox.InsertImage(new Bitmap(image, image.Size));
                }
            }
        }


        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InputSizeQuestion(
                (answer, size) =>
                {
                    if (answer && size != null)
                    {
                        ProcessError(() =>
                        {
                            createNewEmptyPaintPage(size.Value);
                        });
                    }
                })
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            }.ShowDialog();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog.Title = "Open an Image File";
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessError(() =>
                {
                    createNewPaintPageFromImage(openFileDialog.FileName);
                    lastFilePath = openFileDialog.FileName;
                });
            }

        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderBrowserDialog = new SaveFileDialog();
            folderBrowserDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            folderBrowserDialog.Title = "Save an Image File";
            folderBrowserDialog.AddExtension = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessError(() =>
                {
                    string path = folderBrowserDialog.FileName;
                    SaveImage(path, pictureBox);

                    this.lastFilePath = path;
                });
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lastFilePath == null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveImage(lastFilePath, pictureBox);
            }
        }

        public void ProcessError(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveImage(string path, PaintPanel paintPanel)
        {
            Bitmap bmp = new Bitmap(paintPanel.Width, paintPanel.Height);
            Rectangle rect = new Rectangle(0, 0, paintPanel.Width, paintPanel.Height);
            paintPanel.DrawToBitmap(bmp, rect);
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Extension.ToLower().Equals(".bmp"))
            {
                bmp.Save(path, ImageFormat.Bmp); //save location and type
            }
            else if (fileInfo.Extension.ToLower().Equals(".jpg"))
            {
                bmp.Save(path, ImageFormat.Png); //save location and type
            }
            else
            {
                throw new ArgumentException("Тип файла не распознан!");
            }
        }

        private void disableAllButtons() {
            //buttonPencil.Enabled = false;
            //buttonHotSpot.Enabled = false;
            //buttonRectangle.Enabled = false;
            //buttonEllipse.Enabled = false;
            //buttonLine.Enabled = false;
            //buttonEraser.Enabled = false;
            //button1px.Enabled = false;
            //buttonGreen.Enabled = false;
            //buttonWhite.Enabled = false;
            //buttonRed.Enabled = false;
            //buttonBlack.Enabled = false;
            //button20px.Enabled = false;
            //button10px.Enabled = false;
            //button5px.Enabled = false;
            //buttonCtrlC.Enabled = false;
            //buttonCtrlZ.Enabled = false;
            //buttonCtrlV.Enabled = false;
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            this.pictureBox.MouseType = MouseType.Pencil;
            //this.Cursor = new Cursor(@"resources\Pencil.cur");
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            disableAllButtons();
            this.pictureBox.MouseType = MouseType.Eraser;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.MouseType = MouseType.Line;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.MouseType = MouseType.Ellipse;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.MouseType = MouseType.Rectangle;
        }

        private void buttonHotSpot_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.MouseType = MouseType.HotSpot;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.Color = Color.Black;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.Color = Color.Red;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.Color = Color.White;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.Color = Color.Green;
        }

        private void button1px_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.LineSize = 1;
        }

        private void button5px_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.LineSize = 5;
        }

        private void button10px_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.LineSize = 10;
        }

        private void button20px_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            this.pictureBox.LineSize = 20;
        }

        private void buttonCtrlC_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            IPaintObject paintObject = pictureBox.CurrentPaintObject;
            if (paintObject is PaintImage)
            {
                PaintImage paintImage = (PaintImage)paintObject;
                Clipboard.SetImage(paintImage.Bitmap);
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void buttonCtrlV_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            if (Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();
                pictureBox.InsertImage(new Bitmap(image, image.Size));
            }
        }

        private void buttonCtrlZ_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            pictureBox.BackAction();
        }
    }
}
