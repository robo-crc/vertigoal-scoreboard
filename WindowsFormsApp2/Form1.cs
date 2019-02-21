using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Vertigoal : Form
    {


        public Vertigoal()
        {
            InitializeComponent();
            this.timeLeft = 300;
        }
        // lower tower
        private void LowerTopTowerYellow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.YellowLowerTopScore = TowerScore(false, this.YellowLowerTopScore, this.LowerTopRedMultiply, this.LowerTopTowerYellow, 40);
            }

            else
            {
                this.YellowLowerTopScore = TowerScore(true, this.YellowLowerTopScore, this.LowerTopRedMultiply, this.LowerTopTowerYellow, 40);
            }
            updateYellowScore();
        }

        private void LowerTopTowerBlue_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BlueLowerTopScore = TowerScore(false, this.BlueLowerTopScore, this.LowerTopRedMultiply, this.LowerTopTowerBlue, 40);
            }

            else
            {
                this.BlueLowerTopScore = TowerScore(true, this.BlueLowerTopScore, this.LowerTopRedMultiply, this.LowerTopTowerBlue, 40);
            }
            updateBlueScore();
        }

        private void LowerBotTowerYellow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.YellowLowerBotScore = TowerScore(false, this.YellowLowerBotScore, this.LowerBotRedMultiply, this.LowerBotTowerYellow, 20);
            }

            else
            {
                this.YellowLowerBotScore = TowerScore(true, this.YellowLowerBotScore, this.LowerBotRedMultiply, this.LowerBotTowerYellow, 20);
            }
            updateYellowScore();

        }

        private void LowerBotTowerBlue_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BlueLowerBotScore = TowerScore(false, this.BlueLowerBotScore, this.LowerBotRedMultiply, this.LowerBotTowerBlue, 20);
            }

            else
            {
                this.BlueLowerBotScore = TowerScore(true, this.BlueLowerBotScore, this.LowerBotRedMultiply, this.LowerBotTowerBlue, 20);
            }
            updateBlueScore();

        }

        // Box
        private void TopBoxYellow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.YellowTopBoxScore = TowerScore(false, this.YellowTopBoxScore, this.TopBoxRedMultipy, this.TopBoxYellow, 10);
            }

            else
            {
                this.YellowTopBoxScore = TowerScore(true, this.YellowTopBoxScore, this.TopBoxRedMultipy, this.TopBoxYellow, 10);
            }
            updateYellowScore();

        }

        private void TopBoxBlue_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                this.BlueTopBoxScore = TowerScore(false, this.BlueTopBoxScore, this.TopBoxRedMultipy, this.TopBoxBlue, 10);
            }

            else
            {
                this.BlueTopBoxScore = TowerScore(true, this.BlueTopBoxScore, this.TopBoxRedMultipy, this.TopBoxBlue, 10);
            }
            updateBlueScore();
        }

        private void BotBoxYellow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.YellowBotBoxScore = TowerScore(false, this.YellowBotBoxScore, this.BotBoxRedMultiply, this.BotBoxYellow, 10);
            }

            else
            {
                this.YellowBotBoxScore = TowerScore(true, this.YellowBotBoxScore, this.BotBoxRedMultiply, this.BotBoxYellow, 10);
            }
            updateYellowScore();
        }

        private void BotBoxBlue_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BlueBotBoxScore = TowerScore(false, this.BlueBotBoxScore, this.BotBoxRedMultiply, this.BotBoxBlue, 10);
            }

            else
            {
                this.BlueBotBoxScore = TowerScore(true, this.BlueBotBoxScore, this.BotBoxRedMultiply, this.BotBoxBlue, 10);
            }
            updateBlueScore();
        }


        //upper tower
        private void UpperTopTowerYellow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.YellowUpperTopScore = TowerScore(false, this.YellowUpperTopScore, this.UpperTopRedMultiply, this.UpperTopTowerYellow, 40);
            }

            else
            {
                this.YellowUpperTopScore = TowerScore(true, this.YellowUpperTopScore, this.UpperTopRedMultiply, this.UpperTopTowerYellow, 40);
            }
            updateYellowScore();
        }

        private void UpperTopTowerBlue_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BlueUpperTopScore = TowerScore(false, this.BlueUpperTopScore, this.UpperTopRedMultiply, this.UpperTopTowerBlue, 40);
            }

            else
            {
                this.BlueUpperTopScore = TowerScore(true, this.BlueUpperTopScore, this.UpperTopRedMultiply, this.UpperTopTowerBlue, 40);
            }
            updateBlueScore();
        }

        private void UpperBotTowerYellow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.YellowUpperBotScore = TowerScore(false, this.YellowUpperBotScore, this.UpperBotRedMultiply, this.UpperBotTowerYellow, 20);
            }

            else
            {
                this.YellowUpperBotScore = TowerScore(true, this.YellowUpperBotScore, this.UpperBotRedMultiply, this.UpperBotTowerYellow, 20);
            }
            updateYellowScore();
        }


        private void UpperBotTowerBlue_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BlueUpperBotScore = TowerScore(false, this.BlueUpperBotScore, this.UpperBotRedMultiply, this.UpperBotTowerBlue, 20);
            }

            else
            {
                this.BlueUpperBotScore = TowerScore(true, this.BlueUpperBotScore, this.UpperBotRedMultiply, this.UpperBotTowerBlue, 20);
            }
            updateBlueScore();
        }

        private int TowerScore(bool add, int score, bool multiply, Label scoreLabel, int increment)
        {
            if (add == false)
            {
                if (score > 0)
                {
                    score = score - increment;
                    if (multiply)
                    {
                        int interimScore = score * 2;
                        scoreLabel.Text = interimScore.ToString();
                    }
                    else
                    {
                        scoreLabel.Text = score.ToString();
                    }
                }
            }

            else
            {
                score = score + increment;
                if (multiply)
                {
                    int interimScore = score * 2;
                    scoreLabel.Text = interimScore.ToString();
                }
                else
                {
                    scoreLabel.Text = score.ToString();
                }

            }
            return score;

        }

        private void updateBlueScore()
        {
            int score = Convert.ToInt32(LowerTopTowerBlue.Text) + Convert.ToInt32(LowerBotTowerBlue.Text) + Convert.ToInt32(TopBoxBlue.Text) + Convert.ToInt32(BotBoxBlue.Text) + Convert.ToInt32(UpperTopTowerBlue.Text) + Convert.ToInt32(UpperBotTowerBlue.Text);
            BlueScore.Text = score.ToString();
            BlueOneScore.Text = (score - Convert.ToInt32(BlueOnePenalty.Value)).ToString();
            BlueTwoScore.Text = (score - Convert.ToInt32(BlueTwoPenalty.Value)).ToString();
        }

        private void updateYellowScore()
        {
            int score = Convert.ToInt32(LowerTopTowerYellow.Text) + Convert.ToInt32(LowerBotTowerYellow.Text) + Convert.ToInt32(TopBoxYellow.Text) + Convert.ToInt32(BotBoxYellow.Text) + Convert.ToInt32(UpperTopTowerYellow.Text) + Convert.ToInt32(UpperBotTowerYellow.Text);
            YellowScore.Text = score.ToString();
            YellowOneScore.Text = (score - Convert.ToInt32(YellowOnePenalty.Value)).ToString();
            YellowTwoScore.Text = (score - Convert.ToInt32(YellowTwoPenalty.Value)).ToString();
        }

        private void LowerTopTowerRed_Click(object sender, EventArgs e)
        {
            if (this.LowerTopRedMultiply)
            {
                this.LowerTopTowerRed.BackColor = Color.Gray;
                this.LowerTopRedMultiply = false;
                this.LowerTopTowerYellow.Text = this.YellowLowerTopScore.ToString();
                this.LowerTopTowerBlue.Text = this.BlueLowerTopScore.ToString();
            }
            else
            {
                this.LowerTopTowerRed.BackColor = Color.Red;
                this.LowerTopRedMultiply = true;
                int interimScore = this.YellowLowerTopScore * 2;
                int interimBlue = this.BlueLowerTopScore * 2;
                this.LowerTopTowerYellow.Text = interimScore.ToString();
                this.LowerTopTowerBlue.Text = interimBlue.ToString();
            }
            updateBlueScore();
            updateYellowScore();
        }

        private void LowerBotTowerRed_Click(object sender, EventArgs e)
        {
            if (this.LowerBotRedMultiply)
            {
                this.LowerBotTowerRed.BackColor = Color.Gray;
                this.LowerBotRedMultiply = false;
                this.LowerBotTowerYellow.Text = this.YellowLowerBotScore.ToString();
                this.LowerBotTowerBlue.Text = this.BlueLowerBotScore.ToString();
            }
            else
            {
                this.LowerBotTowerRed.BackColor = Color.Red;
                this.LowerBotRedMultiply = true;
                int interimScore = this.YellowLowerBotScore * 2;
                int interimBlue = this.BlueLowerBotScore * 2;
                this.LowerBotTowerYellow.Text = interimScore.ToString();
                this.LowerBotTowerBlue.Text = interimBlue.ToString();
            }
            updateBlueScore();
            updateYellowScore();
        }

        private void TopBoxRed_Click(object sender, EventArgs e)
        {
            if (this.TopBoxRedMultipy)
            {
                this.TopBoxRed.BackColor = Color.Gray;
                this.TopBoxRedMultipy = false;
                this.TopBoxYellow.Text = this.YellowTopBoxScore.ToString();
                this.TopBoxBlue.Text = this.BlueTopBoxScore.ToString();
            }
            else
            {
                this.TopBoxRed.BackColor = Color.Red;
                this.TopBoxRedMultipy = true;
                int interimScore = this.YellowTopBoxScore * 2;
                int interimBlue = this.BlueTopBoxScore * 2;
                this.TopBoxYellow.Text = interimScore.ToString();
                this.TopBoxBlue.Text = interimBlue.ToString();
            }
            updateBlueScore();
            updateYellowScore();
        }

        private void BotBoxRed_Click(object sender, EventArgs e)
        {
            if (this.BotBoxRedMultiply)
            {
                this.BotBoxRed.BackColor = Color.Gray;
                this.BotBoxRedMultiply = false;
                this.BotBoxYellow.Text = this.YellowBotBoxScore.ToString();
                this.BotBoxBlue.Text = this.BlueBotBoxScore.ToString();
            }
            else
            {
                this.BotBoxRed.BackColor = Color.Red;
                this.BotBoxRedMultiply = true;
                int interimScore = this.YellowBotBoxScore * 2;
                int interimBlue = this.BlueBotBoxScore * 2;
                this.BotBoxYellow.Text = interimScore.ToString();
                this.BotBoxBlue.Text = interimBlue.ToString();
            }
            updateBlueScore();
            updateYellowScore();
        }

        private void UpperTopRed_Click(object sender, EventArgs e)
        {
            if (this.UpperTopRedMultiply)
            {
                this.UpperTopRed.BackColor = Color.Gray;
                this.UpperTopRedMultiply = false;
                this.UpperTopTowerYellow.Text = this.YellowUpperTopScore.ToString();
                this.UpperTopTowerBlue.Text = this.BlueUpperTopScore.ToString();
            }
            else
            {
                this.UpperTopRed.BackColor = Color.Red;
                this.UpperTopRedMultiply = true;
                int interimScore = this.YellowUpperTopScore * 2;
                int interimBlue = this.BlueUpperTopScore * 2;
                this.UpperTopTowerYellow.Text = interimScore.ToString();
                this.UpperTopTowerBlue.Text = interimBlue.ToString();
            }
            updateBlueScore();
            updateYellowScore();
        }

        private void UpperBotRed_Click(object sender, EventArgs e)
        {
            if (this.UpperBotRedMultiply)
            {
                this.UpperBotRed.BackColor = Color.Gray;
                this.UpperBotRedMultiply = false;
                this.UpperBotTowerYellow.Text = this.YellowUpperBotScore.ToString();
                this.UpperBotTowerBlue.Text = this.BlueUpperBotScore.ToString();
            }
            else
            {
                this.UpperBotRed.BackColor = Color.Red;
                this.UpperBotRedMultiply = true;
                int interimScore = this.YellowUpperBotScore * 2;
                int interimBlue = this.BlueUpperBotScore * 2;
                this.UpperBotTowerYellow.Text = interimScore.ToString();
                this.UpperBotTowerBlue.Text = interimBlue.ToString();
            }
            updateBlueScore();
            updateYellowScore();
        }

        public void GameTime_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        public void GameTime_DoubleClick(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimeSpan t = TimeSpan.FromSeconds(this.timeLeft);
                GameTime.Text = t.Minutes.ToString() + ":" + t.Seconds.ToString();
            }

            else
            {
                this.timer1.Stop();

            }
            
        }

        public void ResetButton_DoubleClick(object sender, EventArgs e)
        {
            var confirmResult =  MessageBox.Show("Reset game state?",
                                     "Confirm reset",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
{
                this.timer1.Stop();
                this.timeLeft = 300;
                this.GameTime.Text = "5:00";
                this.YellowLowerTopScore = 0;
                this.YellowLowerBotScore = 0;
                this.YellowUpperTopScore = 0;
                this.YellowUpperBotScore = 0;
                this.YellowTopBoxScore = 0;
                this.YellowBotBoxScore = 0;
                this.BlueLowerTopScore = 0;
                this.BlueLowerBotScore = 0;
                this.BlueUpperTopScore = 0;
                this.BlueUpperBotScore = 0;
                this.BlueBotBoxScore = 0;
                this.BlueTopBoxScore = 0;
                this.LowerTopRedMultiply = false;
                this.LowerBotRedMultiply = false;
                this.UpperTopRedMultiply = false;
                this.UpperBotRedMultiply = false;
                this.TopBoxRedMultipy = false;
                this.BotBoxRedMultiply = false;
                this.BlueScore.Text = "0";
                this.YellowScore.Text = "0";
                this.BlueOneScore.Text = "0";
                this.BlueTwoScore.Text = "0";
                this.YellowTwoScore.Text = "0";
                this.YellowOneScore.Text = "0";
                this.LowerTopTowerYellow.Text = "0";
                this.LowerTopTowerBlue.Text = "0";
                this.LowerBotTowerYellow.Text = "0";
                this.LowerBotTowerBlue.Text = "0";
                this.LowerTopTowerRed.BackColor = System.Drawing.Color.Gray;
                this.LowerBotTowerRed.BackColor = System.Drawing.Color.Gray;
                this.TopBoxRed.BackColor = System.Drawing.Color.Gray;
                this.TopBoxBlue.Text = "0";
                this.TopBoxYellow.Text = "0";
                this.BotBoxRed.BackColor = System.Drawing.Color.Gray;
                this.BotBoxBlue.Text = "0";
                this.BotBoxYellow.Text = "0";
                this.UpperBotRed.BackColor = System.Drawing.Color.Gray;
                this.UpperTopRed.BackColor = System.Drawing.Color.Gray;
                this.UpperBotTowerBlue.Text = "0";
                this.UpperBotTowerYellow.Text = "0";
                this.UpperTopTowerYellow.Text = "0";
                this.UpperTopTowerBlue.Text = "0";
                this.BlueOnePenalty.Value = 0;
                this.BlueTwoPenalty.Value = 0;
                this.YellowOnePenalty.Value = 0;
                this.YellowTwoPenalty.Value = 0;


            }
            else
{
    // If 'No', do something here.
}
        }

        private void YellowOnePenalty_ValueChanged(object sender, EventArgs e)
        {
            updateYellowScore();
        }

        private void YellowTwoPenalty_ValueChanged(object sender, EventArgs e)
        {
            updateYellowScore();
        }

        private void BlueOnePenalty_ValueChanged(object sender, EventArgs e)
        {
            updateBlueScore();
        }

        private void BlueTwoPenalty_ValueChanged(object sender, EventArgs e)
        {
            updateBlueScore();
        }
    }
    }

