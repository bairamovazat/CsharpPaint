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
    public partial class InputSizeQuestion : Form
    {
        private Action<bool, Size?> heidthHeightFunction;

        public InputSizeQuestion(Action<bool, Size?> heidthHeightFunction)
        {
            this.heidthHeightFunction = heidthHeightFunction;
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxWidth.Text, out int intWidth) && int.TryParse(textBoxHeight.Text, out int intHeight))
            {
                if (intWidth <= 0 || intHeight <= 0)
                {
                    MessageBox.Show("Размеры должны быть больше 0", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                heidthHeightFunction(true, new Size(intWidth, intHeight));
                Close();
            }
            else
            {
                MessageBox.Show("Размеры должны быть числом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            heidthHeightFunction(false, null);
            Close();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
