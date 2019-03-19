namespace SharpPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCtrlZ = new System.Windows.Forms.Button();
            this.buttonCtrlV = new System.Windows.Forms.Button();
            this.buttonCtrlC = new System.Windows.Forms.Button();
            this.button20px = new System.Windows.Forms.Button();
            this.button10px = new System.Windows.Forms.Button();
            this.button5px = new System.Windows.Forms.Button();
            this.button1px = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonHotSpot = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.labelMousePositon = new System.Windows.Forms.Label();
            this.panelMainPaint = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.AllowDrop = true;
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelButtons.Controls.Add(this.buttonCtrlZ);
            this.panelButtons.Controls.Add(this.buttonCtrlV);
            this.panelButtons.Controls.Add(this.buttonCtrlC);
            this.panelButtons.Controls.Add(this.button20px);
            this.panelButtons.Controls.Add(this.button10px);
            this.panelButtons.Controls.Add(this.button5px);
            this.panelButtons.Controls.Add(this.button1px);
            this.panelButtons.Controls.Add(this.buttonGreen);
            this.panelButtons.Controls.Add(this.buttonWhite);
            this.panelButtons.Controls.Add(this.buttonRed);
            this.panelButtons.Controls.Add(this.buttonBlack);
            this.panelButtons.Controls.Add(this.buttonHotSpot);
            this.panelButtons.Controls.Add(this.buttonRectangle);
            this.panelButtons.Controls.Add(this.buttonEllipse);
            this.panelButtons.Controls.Add(this.buttonLine);
            this.panelButtons.Controls.Add(this.buttonEraser);
            this.panelButtons.Controls.Add(this.buttonPencil);
            this.panelButtons.Controls.Add(this.labelMousePositon);
            this.panelButtons.Location = new System.Drawing.Point(0, 24);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(85, 577);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonCtrlZ
            // 
            this.buttonCtrlZ.Location = new System.Drawing.Point(12, 425);
            this.buttonCtrlZ.Name = "buttonCtrlZ";
            this.buttonCtrlZ.Size = new System.Drawing.Size(56, 26);
            this.buttonCtrlZ.TabIndex = 17;
            this.buttonCtrlZ.Text = "Ctrl + Z";
            this.buttonCtrlZ.UseVisualStyleBackColor = true;
            this.buttonCtrlZ.Click += new System.EventHandler(this.buttonCtrlZ_Click);
            // 
            // buttonCtrlV
            // 
            this.buttonCtrlV.Location = new System.Drawing.Point(12, 393);
            this.buttonCtrlV.Name = "buttonCtrlV";
            this.buttonCtrlV.Size = new System.Drawing.Size(56, 26);
            this.buttonCtrlV.TabIndex = 16;
            this.buttonCtrlV.Text = "Ctrl + V";
            this.buttonCtrlV.UseVisualStyleBackColor = true;
            this.buttonCtrlV.Click += new System.EventHandler(this.buttonCtrlV_Click);
            // 
            // buttonCtrlC
            // 
            this.buttonCtrlC.Location = new System.Drawing.Point(12, 361);
            this.buttonCtrlC.Name = "buttonCtrlC";
            this.buttonCtrlC.Size = new System.Drawing.Size(56, 26);
            this.buttonCtrlC.TabIndex = 15;
            this.buttonCtrlC.Text = "Ctrl + C";
            this.buttonCtrlC.UseVisualStyleBackColor = true;
            this.buttonCtrlC.Click += new System.EventHandler(this.buttonCtrlC_Click);
            // 
            // button20px
            // 
            this.button20px.Location = new System.Drawing.Point(12, 296);
            this.button20px.Name = "button20px";
            this.button20px.Size = new System.Drawing.Size(56, 26);
            this.button20px.TabIndex = 14;
            this.button20px.Text = "20px";
            this.button20px.UseVisualStyleBackColor = true;
            this.button20px.Click += new System.EventHandler(this.button20px_Click);
            // 
            // button10px
            // 
            this.button10px.Location = new System.Drawing.Point(12, 264);
            this.button10px.Name = "button10px";
            this.button10px.Size = new System.Drawing.Size(56, 26);
            this.button10px.TabIndex = 13;
            this.button10px.Text = "10px";
            this.button10px.UseVisualStyleBackColor = true;
            this.button10px.Click += new System.EventHandler(this.button10px_Click);
            // 
            // button5px
            // 
            this.button5px.Location = new System.Drawing.Point(12, 232);
            this.button5px.Name = "button5px";
            this.button5px.Size = new System.Drawing.Size(56, 26);
            this.button5px.TabIndex = 12;
            this.button5px.Text = "5px";
            this.button5px.UseVisualStyleBackColor = true;
            this.button5px.Click += new System.EventHandler(this.button5px_Click);
            // 
            // button1px
            // 
            this.button1px.Location = new System.Drawing.Point(12, 200);
            this.button1px.Name = "button1px";
            this.button1px.Size = new System.Drawing.Size(56, 26);
            this.button1px.TabIndex = 11;
            this.button1px.Text = "1px";
            this.button1px.UseVisualStyleBackColor = true;
            this.button1px.Click += new System.EventHandler(this.button1px_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(42, 154);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(26, 26);
            this.buttonGreen.TabIndex = 10;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(12, 154);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(26, 26);
            this.buttonWhite.TabIndex = 9;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(42, 122);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(26, 26);
            this.buttonRed.TabIndex = 8;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBlack.Location = new System.Drawing.Point(12, 122);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(26, 26);
            this.buttonBlack.TabIndex = 7;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonHotSpot
            // 
            this.buttonHotSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHotSpot.Image = ((System.Drawing.Image)(resources.GetObject("buttonHotSpot.Image")));
            this.buttonHotSpot.Location = new System.Drawing.Point(42, 73);
            this.buttonHotSpot.Name = "buttonHotSpot";
            this.buttonHotSpot.Size = new System.Drawing.Size(26, 26);
            this.buttonHotSpot.TabIndex = 6;
            this.buttonHotSpot.UseVisualStyleBackColor = true;
            this.buttonHotSpot.Click += new System.EventHandler(this.buttonHotSpot_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(12, 73);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(26, 26);
            this.buttonRectangle.TabIndex = 5;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.Location = new System.Drawing.Point(42, 44);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(26, 26);
            this.buttonEllipse.TabIndex = 4;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.Location = new System.Drawing.Point(12, 44);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(26, 26);
            this.buttonLine.TabIndex = 3;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Image = ((System.Drawing.Image)(resources.GetObject("buttonEraser.Image")));
            this.buttonEraser.Location = new System.Drawing.Point(42, 15);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(26, 26);
            this.buttonEraser.TabIndex = 2;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPencil.Image")));
            this.buttonPencil.Location = new System.Drawing.Point(12, 15);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(26, 26);
            this.buttonPencil.TabIndex = 1;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // labelMousePositon
            // 
            this.labelMousePositon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMousePositon.Location = new System.Drawing.Point(0, 561);
            this.labelMousePositon.Name = "labelMousePositon";
            this.labelMousePositon.Size = new System.Drawing.Size(85, 16);
            this.labelMousePositon.TabIndex = 0;
            // 
            // panelMainPaint
            // 
            this.panelMainPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainPaint.AutoScroll = true;
            this.panelMainPaint.Location = new System.Drawing.Point(86, 24);
            this.panelMainPaint.Margin = new System.Windows.Forms.Padding(0);
            this.panelMainPaint.Name = "panelMainPaint";
            this.panelMainPaint.Size = new System.Drawing.Size(537, 577);
            this.panelMainPaint.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.panelMainPaint);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.panelButtons.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMainPaint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label labelMousePositon;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonHotSpot;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button button1px;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button button20px;
        private System.Windows.Forms.Button button10px;
        private System.Windows.Forms.Button button5px;
        private System.Windows.Forms.Button buttonCtrlC;
        private System.Windows.Forms.Button buttonCtrlZ;
        private System.Windows.Forms.Button buttonCtrlV;
    }
}

