using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Enums;

namespace TicTacToe
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblTurnAnswer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinnerAnswer = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.lblRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(436, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 53);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblTurn.Location = new System.Drawing.Point(106, 200);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(111, 46);
            this.lblTurn.TabIndex = 3;
            this.lblTurn.Text = "Turn";
            // 
            // lblTurnAnswer
            // 
            this.lblTurnAnswer.AutoSize = true;
            this.lblTurnAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnAnswer.ForeColor = System.Drawing.Color.White;
            this.lblTurnAnswer.Location = new System.Drawing.Point(85, 264);
            this.lblTurnAnswer.Name = "lblTurnAnswer";
            this.lblTurnAnswer.Size = new System.Drawing.Size(180, 46);
            this.lblTurnAnswer.TabIndex = 4;
            this.lblTurnAnswer.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblWinner.Location = new System.Drawing.Point(106, 334);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(159, 46);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "Winner";
            // 
            // lblWinnerAnswer
            // 
            this.lblWinnerAnswer.AutoSize = true;
            this.lblWinnerAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerAnswer.ForeColor = System.Drawing.Color.White;
            this.lblWinnerAnswer.Location = new System.Drawing.Point(85, 400);
            this.lblWinnerAnswer.Name = "lblWinnerAnswer";
            this.lblWinnerAnswer.Size = new System.Drawing.Size(180, 46);
            this.lblWinnerAnswer.TabIndex = 6;
            this.lblWinnerAnswer.Text = "Player 1";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::TicTacToe.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(53, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(227, 162);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Location = new System.Drawing.Point(884, 119);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(219, 138);
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Location = new System.Drawing.Point(624, 119);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(219, 138);
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Location = new System.Drawing.Point(373, 119);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(219, 138);
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Location = new System.Drawing.Point(373, 291);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(219, 138);
            this.pb4.TabIndex = 12;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Location = new System.Drawing.Point(624, 291);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(219, 138);
            this.pb5.TabIndex = 11;
            this.pb5.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Location = new System.Drawing.Point(884, 291);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(219, 138);
            this.pb6.TabIndex = 10;
            this.pb6.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Location = new System.Drawing.Point(373, 469);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(219, 138);
            this.pb7.TabIndex = 15;
            this.pb7.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Location = new System.Drawing.Point(624, 469);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(219, 138);
            this.pb8.TabIndex = 14;
            this.pb8.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Location = new System.Drawing.Point(884, 469);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(219, 138);
            this.pb9.TabIndex = 13;
            this.pb9.TabStop = false;
            // 
            // lblRestart
            // 
            this.lblRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lblRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRestart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.lblRestart.ForeColor = System.Drawing.Color.White;
            this.lblRestart.Location = new System.Drawing.Point(26, 460);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(301, 62);
            this.lblRestart.TabIndex = 16;
            this.lblRestart.Text = "Restart Game";
            this.lblRestart.UseVisualStyleBackColor = true;
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1142, 649);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.lblWinnerAnswer);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurnAnswer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private Label lblTurn;
        private Label lblTurnAnswer;
        private Label lblWinner;
        private Label lblWinnerAnswer;
        private PictureBox pb3;
        private PictureBox pb2;
        private PictureBox pb1;
        private PictureBox pb4;
        private PictureBox pb5;
        private PictureBox pb6;
        private PictureBox pb7;
        private PictureBox pb8;
        private PictureBox pb9;
        private PictureBox [,] pictureBoxes;
        private Turn currentPlayer;
        private Button lblRestart;
        int pickedCount;
        public static int GameSize;
    }
}

