using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class gameForm : Form
    {

        public int speedLeft = 4;
        public int speerTop = 4;
        public int points = 0;

        public gameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            racket.Top = playGround.Bottom - (playGround.Bottom / 10);

            gameOverLbl.Left = (playGround.Width / 2) - (gameOverLbl.Width / 2);
            gameOverLbl.Top = (playGround.Height / 2) - (gameOverLbl.Height / 2);

            gameOverLbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speedLeft;
            ball.Top += speerTop;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speerTop += 2;
                speedLeft += 2;
                speerTop = -speerTop;
                points += 1;
                pointLbl.Text = points.ToString();

                Random r = new Random();

              
                playGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
             

            }

            if (ball.Left <= playGround.Left)
            {
                speedLeft = -speedLeft;
            }
            if (ball.Right >= playGround.Right)
            {
                speedLeft = -speedLeft;
            }
            if (ball.Top <= playGround.Top)
            {
                speerTop = -speerTop;
            }
            if (ball.Bottom >= playGround.Bottom)
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
            }

        }

        private void gameForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speedLeft = 4;
                speerTop = 4;
                pointLbl.Text = "0";
                timer1.Enabled = true;
                gameOverLbl.Visible = false;
                playGround.BackColor = Color.White;
                points = 0;
            }
        }
  
            }
}
