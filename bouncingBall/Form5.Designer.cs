﻿namespace bouncingBall
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerForm5 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerForm5
            // 
            this.timerForm5.Enabled = true;
            this.timerForm5.Interval = 50;
            this.timerForm5.Tick += new System.EventHandler(this.timerForm5_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form5";
            this.Text = "multiple balls";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerForm5;
    }
}