using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncingBall
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Color pen_color = Color.Blue;
        int newball_x, newball_y;
        int ballSize = 20;
        Graphics graphics;
        int x = 150;
        int y = 100;
        int dx = 3;
        int dy = 2;
        private int flag=0;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(paintBall);
            this.DoubleBuffered = true;

        }

        private void paintBall(object sender, PaintEventArgs e)
        {
            if (flag == 1)
            {
                graphics = e.Graphics;
                SolidBrush blueBallBrush = new SolidBrush(pen_color);
                //graphics.FillEllipse(blueBallBrush,x,y,20,20);
                graphics.FillEllipse(blueBallBrush, x, y, ballSize, ballSize);
                toolStripStatusLabel2.Text = "x: " + x + " y: " + y;
            }
        }
        private void MoveBall()
        {
            newball_x = x + dx;
            newball_y = y + dy;
            if (newball_x < -2 || newball_x > this.ClientSize.Width-ballSize) dx = -dx;
            if (newball_y < -2 || newball_y > this.ClientSize.Height-ballSize-25) dy = -dy;
            x += dx;
            y += dy;
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer.Interval = 10;
            timer.Tick += mytick;
            timer.Start();
            

        }

        private void mytick(object sender, EventArgs e)
        {
            MoveBall();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("you clicked mouse in Form1 at position x= " + e.X + " and Y = " + e.Y);
                x = e.X;
                y = e.Y;
                flag = 1;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Stop();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Start();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballSize += 5;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = Color.DarkRed;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = Color.DarkBlue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = Color.DarkGreen;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dx+=3;
            //dy+=2;
            newball_x+=3;
            newball_y+=2;
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballSize -= 5;
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newball_y -= 2;
            newball_x -= 3;
        }
    }
}
