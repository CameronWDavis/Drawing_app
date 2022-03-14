namespace Drawingapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.colorButton = new System.Windows.Forms.PictureBox();
            this.paintScale = new System.Windows.Forms.NumericUpDown();
            this.eraser = new System.Windows.Forms.PictureBox();
            this.paintBrush = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.TopPanel.Controls.Add(this.colorButton);
            this.TopPanel.Controls.Add(this.paintScale);
            this.TopPanel.Controls.Add(this.eraser);
            this.TopPanel.Controls.Add(this.paintBrush);
            this.TopPanel.Controls.Add(this.closeButton);
            this.TopPanel.Controls.Add(this.eraseButton);
            this.TopPanel.Controls.Add(this.saveButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 43);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorButton.Location = new System.Drawing.Point(142, 5);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(38, 35);
            this.colorButton.TabIndex = 0;
            this.colorButton.TabStop = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // paintScale
            // 
            this.paintScale.Location = new System.Drawing.Point(205, 20);
            this.paintScale.Name = "paintScale";
            this.paintScale.Size = new System.Drawing.Size(72, 20);
            this.paintScale.TabIndex = 0;
            this.paintScale.ValueChanged += new System.EventHandler(this.paintScale_increment);
            // 
            // eraser
            // 
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.Location = new System.Drawing.Point(73, -1);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(43, 43);
            this.eraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eraser.TabIndex = 0;
            this.eraser.TabStop = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // paintBrush
            // 
            this.paintBrush.Image = ((System.Drawing.Image)(resources.GetObject("paintBrush.Image")));
            this.paintBrush.Location = new System.Drawing.Point(3, 0);
            this.paintBrush.Name = "paintBrush";
            this.paintBrush.Size = new System.Drawing.Size(43, 42);
            this.paintBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paintBrush.TabIndex = 0;
            this.paintBrush.TabStop = false;
            this.paintBrush.Click += new System.EventHandler(this.paintBrush_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(774, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(661, 17);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(75, 23);
            this.eraseButton.TabIndex = 0;
            this.eraseButton.Text = "Erase";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(567, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 43);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(800, 407);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintBrush)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.NumericUpDown paintScale;
        private System.Windows.Forms.PictureBox eraser;
        private System.Windows.Forms.PictureBox paintBrush;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox colorButton;
    }
}

