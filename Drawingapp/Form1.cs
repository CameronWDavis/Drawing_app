using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawingapp
{
    public partial class Form1 : Form
    {

        public Point current = new Point();
        public Point old = new Point();


        public Graphics g;
        public Graphics graph;

        public Pen userPen = new Pen(Color.Black, 5);

        Bitmap tarp; 


        public Form1()
        {
            InitializeComponent();

            g = canvasPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            userPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            tarp = new Bitmap(canvasPanel.Width, canvasPanel.Height);

            graph = Graphics.FromImage(tarp);

            canvasPanel.BackgroundImage = tarp;
            canvasPanel.BackgroundImageLayout = ImageLayout.None;

            userPen.Width = (float)paintScale.Value;
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(userPen, old, current);
                graph.DrawLine(userPen, old, current);

                old = current;
            }
        }

        private Point mouseOffsetPos;
        private Boolean isMouseDown = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(e.X, e.Y);
                isMouseDown = true;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffsetPos.X, mouseOffsetPos.Y);
                this.Location = mousePos;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            userPen.Color = canvasPanel.BackColor; 
        }

        private void paintBrush_Click(object sender, EventArgs e)
        {
            userPen.Color = colorButton.BackColor;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                userPen.Color= cd.Color;
                colorButton.BackColor= cd.Color;    
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            graph.Clear(canvasPanel.BackColor);
            canvasPanel.Invalidate();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Png Files (*png) | *png";
            sf.DefaultExt = "png";
            sf.AddExtension = true;

            if(sf.ShowDialog() == DialogResult.OK)
            {
                tarp.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Png);

            }
        }

        private void paintScale_increment(object sender, EventArgs e)
        {
            userPen.Width = (float)paintScale.Value;
        }
    }
}
