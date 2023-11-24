namespace NexusImageProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackgorundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.virtualBackgroudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.applyVirtualBackgroudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.processImageToolStripMenuItem,
            this.subtractionToolStripMenuItem,
            this.cameraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem1,
            this.saveImageToolStripMenuItem});
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.loadImageToolStripMenuItem.Text = "Images";
            // 
            // loadImageToolStripMenuItem1
            // 
            this.loadImageToolStripMenuItem1.Name = "loadImageToolStripMenuItem1";
            this.loadImageToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.loadImageToolStripMenuItem1.Text = "Load Image";
            this.loadImageToolStripMenuItem1.Click += new System.EventHandler(this.loadImageToolStripMenuItem1_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // processImageToolStripMenuItem
            // 
            this.processImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCopyToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.processImageToolStripMenuItem.Name = "processImageToolStripMenuItem";
            this.processImageToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.processImageToolStripMenuItem.Text = "Process Image";
            // 
            // basicCopyToolStripMenuItem
            // 
            this.basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            this.basicCopyToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.basicCopyToolStripMenuItem.Text = "Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.colorInversionToolStripMenuItem.Text = "Invert";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem2,
            this.loadBackgorundToolStripMenuItem,
            this.subtractToolStripMenuItem});
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            // 
            // loadImageToolStripMenuItem2
            // 
            this.loadImageToolStripMenuItem2.Name = "loadImageToolStripMenuItem2";
            this.loadImageToolStripMenuItem2.Size = new System.Drawing.Size(208, 26);
            this.loadImageToolStripMenuItem2.Text = "Load Image";
            this.loadImageToolStripMenuItem2.Click += new System.EventHandler(this.loadImageToolStripMenuItem2_Click);
            // 
            // loadBackgorundToolStripMenuItem
            // 
            this.loadBackgorundToolStripMenuItem.Name = "loadBackgorundToolStripMenuItem";
            this.loadBackgorundToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.loadBackgorundToolStripMenuItem.Text = "Load Background";
            this.loadBackgorundToolStripMenuItem.Click += new System.EventHandler(this.loadBackgorundToolStripMenuItem_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.virtualBackgroudToolStripMenuItem,
            this.applyVirtualBackgroudToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(573, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(403, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // virtualBackgroudToolStripMenuItem
            // 
            this.virtualBackgroudToolStripMenuItem.Name = "virtualBackgroudToolStripMenuItem";
            this.virtualBackgroudToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.virtualBackgroudToolStripMenuItem.Text = "Select Virtual Backgroud";
            this.virtualBackgroudToolStripMenuItem.Click += new System.EventHandler(this.virtualBackgroudToolStripMenuItem_Click);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog4_FileOk);
            // 
            // applyVirtualBackgroudToolStripMenuItem
            // 
            this.applyVirtualBackgroudToolStripMenuItem.Name = "applyVirtualBackgroudToolStripMenuItem";
            this.applyVirtualBackgroudToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.applyVirtualBackgroudToolStripMenuItem.Text = "Apply Virtual Backgroud";
            this.applyVirtualBackgroudToolStripMenuItem.Click += new System.EventHandler(this.applyVirtualBackgroudToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " Nexus Project DIP & DLL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem processImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem loadBackgorundToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virtualBackgroudToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.ToolStripMenuItem applyVirtualBackgroudToolStripMenuItem;
    }
}

