using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Blue);
        Graphics g = null;


        private int centerX, centerY;
        private int startX, startY;
        private int endX, endY;

        private int myLength = 0;
        private int myAngle = 0;
        private int myNoLines = 0;
        private int myIncrements = 0;

        public Form1()
        {
            InitializeComponent();
            startX = panel1.Width / 2;
            startY = panel1.Height / 2;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();
            for(int i = 0; i < myNoLines; i++)
            {
                drawLine();
            }
            
        }

        private void drawLine()
        {
            Random random = new Random();
            myPen.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            myAngle = myAngle + int.Parse(angleText.Text);
            myLength = myLength + int.Parse(incremText.Text);

            endX = (int)(startX + Math.Cos(Math.PI * myAngle / 180) * myLength);
            endY = (int)(startY + Math.Sin(Math.PI * myAngle / 180) * myLength);

            Point[] points = {
                    new Point(startX, startY),
                    new Point(endX, endY)
                 };

            g.DrawLines(myPen, points);

            startX = endX;
            startY = endY;
        }

        private void draw_Click(object sender, EventArgs e)
        {
            myNoLines = int.Parse(noLinesText.Text);
            myLength = int.Parse(lengthText.Text);
            myAngle = int.Parse(angleText.Text);
            myIncrements = int.Parse(incremText.Text);

            startX = panel1.Width / 2;
            startY = panel1.Height / 2;
            panel1.Refresh();
        }

      
    }
}
 