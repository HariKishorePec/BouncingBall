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
    public partial class Form4 : Form
    {
        int n = 0;
        int ballX = 0;//2
        int ballY = 0;//2
        int ballSize = 20;//3
        int dy = 2;//3
        int dx = 3;//3
        int ballNO = 0;//4
        int []ballx = new int[10];//4
        int[] bally = new int[10];//4
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            n++;
            ballx[ballNO] = e.X;//4
            bally[ballNO] = e.Y;//4
            //ballX = e.X;//2
            //ballY = e.Y;//2
            this.Paint += new PaintEventHandler(mypaint);//1
        }

        private void mypaint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillEllipse(Brushes.Red, 30, 30, 20, 20);//1
            // e.Graphics.FillEllipse(Brushes.Red,ballX, ballY, 20, 20);//2
            /*for (int i = 0; i < ballNO; i++)
            {
                e.Graphics.FillEllipse(Brushes.Red, ballx[ballNO], bally[ballNO], ballSize, ballSize);//3
                incrementPos(ballNO);//3
            }*/
            for (int i = 0; i < n; i++)
            {
                e.Graphics.FillEllipse(Brushes.Red, ballx[i], bally[i], ballSize, ballSize);//3
                incrementPos(i);//3
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;//1

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();//1
        }

        private void incrementPos(int bn)//3
        {
            //ballX += 5;
            // ballY += 5;
            if (ballx[bn] < -2 || ballx[bn] > this.ClientSize.Width - ballSize) dx = -dx;
            if (bally[bn] < -2 || bally[bn] > this.ClientSize.Height - ballSize) dy = -dy;
            ballx[bn] += dx;
            bally[bn] += dy;
        }
    }
}
