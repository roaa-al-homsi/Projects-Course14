using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicing
{
    public partial class FrmMemoryGame : Form
    {
        public FrmMemoryGame()
        {
            InitializeComponent();
        }

        byte Score = 0;
        int CountTimer1 = 0;
        int CountTimer2 = 60;
        byte _CounterMoves = 0;
        bool _StartGame = false;

          
        private bool CheckTwoPicture(PictureBox pic)
        {
            foreach (PictureBox P in groupBox1.Controls)
            {
                if (pic.Tag.ToString() != "?" && pic != P && pic.Tag.ToString() == P.Tag.ToString())
                {
                    pic.Visible = false;
                    P.Visible = false;
                    return true;
                }
            }
            return false;
        }

        private void PrintScore()
        {
            if (Score>=6)
            {
                timer2.Enabled = false;
                MessageBox.Show("Congrats , You Win The Game if you want play again press a button Restart game.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                labScore.Text = Score.ToString() + "/6";
        }

        private void ChangeImage(PictureBox pic, Image x, string ColorTag)
        {
            if (!_StartGame)
            {
                MessageBox.Show("You Should Press Start Game key To Can you Play", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                labNumberMoves.Text = (++_CounterMoves).ToString();
                timer1.Enabled = true;
                if (pic.Tag.ToString() == "?")
                {
                    pic.Image = x;
                    pic.Tag = ColorTag;
                    if (CheckTwoPicture(pic))
                    {
                        Score++;
                        PrintScore();
                    }
                }
                else
                {
                    pic.Image = Properties.Resources.question_mark_96;
                    pic.Tag = "?";
                }
            }
        }

        //private void pictureBox_Click(object sender, EventArgs e)
        //{
        //    ChangeImage((PictureBox)sender);
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.blue, "blue");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Yalow, "Yalow");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.green, "green");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Yalow, "Yalow");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Light_Green, "Light_Green");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Purple, "Purple");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Purple, "Purple");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Light_Green, "Light_Green");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Pink, "Pink");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.Pink, "Pink");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.blue, "blue");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender, Properties.Resources.green, "green");
        }

        private void ResetAllPictures(bool IsResetGame=false)
        {
            foreach (PictureBox P in groupBox1.Controls)
            {
                if (P.Tag.ToString() != "?")
                {
                        if (!CheckTwoPicture(P) && !IsResetGame|| IsResetGame)
                        {
                            P.Visible = true;
                            P.Image = Properties.Resources.question_mark_96;
                            P.Tag = "?";

                        }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CountTimer1++;
          
            if (CountTimer1 == 2)
            {
                timer1.Enabled = false;
                ResetAllPictures();
                CountTimer1 = 0;
            }
        }

        private void ResetGame()
        {
            ResetAllPictures(true);
            CountTimer1 = 0;
            Score = 0;
            labScore.Text = Score+"/6";
            _CounterMoves = 0;
            labNumberMoves.Text = "";
            _StartGame = false;
            CountTimer2 = 60;
            labTimer2.Text= "00:" + CountTimer2.ToString();
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _StartGame = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labTimer2.Text = "00:" + CountTimer2.ToString();
            CountTimer2--;
            if(CountTimer2<=0)
            {
                timer2.Enabled = false;
                MessageBox.Show("Game Over,Time Is Over,if you want play again press a button Restart game.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
        }

       
    }


}
