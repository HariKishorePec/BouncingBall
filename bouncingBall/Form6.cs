using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace bouncingBall
{
    public partial class Form6 : Form
    {
        Thread th;
        Thread th2;
        Random rnd;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }

        private void thread()
        {
            for(int i = 0; i < 50; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red,4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("Red completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th2 = new Thread(threadb);
            th2.Start();
        }

        private void threadb()
        {
            for (int i = 0; i < 50; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("Blue completed");
        }
    }
}
