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
    public partial class OpenFileQuestion : Form
    {
        private Action<bool, string> resultFunction;
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public OpenFileQuestion(string text, Action<bool, string> resultFunction)
        {
            openFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog.Title = "Open an Image File";
            openFileDialog.CheckFileExists = true;
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }
    }
}
