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
    public partial class controlWindow : Form
    {
        Vertigoal vertigoal;
        public controlWindow()
        {
            InitializeComponent();
            vertigoal = new Vertigoal();
            vertigoal.Show();
        }

        private void updateBlueScore()
        {
            string totalBluePoint;
            int t2tb = (!tour_2_top_multiplier.Checked ? (int)tour_2_top_blue.Value : (int)tour_2_top_blue.Value * 2);
            int t4tb = (!tour_4_top_multiplier.Checked ? (int)tour_4_top_blue.Value : (int)tour_4_top_blue.Value * 2);
            int t2bb = (!tour_2_bottom_multiplier.Checked ? (int)tour_2_bottom_blue.Value : (int)tour_2_bottom_blue.Value * 2);
            int t4bb = (!tour_4_bottom_multiplier.Checked ? (int)tour_4_bottom_blue.Value : (int)tour_4_bottom_blue.Value * 2);
            int t1b = (!trapeze_1_multiplier.Checked ? (int)trapeze_1_blue.Value : (int)trapeze_1_blue.Value * 2);
            int t2b = (!trapeze_2_multiplier.Checked ? (int)trapeze_2_blue.Value : (int)trapeze_2_blue.Value * 2);

            vertigoal.TopBoxBlue.Text = t1b.ToString();
            vertigoal.BotBoxBlue.Text = t2b.ToString();
            vertigoal.UpperTopTowerBlue.Text = t4tb.ToString();
            vertigoal.UpperBotTowerBlue.Text = t4bb.ToString();
            vertigoal.LowerBotTowerBlue.Text = t2bb.ToString();
            vertigoal.LowerTopTowerBlue.Text = t2tb.ToString();

            totalBluePoint = (t2tb + t2bb + t4tb + t4bb +
                t1b + t2b).ToString();

            vertigoal.BlueScore.Text = totalBluePoint;
            if (noShow1.Checked == false)
            {
                int ptsFinal = 0;
                teamScore1.Text = (!noShow2.Checked ? totalBluePoint : (Int32.Parse(totalBluePoint) * 1.5).ToString());
                ptsFinal = (int) (Int32.Parse(teamScore1.Text) - penPts1.Value - ((penPourcen1.Value / 100) * Int32.Parse(teamScore1.Text)));

                if (ptsFinal < 0)
                {
                    ptsFinal = 0;
                }

                ptsFinaux1.Text = ptsFinal.ToString();
                totPen1.Text = (penPts1.Value + ((penPourcen1.Value / 100) * Int32.Parse(teamScore1.Text))).ToString();

                vertigoal.BlueOneScore.Text = ptsFinal.ToString();
            }
            else
            {
                ptsFinaux1.Text = "0";
                vertigoal.BlueOneScore.Text = "0";
            }

            if (noShow2.Checked == false)
            {
                int ptsFinal = 0;
                teamScore2.Text = (!noShow1.Checked ? totalBluePoint : (Int32.Parse(totalBluePoint) * 1.5).ToString());
                ptsFinal = (int) (Int32.Parse(teamScore2.Text) - penPts2.Value - ((penPourcen2.Value / 100) * Int32.Parse(teamScore2.Text)));

                if (ptsFinal < 0)
                {
                    ptsFinal = 0;
                }

                ptsFinaux2.Text = ptsFinal.ToString();
                vertigoal.BlueTwoScore.Text = ptsFinal.ToString();
                totPen2.Text = (penPts2.Value + ((penPourcen2.Value / 100) * Int32.Parse(teamScore2.Text))).ToString();

            }
            else
            {
                ptsFinaux2.Text = "0";
                vertigoal.BlueTwoScore.Text = "0";
            }

            teamScore1.Text = totalBluePoint;
            teamScore2.Text = totalBluePoint;
        }

        private void updateYellowScore()
        {
            string totalYellowPoint;

            int t2ty = (!tour_2_top_multiplier.Checked ? (int)tour_2_top_yellow.Value : (int)tour_2_top_yellow.Value * 2);
            int t4ty = (!tour_4_top_multiplier.Checked ? (int)tour_4_top_yellow.Value : (int)tour_4_top_yellow.Value * 2);
            int t2by = (!tour_2_bottom_multiplier.Checked ? (int)tour_2_bottom_yellow.Value : (int)tour_2_bottom_yellow.Value * 2);
            int t4by = (!tour_4_bottom_multiplier.Checked ? (int)tour_4_bottom_yellow.Value : (int)tour_4_bottom_yellow.Value * 2);
            int t1y = (!trapeze_1_multiplier.Checked ? (int)trapeze_1_yellow.Value : (int)trapeze_1_yellow.Value * 2);
            int t2y = (!trapeze_2_multiplier.Checked ? (int)trapeze_2_yellow.Value : (int)trapeze_2_yellow.Value * 2);

            vertigoal.TopBoxYellow.Text = t1y.ToString();
            vertigoal.BotBoxYellow.Text = t2y.ToString();
            vertigoal.UpperTopTowerYellow.Text = t4ty.ToString();
            vertigoal.UpperBotTowerYellow.Text = t4by.ToString();
            vertigoal.LowerBotTowerYellow.Text = t2by.ToString();
            vertigoal.LowerTopTowerYellow.Text = t2ty.ToString();

            totalYellowPoint = (t2ty + t2by + t4ty + t4by +
                t1y + t2y).ToString();

            vertigoal.YellowScore.Text = totalYellowPoint;

            if (noShow3.Checked == false)
            {
                int ptsFinal = 0;
                teamScore3.Text = (!noShow4.Checked ? totalYellowPoint : (Int32.Parse(totalYellowPoint) * 1.5).ToString());
                ptsFinal =  (int)(Int32.Parse(teamScore3.Text) - penPts3.Value - ((penPourcen3.Value / 100) * Int32.Parse(teamScore3.Text)));
                if(ptsFinal < 0)
                {
                    ptsFinal = 0;
                }

                ptsFinaux3.Text = ptsFinal.ToString();
                vertigoal.YellowOneScore.Text = ptsFinal.ToString();
                totPen3.Text = (penPts3.Value + ((penPourcen3.Value / 100) * Int32.Parse(teamScore3.Text))).ToString();
            }
            else
            {
                ptsFinaux3.Text = "0";
                vertigoal.YellowOneScore.Text = "0";
            }

            if (noShow4.Checked == false)
            {
                int ptsFinal = 0;
                teamScore4.Text = (!noShow3.Checked ? totalYellowPoint : (Int32.Parse(totalYellowPoint) * 1.5).ToString());
                ptsFinal = (int)(Int32.Parse(teamScore4.Text) - penPts4.Value - ((penPourcen4.Value / 100) * Int32.Parse(teamScore4.Text)));
                if (ptsFinal < 0)
                {
                    ptsFinal = 0;
                }

                ptsFinaux4.Text = ptsFinal.ToString();
                vertigoal.YellowTwoScore.Text = ptsFinal.ToString();
                totPen4.Text = (penPts4.Value + ((penPourcen4.Value / 100) * Int32.Parse(teamScore4.Text))).ToString();
            }
            else
            {
                ptsFinaux4.Text = "0";
                vertigoal.YellowOneScore.Text = "0";
            }

            teamScore3.Text = totalYellowPoint;
            teamScore4.Text = totalYellowPoint;
        }

        private void updateBothTeam(object sender, EventArgs e)
        {
            updateBlueScore();
            updateYellowScore();

            vertigoal.LowerTopTowerRed.BackColor = (!tour_2_top_multiplier.Checked ? Color.Gray : Color.Red);
            vertigoal.LowerBotTowerRed.BackColor = (!tour_2_bottom_multiplier.Checked ? Color.Gray : Color.Red);
            vertigoal.UpperBotRed.BackColor = (!tour_4_bottom_multiplier.Checked ? Color.Gray : Color.Red);
            vertigoal.UpperTopRed.BackColor = (!tour_4_top_multiplier.Checked ? Color.Gray : Color.Red);
            vertigoal.TopBoxRed.BackColor = (!trapeze_1_multiplier.Checked ? Color.Gray : Color.Red);
            vertigoal.BotBoxRed.BackColor = (!trapeze_2_multiplier.Checked ? Color.Gray : Color.Red);
        }

        private void updateBlueTeam(object sender, EventArgs e)
        {
            updateBlueScore();
        }

        private void updateYellowTeam(object sender, EventArgs e)
        {
            updateYellowScore();
        }

        private void start_Click(object sender, EventArgs e)
        {
            vertigoal.GameTime_Click(sender, e);
        }

        private void restart_Click(object sender, EventArgs e)
        {
            vertigoal.GameTime_DoubleClick(sender, e);
            vertigoal.ResetButton_DoubleClick(sender ,e);

            tour_2_top_blue.Value = 0; 
            tour_4_top_blue.Value = 0;
            tour_2_bottom_blue.Value = 0;
            tour_4_bottom_blue.Value = 0;
            trapeze_1_blue.Value = 0;
            trapeze_2_blue.Value = 0;

            tour_2_top_yellow.Value = 0;
            tour_4_top_yellow.Value = 0;
            tour_2_bottom_yellow.Value = 0;
            tour_4_bottom_yellow.Value = 0;
            trapeze_1_yellow.Value = 0;
            trapeze_2_yellow.Value = 0;

            penPts1.Value = 0;
            penPourcen1.Value = 0;
            penPts2.Value = 0;
            penPourcen2.Value = 0;
            penPts3.Value = 0;
            penPourcen3.Value = 0;
            penPts4.Value = 0;
            penPourcen4.Value = 0;


            tour_2_bottom_multiplier.Checked = false;
            tour_2_top_multiplier.Checked = false;
            tour_4_bottom_multiplier.Checked = false;
            tour_4_top_multiplier.Checked = false;
            trapeze_1_multiplier.Checked = false;
            trapeze_2_multiplier.Checked = false;

            noShow1.Checked = false;
            noShow2.Checked = false;
            noShow3.Checked = false;
            noShow4.Checked = false;

        }
    }
}
