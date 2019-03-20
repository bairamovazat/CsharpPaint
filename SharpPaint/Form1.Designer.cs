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
            this.buttonCtrlZ = new System.Windows.Forms.Button();
            this.buttonCtrlV = new System.Windows.Forms.Button();
            this.buttonCtrlC = new System.Windows.Forms.Button();
            this.button20px = new System.Windows.Forms.Button();
            this.button10px = new System.Windows.Forms.Button();
            this.button5px = new System.Windows.Forms.Button();
            this.button1px = new System.Windows.Forms.Button();
            this.buttonDeepSkyBlue = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonHotSpot = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.panelMainPaint = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonViolet = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.labelMousePositon = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCtrlZ
            // 
            this.buttonCtrlZ.Location = new System.Drawing.Point(14, 518);
            this.buttonCtrlZ.Name = "buttonCtrlZ";
            this.buttonCtrlZ.Size = new System.Drawing.Size(56, 26);
            this.buttonCtrlZ.TabIndex = 17;
            this.buttonCtrlZ.Text = "Ctrl + Z";
            this.buttonCtrlZ.UseVisualStyleBackColor = true;
            this.buttonCtrlZ.Visible = false;
            this.buttonCtrlZ.Click += new System.EventHandler(this.buttonCtrlZ_Click);
            // 
            // buttonCtrlV
            // 
            this.buttonCtrlV.Location = new System.Drawing.Point(14, 486);
            this.buttonCtrlV.Name = "buttonCtrlV";
            this.buttonCtrlV.Size = new System.Drawing.Size(56, 26);
            this.buttonCtrlV.TabIndex = 16;
            this.buttonCtrlV.Text = "Ctrl + V";
            this.buttonCtrlV.UseVisualStyleBackColor = true;
            this.buttonCtrlV.Visible = false;
            this.buttonCtrlV.Click += new System.EventHandler(this.buttonCtrlV_Click);
            // 
            // buttonCtrlC
            // 
            this.buttonCtrlC.Location = new System.Drawing.Point(14, 454);
            this.buttonCtrlC.Name = "buttonCtrlC";
            this.buttonCtrlC.Size = new System.Drawing.Size(56, 26);
            this.buttonCtrlC.TabIndex = 15;
            this.buttonCtrlC.Text = "Ctrl + C";
            this.buttonCtrlC.UseVisualStyleBackColor = true;
            this.buttonCtrlC.Visible = false;
            this.buttonCtrlC.Click += new System.EventHandler(this.buttonCtrlC_Click);
            // 
            // button20px
            // 
            this.button20px.Location = new System.Drawing.Point(13, 402);
            this.button20px.Name = "button20px";
            this.button20px.Size = new System.Drawing.Size(56, 26);
            this.button20px.TabIndex = 14;
            this.button20px.Text = "20px";
            this.button20px.UseVisualStyleBackColor = true;
            this.button20px.Click += new System.EventHandler(this.button20px_Click);
            // 
            // button10px
            // 
            this.button10px.Location = new System.Drawing.Point(13, 370);
            this.button10px.Name = "button10px";
            this.button10px.Size = new System.Drawing.Size(56, 26);
            this.button10px.TabIndex = 13;
            this.button10px.Text = "10px";
            this.button10px.UseVisualStyleBackColor = true;
            this.button10px.Click += new System.EventHandler(this.button10px_Click);
            // 
            // button5px
            // 
            this.button5px.Location = new System.Drawing.Point(13, 338);
            this.button5px.Name = "button5px";
            this.button5px.Size = new System.Drawing.Size(56, 26);
            this.button5px.TabIndex = 12;
            this.button5px.Text = "5px";
            this.button5px.UseVisualStyleBackColor = true;
            this.button5px.Click += new System.EventHandler(this.button5px_Click);
            // 
            // button1px
            // 
            this.button1px.Location = new System.Drawing.Point(13, 306);
            this.button1px.Name = "button1px";
            this.button1px.Size = new System.Drawing.Size(56, 26);
            this.button1px.TabIndex = 11;
            this.button1px.Text = "1px";
            this.button1px.UseVisualStyleBackColor = true;
            this.button1px.Click += new System.EventHandler(this.button1px_Click);
            // 
            // buttonDeepSkyBlue
            // 
            this.buttonDeepSkyBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDeepSkyBlue.Location = new System.Drawing.Point(43, 222);
            this.buttonDeepSkyBlue.Name = "buttonDeepSkyBlue";
            this.buttonDeepSkyBlue.Size = new System.Drawing.Size(26, 26);
            this.buttonDeepSkyBlue.TabIndex = 10;
            this.buttonDeepSkyBlue.UseVisualStyleBackColor = false;
            this.buttonDeepSkyBlue.Click += new System.EventHandler(this.buttonDeepSkyBlue_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(43, 126);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(26, 26);
            this.buttonWhite.TabIndex = 9;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(13, 158);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(26, 26);
            this.buttonRed.TabIndex = 8;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBlack.Location = new System.Drawing.Point(13, 126);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(26, 26);
            this.buttonBlack.TabIndex = 7;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonHotSpot
            // 
            this.buttonHotSpot.Image = ((System.Drawing.Image)(resources.GetObject("buttonHotSpot.Image")));
            this.buttonHotSpot.Location = new System.Drawing.Point(43, 77);
            this.buttonHotSpot.Name = "buttonHotSpot";
            this.buttonHotSpot.Size = new System.Drawing.Size(26, 26);
            this.buttonHotSpot.TabIndex = 6;
            this.buttonHotSpot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHotSpot.UseVisualStyleBackColor = true;
            this.buttonHotSpot.Click += new System.EventHandler(this.buttonHotSpot_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(13, 77);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(26, 26);
            this.buttonRectangle.TabIndex = 5;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.Location = new System.Drawing.Point(43, 48);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(26, 26);
            this.buttonEllipse.TabIndex = 4;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.Location = new System.Drawing.Point(13, 48);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(26, 26);
            this.buttonLine.TabIndex = 3;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Image = ((System.Drawing.Image)(resources.GetObject("buttonEraser.Image")));
            this.buttonEraser.Location = new System.Drawing.Point(43, 19);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(26, 26);
            this.buttonEraser.TabIndex = 2;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPencil.Image")));
            this.buttonPencil.Location = new System.Drawing.Point(13, 19);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(26, 26);
            this.buttonPencil.TabIndex = 1;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
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
            this.panelMainPaint.Size = new System.Drawing.Size(497, 537);
            this.panelMainPaint.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonViolet);
            this.groupBox1.Controls.Add(this.buttonGreen);
            this.groupBox1.Controls.Add(this.buttonYellow);
            this.groupBox1.Controls.Add(this.buttonBlue);
            this.groupBox1.Controls.Add(this.buttonOrange);
            this.groupBox1.Controls.Add(this.labelMousePositon);
            this.groupBox1.Controls.Add(this.buttonCtrlZ);
            this.groupBox1.Controls.Add(this.buttonCtrlV);
            this.groupBox1.Controls.Add(this.buttonPencil);
            this.groupBox1.Controls.Add(this.buttonCtrlC);
            this.groupBox1.Controls.Add(this.buttonEraser);
            this.groupBox1.Controls.Add(this.button20px);
            this.groupBox1.Controls.Add(this.buttonLine);
            this.groupBox1.Controls.Add(this.button10px);
            this.groupBox1.Controls.Add(this.buttonEllipse);
            this.groupBox1.Controls.Add(this.button5px);
            this.groupBox1.Controls.Add(this.buttonRectangle);
            this.groupBox1.Controls.Add(this.button1px);
            this.groupBox1.Controls.Add(this.buttonHotSpot);
            this.groupBox1.Controls.Add(this.buttonDeepSkyBlue);
            this.groupBox1.Controls.Add(this.buttonBlack);
            this.groupBox1.Controls.Add(this.buttonWhite);
            this.groupBox1.Controls.Add(this.buttonRed);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonViolet
            // 
            this.buttonViolet.BackColor = System.Drawing.Color.Violet;
            this.buttonViolet.Location = new System.Drawing.Point(13, 254);
            this.buttonViolet.Name = "buttonViolet";
            this.buttonViolet.Size = new System.Drawing.Size(26, 26);
            this.buttonViolet.TabIndex = 23;
            this.buttonViolet.UseVisualStyleBackColor = false;
            this.buttonViolet.Click += new System.EventHandler(this.buttonViolet_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(43, 190);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(26, 26);
            this.buttonGreen.TabIndex = 22;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonYellow.Location = new System.Drawing.Point(12, 190);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(26, 26);
            this.buttonYellow.TabIndex = 19;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(13, 222);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(26, 26);
            this.buttonBlue.TabIndex = 21;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOrange.Location = new System.Drawing.Point(43, 158);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(26, 26);
            this.buttonOrange.TabIndex = 20;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // labelMousePositon
            // 
            this.labelMousePositon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMousePositon.Location = new System.Drawing.Point(3, 511);
            this.labelMousePositon.Name = "labelMousePositon";
            this.labelMousePositon.Size = new System.Drawing.Size(77, 23);
            this.labelMousePositon.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMainPaint);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMainPaint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonHotSpot;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button button1px;
        private System.Windows.Forms.Button buttonDeepSkyBlue;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button button20px;
        private System.Windows.Forms.Button button10px;
        private System.Windows.Forms.Button button5px;
        private System.Windows.Forms.Button buttonCtrlC;
        private System.Windows.Forms.Button buttonCtrlZ;
        private System.Windows.Forms.Button buttonCtrlV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMousePositon;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonViolet;
    }
}

