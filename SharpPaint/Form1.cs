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
                labelMousePositon.Text = (e.X + ", " + e.Y);
                labelMousePositon.Update();
            };
            this.KeyDown += Global_KeyDown;
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


        private void Global_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                pictureBox.BackAction();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                IPaintObject paintObject = pictureBox.CurrentPaintObject;
                if (paintObject is PaintImage)
                {
                    PaintImage paintImage = (PaintImage)paintObject;
                    Clipboard.SetImage(paintImage.Bitmap);
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
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

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            this.pictureBox.MouseType = MouseType.Pencil;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {

        }

        private void buttonLine_Click(object sender, EventArgs e)
        {

        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {

        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {

        }

        private void buttonHotSpot_Click(object sender, EventArgs e)
        {
            this.pictureBox.MouseType = MouseType.HotSpot;

        }
    }
}
