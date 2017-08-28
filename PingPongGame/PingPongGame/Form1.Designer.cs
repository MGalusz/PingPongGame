namespace PingPongGame
{
    partial class gameForm
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
            this.playGround = new System.Windows.Forms.Panel();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.ScorLbl = new System.Windows.Forms.Label();
            this.pointLbl = new System.Windows.Forms.Label();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.gameOverLbl);
            this.playGround.Controls.Add(this.pointLbl);
            this.playGround.Controls.Add(this.ScorLbl);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(715, 511);
            this.playGround.TabIndex = 0;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(220, 463);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(142, 19);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Crimson;
            this.ball.Location = new System.Drawing.Point(122, 352);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 14);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // ScorLbl
            // 
            this.ScorLbl.AutoSize = true;
            this.ScorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScorLbl.Location = new System.Drawing.Point(3, 9);
            this.ScorLbl.Name = "ScorLbl";
            this.ScorLbl.Size = new System.Drawing.Size(189, 55);
            this.ScorLbl.TabIndex = 3;
            this.ScorLbl.Text = "Sroce : ";
            // 
            // pointLbl
            // 
            this.pointLbl.AutoSize = true;
            this.pointLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointLbl.Location = new System.Drawing.Point(178, 9);
            this.pointLbl.Name = "pointLbl";
            this.pointLbl.Size = new System.Drawing.Size(51, 55);
            this.pointLbl.TabIndex = 4;
            this.pointLbl.Text = "0";
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOverLbl.Location = new System.Drawing.Point(249, 44);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(273, 187);
            this.gameOverLbl.TabIndex = 5;
            this.gameOverLbl.Text = "Game Over!\r\n\r\nF1 - Restart Game\r\n\r\nEsc- Exit\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 511);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gameForm_PreviewKeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label pointLbl;
        private System.Windows.Forms.Label ScorLbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
    }
}

