﻿namespace SharpPaint
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
            this.labelMousePositon = new System.Windows.Forms.Label();
            this.panelMainPaint = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonHotSpot = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.AllowDrop = true;
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // labelMousePositon
            // 
            this.labelMousePositon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMousePositon.Location = new System.Drawing.Point(0, 561);
            this.labelMousePositon.Name = "labelMousePositon";
            this.labelMousePositon.Size = new System.Drawing.Size(85, 16);
            this.labelMousePositon.TabIndex = 0;
            this.labelMousePositon.Text = "Te";
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
            // buttonHotSpot
            // 
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
    }
}

