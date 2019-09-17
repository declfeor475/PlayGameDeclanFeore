using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// Created by Declan Feore
/// September 2019
/// Basic starting screen for a game 
/// </summary>

namespace PlayGameDeclanFeore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //graphics setting
            Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.BlueViolet, 7);
            Font titleFont = new Font("Comic Sans", 32);
            SolidBrush titleBrush = new SolidBrush(Color.BlueViolet);

            //title screen
            g.Clear(Color.Black);
            g.DrawRectangle(titlePen, 240, 140, 250, 80);
            g.DrawString("Play Game", titleFont, titleBrush, 250, 150);
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            //graphics setting
            Graphics g = this.CreateGraphics();
            Font numberFont = new Font("Comic Sans", 32);
            SolidBrush numberBrush = new SolidBrush(Color.BlueViolet);
            SoundPlayer beepSound = new SoundPlayer(Properties.Resources.Beep);
            SoundPlayer goSound = new SoundPlayer(Properties.Resources.Go);

            //frame 1
            g.Clear(Color.Black);
            g.DrawString("3", numberFont, numberBrush, 350, 150);
            beepSound.Play();

            Thread.Sleep(1000);

            //frame 2
            g.Clear(Color.Black);
            g.DrawString("2", numberFont, numberBrush, 350, 150);
            beepSound.Play();

            Thread.Sleep(1000);

            //frame 3
            g.Clear(Color.Black);
            g.DrawString("1", numberFont, numberBrush, 350, 150);
            beepSound.Play();

            Thread.Sleep(1000);

            //frame 4
            g.Clear(Color.Green);
            g.DrawString("GO!", numberFont, numberBrush, 325, 150);
            goSound.Play();
        }
    }
}
