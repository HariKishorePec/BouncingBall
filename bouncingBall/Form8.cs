using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncingBall
{
    public partial class Form8 : Form
    {
        Point[] points = new Point[100];//1
        int ballNo = 0;//1
        int dx = 3;
        int dy = 2;
        Thread t1;
        Thread[] threads = new Thread[100];
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Form8_MouseClick(object sender, MouseEventArgs e)
        {
            points[ballNo].X = e.X;//1
            points[ballNo].Y = e.Y;//1
            //this.CreateGraphics().FillEllipse(Brushes.DarkBlue, points[ballNo].X, points[ballNo].Y, 20, 20);//1
           // moveBall(ballNo);
            //t1 = new Thread(new ParameterizedThreadStart(moveBall));//Error, takes object as param and not integer
           // t1 = new Thread(new ParameterizedThreadStart(moveBall));
            //t1.Start(ballNo);
            threads[ballNo] = new Thread(new ParameterizedThreadStart(moveBall));
            threads[ballNo].Start(ballNo);
            ballNo++;
        }

        private void moveBall(Object obj)//change int bn to object obj
        {
            int bn = (int)obj;
            int temp = 0;
            while (temp < 10000)
            {
                if (points[bn].X < -2 || points[bn].X > this.ClientSize.Width) dx = -dx;
                if (points[bn].Y < -2 || points[bn].Y > this.ClientSize.Height) dy = -dy;
                points[bn].X += dx;
                points[bn].Y += dy;
               // this.Refresh();
                base.CreateGraphics().FillEllipse(Brushes.DarkBlue, points[bn].X, points[bn].Y, 20, 20);
                Thread.Sleep(10);
                temp++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///this.Refresh();
        }
    }
}
