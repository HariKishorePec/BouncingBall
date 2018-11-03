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
    public partial class Form5 : Form
    {
        Graphics graphics;
        int x = 0;
         int n = 100;
        int ballNo=0;
        int []ballX=new int[100];
        int []ballY = new int[100];
        int dy = 2;
        int dx = 3;
        int ballSize = 20;
        Rectangle[] rects = new Rectangle[100];   //Rectangle[] rectangles = new Rectangle[100];
        public Form5()
        {
            InitializeComponent();
        }
       
        
        private void Form5_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            
            Random r = new Random();
            
        }
        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
            
            ballX[ballNo] = e.X;
            ballY[ballNo] = e.Y;
            rects[ballNo] = new Rectangle(ballX[ballNo],ballY[ballNo], ballSize,ballSize);
            this.Paint += new PaintEventHandler(createball);
            ballNo++;
              
        }

        private void createball(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < ballNo; i++)
            {
                
                e.Graphics.FillEllipse(Brushes.BlueViolet, rects[i]);
                
            }
        }

        private void timerForm5_Tick(object sender, EventArgs e)
        {
            this.Refresh();
           // for (int i = 0; i < ballNo; i++) incrementPos(i); //not working
        }

        private void incrementPos(int i)//3
        {
            //for (int i = 0; i < ballNo; i++)
            //{
                if (ballX[i] < -2 || ballX[i] > this.ClientSize.Width - ballSize) dx = -dx;
                if (ballY[i] < -2 || ballY[i] > this.ClientSize.Height - ballSize) dy = -dy;
                ballX[i] += dx;
                ballY[i] += dy;
            //}
        }
    }
}
