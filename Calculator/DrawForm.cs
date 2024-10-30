using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g= e.Graphics;
            Pen myPen = new Pen(Color.Pink, 2);
            g.DrawLine(myPen, 0, 0, 100,100);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PicturBox_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics; 
            Rectangle rect1 = new Rectangle(10, 10, 50, 50);
            Rectangle rect2 = new Rectangle(60, 60, 80, 100);
            // Solid brush example
            SolidBrush Brush1 = new SolidBrush(Color.Aquamarine);
            g.FillRectangle(Brush1, rect1);
            // Linear gradient brush example (need using Drawing2D)‏
            LinearGradientBrush Brush2 = new LinearGradientBrush(rect2, Color.Tan,
            Color.SandyBrown, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(Brush2, rect2);


        }
    }
}
