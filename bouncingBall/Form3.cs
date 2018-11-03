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
    public partial class Form3 : Form
    {
        int ballSize = 20;
        int ballX = 0;
        int ballY = 0;
        int mouseX = 0;
        int mouseY = 0;
        int dx = 3;
        int dy = 2;
        Graphics graphics;
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(myFunction);
            //form3timer.Start();   //timer is being start on  mouse click
        }
      
        private void myFunction(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillEllipse(Brushes.Green, 0, 0, 20, 20);
            // e.Graphics.FillEllipse(Brushes.Green, ballX,ballY, ballSize,ballSize); 
            graphics = e.Graphics;
            // e.Graphics.FillEllipse(Brushes.Green,ballX, ballY, ballSize, ballSize);//createBall()
             createBall(); //calling this in mouse click
        }
        private void createBall()
        {
            graphics.FillEllipse(Brushes.Green, ballX, ballY, ballSize, ballSize);
            //graphics.FillEllipse(Brushes.Green, a, b, ballSize, ballSize);
            
        }
        /*private void createBall(int mouse_x, int mouse_y)
        {
            graphics.FillEllipse(Brushes.Green,mouse_x, mouse_y, ballSize, ballSize);
        }*/

        private void incrementPos()
        {
            //ballX += 5;
           // ballY += 5;
            if (ballX< -2 || ballX > this.ClientSize.Width - ballSize) dx = -dx;
            if (ballY < -2 || ballY > this.ClientSize.Height - ballSize) dy = -dy;
            ballX += dx;
            ballY += dy;
        }
        private void form3timer_Tick(object sender, EventArgs e)
        {
            incrementPos();
            this.Refresh(); //redraw form
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            ballX = e.X;
            ballY = e.Y;
            if(!form3timer.Enabled)form3timer.Start();
            try
            {
                ThreadStart ts = new ThreadStart(createBall);
                Thread t1 = new Thread(ts);
                
            }
            catch (Exception ex){ }
        }
    }
}
