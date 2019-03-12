using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPaint
{
    public partial class SaveFileQuestion : Form
    {
        private Action<bool, string> resultFunction;
        private SaveFileDialog FolderBrowserDialog = new SaveFileDialog();

        public SaveFileQuestion(string text, Action<bool, string> resultFunction)
        {
            FolderBrowserDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            FolderBrowserDialog.Title = "Save an Image File";
            FolderBrowserDialog.AddExtension = true;
            this.resultFunction = resultFunction;
            InitializeComponent();
            this.labelText.Text = text;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            resultFunction(true, textBox.Text);
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            resultFunction(false, "");
            Close();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = FolderBrowserDialog.FileName;
            }
        }
    }
}
