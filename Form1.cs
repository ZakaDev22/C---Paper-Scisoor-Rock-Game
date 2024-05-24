using C____Paper_Scisoor_Rock_Game.Properties;
using System;

using System.Windows.Forms;

namespace C____Paper_Scisoor_Rock_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enGameOptions
        {
            Paper = 1, Scissor = 2, Rock = 3
        }



        short Player1, Computer1, Draw;
        short RoundNumber;

        void CHeckRoundResutl(enGameOptions player, enGameOptions computer)
        {


            if (player == enGameOptions.Paper && computer == enGameOptions.Paper)
            {
                Draw++;
                lbDraw.Text = Draw.ToString();
                pbRoundWinner.Image = Resources.Draw;
                return;
            }

            if (player == enGameOptions.Scissor && computer == enGameOptions.Scissor)
            {
                Draw++;
                lbDraw.Text = Draw.ToString();
                pbRoundWinner.Image = Resources.Draw;
                return;
            }

            if (player == enGameOptions.Rock && computer == enGameOptions.Rock)
            {
                Draw++;
                lbDraw.Text = Draw.ToString();
                pbRoundWinner.Image = Resources.Draw;
                return;
            }


            if (player == enGameOptions.Paper && computer == enGameOptions.Rock)
            {
                Player1++;
                lbPlayer1.Text = Player1.ToString();
                pbRoundWinner.Image = Resources.win5;
                return;
            }

            if (player == enGameOptions.Paper && computer == enGameOptions.Scissor)
            {
                Computer1++;
                lbComputer.Text = Computer1.ToString();
                pbRoundWinner.Image = Resources.Computer2;
                return;
            }

            if (player == enGameOptions.Rock && computer == enGameOptions.Scissor)
            {
                Player1++;
                lbPlayer1.Text = Player1.ToString();
                pbRoundWinner.Image = Resources.win5;
                return;
            }

            if (player == enGameOptions.Rock && computer == enGameOptions.Paper)
            {
                Computer1++;
                lbComputer.Text = Computer1.ToString();
                pbRoundWinner.Image = Resources.Computer2;
                return;
            }

            if (player == enGameOptions.Scissor && computer == enGameOptions.Paper)
            {
                Player1++;
                lbPlayer1.Text = Player1.ToString();
                pbRoundWinner.Image = Resources.win5;
                return;
            }


        }

        public void GameOver()
        {
            if (RoundNumber == 6)
            {
                if (Player1 == Computer1)
                {
                    pbWinner.Image = Resources.Draw;
                    MessageBox.Show("Draw", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Player1 > Computer1)
                {
                    pbWinner.Image = Resources.Win1;
                    MessageBox.Show("Player1 Win", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Player1 < Computer1)
                {
                    pbWinner.Image = Resources.Computer;
                    MessageBox.Show("Computer Win", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Paper_Click(object sender, MouseEventArgs e)
        {
            if (RoundNumber == 6)
            {
                MessageBox.Show("Click Restart Button To\nPlay Again.", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random RNumber = new Random();
            int Number = RNumber.Next(1, 3);

            switch (Number)
            {
                case 1:
                    CHeckRoundResutl(enGameOptions.Paper, enGameOptions.Paper);
                    break;

                case 2:
                    CHeckRoundResutl(enGameOptions.Paper, enGameOptions.Scissor);
                    break;

                case 3:
                    CHeckRoundResutl(enGameOptions.Paper, enGameOptions.Rock);
                    break;
            }

            RoundNumber++;

            lbRound.Text = RoundNumber.ToString();

            GameOver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoundNumber = 0;
            Draw = 0;
            Player1 = 0;
            Computer1 = 0;
            lbRound.Text = "0";
            lbComputer.Text = "0";
            lbDraw.Text = "0";
            lbPlayer1.Text = "0";
            pbWinner.Image = Resources.Progress3;
            pbRoundWinner.Image = Resources.images__5_;
        }

        private void lbRound_Click(object sender, EventArgs e)
        {

        }

        private void Scissor_Click(object sender, MouseEventArgs e)
        {
            if (RoundNumber == 6)
            {
                MessageBox.Show("Click Restart Button To\nPlay Again.", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random RNumber = new Random();
            int Number = RNumber.Next(1, 3);

            switch (Number)
            {
                case 1:
                    CHeckRoundResutl(enGameOptions.Scissor, enGameOptions.Paper);
                    break;

                case 2:
                    CHeckRoundResutl(enGameOptions.Scissor, enGameOptions.Scissor);
                    break;

                case 3:
                    CHeckRoundResutl(enGameOptions.Scissor, enGameOptions.Rock);
                    break;
            }

            RoundNumber++;
            lbRound.Text = RoundNumber.ToString();

            GameOver();
        }

        private void Rock_Click(object sender, MouseEventArgs e)
        {
            if (RoundNumber == 6)
            {
                MessageBox.Show("Click Restart Button \n To Play Again.", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random RNumber = new Random();
            int Number = RNumber.Next(1, 3);

            switch (Number)
            {
                case 1:
                    CHeckRoundResutl(enGameOptions.Rock, enGameOptions.Paper);
                    break;

                case 2:
                    CHeckRoundResutl(enGameOptions.Rock, enGameOptions.Scissor);
                    break;

                case 3:
                    CHeckRoundResutl(enGameOptions.Rock, enGameOptions.Rock);
                    break;
            }

            RoundNumber++;
            lbRound.Text = RoundNumber.ToString();

            GameOver();
        }
    }
}
