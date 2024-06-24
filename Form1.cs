using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Enums;
using static System.Net.Mime.MediaTypeNames;
namespace TicTacToe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.pictureBoxes = new PictureBox[3, 3]
               {
               {pb1,pb2,pb3},
               {pb4,pb5,pb6},
               {pb7,pb8,pb9}
               };
            gameSize = 3;
        }
        public void InitPictureBoxes()
            {
            foreach (var pb in pictureBoxes.Cast<PictureBox>())
            {
                pb.Image = Properties.Resources.QuestionMark;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = PlayerChoice.None;
            }
        }

        private void InitCurrentPlayer(Turn player)
        {
            this.currentPlayer = player;
        }
        private Bitmap GetCurrentPlayerImage()
        {
            Bitmap image = null ;
            if (currentPlayer is Turn.Player_1)
                image = Properties.Resources.XMark;
            else
                image = Properties.Resources.OMark;
            return image;
        }
        private void GameFinishMessageBox(GameWinner gameResult)
        {
            switch(gameResult)
            {
                case GameWinner.Player_1:
                case GameWinner.Player_2:
                    MessageBox.Show($"{FormatString(gameResult.ToString())} is the winner !", "Win !!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case GameWinner.Draw:
                    MessageBox.Show($"There is no winner its Draw !", "Draw !!"
                      , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

            }
        }
        private bool IsAlreadyPicked(PictureBox pb) => GetPlayerChoiceFromPictureBox(pb) != PlayerChoice.None; // picked

        public static PlayerChoice GetPlayerChoiceFromPictureBox(PictureBox pb) => (PlayerChoice)pb.Tag; 
        private PlayerChoice GetPlayerChoice() => currentPlayer == Turn.Player_1 ?
                                                 PlayerChoice.X : PlayerChoice.O;
        private void IncrementPickedCounter() => picked++;
        private void PickPictureBox(PictureBox pb,PlayerChoice playerChoice) => pb.Tag = playerChoice;
        private void SwitchToPlayer1()
        {
            this.lblTurnAnswer.ForeColor = Color.Green;
        }
        private void SwitchToPlayer2()
        {
            this.lblTurnAnswer.ForeColor = Color.Blue;
        }
        private void SwitchToGameOver()
        {
            this.lblTurnAnswer.ForeColor = Color.Red;
        }
        private string FormatString(string str)
        {
            var tmp = str.Split('_');
            return String.Join(" ", tmp);
        }
        private void SwitchTurnToPlayerX(Turn playerTurn)
        {
            this.lblTurnAnswer.Text = FormatString(playerTurn.ToString());
            switch (playerTurn) 
            {
                case Turn.Player_1:
                    SwitchToPlayer1();
                    break;
                case Turn.Player_2:
                    SwitchToPlayer2();
                    break;
                case Turn.Game_Over:
                    SwitchToGameOver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(playerTurn));
            }
        }

        private void UpdateCurrentPlayer()
        {
            currentPlayer = currentPlayer == Turn.Player_1 ? Turn.Player_2 : Turn.Player_1;
            SwitchTurnToPlayerX(currentPlayer);
        }

        private void Draw()
        {
            this.lblWinnerAnswer.ForeColor = Color.Gold;
            this.lblWinnerAnswer.Text = GameWinner.Draw.ToString();
            this.GameFinishMessageBox(GameWinner.Draw);
        }

        private void Win()
        {
            this.lblWinnerAnswer.ForeColor = Color.Red;
            this.lblWinnerAnswer.Text = FormatString(this.currentPlayer.ToString());
            this.GameFinishMessageBox((GameWinner)(currentPlayer));
        }
        private void InProgress() => this.lblWinnerAnswer.ForeColor = Color.Green;
        private void SwitchGameWinner(GameWinner gameWinner)
        {
            this.lblWinnerAnswer.Text=FormatString(gameWinner.ToString());
            switch(gameWinner)
            {
                case GameWinner.Player_1:
                case GameWinner.Player_2:
                    Win();
                    break;
                case GameWinner.Draw:
                    Draw();
                    break;
                case GameWinner.In_Progress:
                    InProgress();
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var player = (Turn)rnd.Next(0, 2);
            SwitchTurnToPlayerX(player);
            InitCurrentPlayer(player);
            SwitchGameWinner(GameWinner.In_Progress);
            InitPictureBoxes();
            AttachPicturBoxChangedToEvents();
            picked = 0;
        }

       

        private void PictureBoxChanged(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if(pb is null)
                throw new ArgumentNullException(nameof(pb));
            if (IsAlreadyPicked(pb)) // ischanged
                return;

            pb.Image = GetCurrentPlayerImage(); 
            PickPictureBox(pb,GetPlayerChoice());
            IncrementPickedCounter();
            bool thereIsWinner = Gamechecker.CheckGame(pb, this.pictureBoxes);
            if (thereIsWinner)
                Win();
            else if (picked == Math.Pow(gameSize,2))
                Draw();
            else
                UpdateCurrentPlayer();

        }

        private void AttachPicturBoxChangedToEvents() => pictureBoxes.Cast<PictureBox>().
                                                      ToList().ForEach(pb => pb.Click += PictureBoxChanged);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            pen.Width = 8;
            e.Graphics.DrawLine(pen,400,80,400,400);
            e.Graphics.DrawLine(pen, 570, 80, 570, 400);
            e.Graphics.DrawLine(pen, 260, 180, 715, 180);
            e.Graphics.DrawLine(pen, 260, 300, 715, 300);



        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            Form1_Load(sender,e);
        }

    
    }
}
