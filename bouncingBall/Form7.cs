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
    public partial class Form7 : Form
    {
        Thread t1;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_MouseClick(object sender, MouseEventArgs e)
        {
            //this.CreateGraphics().DrawEllipse(Pens.Blue, new Rectangle(e.X, e.Y, 20, 20));
            this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue,2), new Rectangle(e.X, e.Y, 20, 20));//adding width to balls
            t1 = new Thread(moveball);
        }

        private void moveball()
        {
            for (int i = 0; i < 100; i++)
            {

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
