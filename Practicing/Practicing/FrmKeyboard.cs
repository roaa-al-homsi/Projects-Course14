using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practicing
{
    public partial class FrmKeyboard : Form
    {
        private bool StartChallenge = false;
        private char LastChar;
        private int LastLength = 0;
        private int Correct = 0;
        private int Error = 0;

        Dictionary<char, Label> dic = new Dictionary<char, Label>();

        public FrmKeyboard()
        {
            InitializeComponent();
        }

        private void FullDic()
        {
            foreach (Label L in grbBoxKeys.Controls)
            {
                if (L.Text.Length == 1)
                    dic.Add(char.ToUpper(L.Text[0]), L);
            }
        }

        private void ChangeColor()
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                LastLength = textBox1.Text.Length;
                LastChar = textBox1.Text[textBox1.Text.Length - 1];

                foreach (Label L in grbBoxKeys.Controls)
                {
                    if (L.Text != "Back Space" && (L.Text[0]) == char.ToUpper(LastChar))
                    {
                        L.BackColor = Color.Purple;

                        return;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (labChallengeText.Text.Length == textBox1.Text.Length && StartChallenge)
            {
                MessageBox.Show("You Finished a Text Challenge, Enter Submit To Show Your Result", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;

            }

            if (LastLength > textBox1.Text.Length)
            {
                labBackSpace.BackColor = Color.Purple;
                _ResetBlackColorsOfLabels();

                LastLength = textBox1.Text.Length;

                return;
            }
            else
            {
                labBackSpace.BackColor = Color.Black;
            }

            _ResetBlackColorsOfLabels();
            ChangeColor();

            if (StartChallenge) CheckText();
        }

        private void _ResetBlackColorsOfLabels()
        {
            if (dic.ContainsKey(char.ToUpper(LastChar)))
            {
                Label Currentlb = dic[char.ToUpper(LastChar)];
                Currentlb.BackColor = Color.Black;
            }
        }

        private void CheckText()
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int LastIndex = textBox1.Text.Length - 1;

                if (labChallengeText.Text[LastIndex] != textBox1.Text[LastIndex])
                {
                    textBox1.BackColor = Color.Red;
                    Error++;

                }
                else
                {
                    Correct++;
                    textBox1.BackColor = Color.White;
                }
                    

            }
        }

        private void btnStartChallenge_Click(object sender, EventArgs e)
        {
            StartChallenge = true;
        }

        private void FrmKeyboard_Load(object sender, EventArgs e)
        {
            FullDic();
            btnSubmit.Enabled = false;
        
        }

        private double _GetAccAccuracy()
        {
            return Convert.ToDouble((Correct / (Correct + Error)) * 100);
        }
        private string _CheckAccuracy()
        {

            double Accuracy = _GetAccAccuracy();

            if (Accuracy > 50 && Accuracy <= 80)
            {
                return  "Good, Your Accuracy is " + Accuracy + "%.";
            }
            else if (Accuracy > 80 && Accuracy <= 100)
            {
                return  "Excellent, Your Accuracy is " + Accuracy + "%.";
            }
            else
                return  "Bad, Your Accuracy is " + Accuracy + "%.";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_CheckAccuracy(), "Accuracy", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void _Reset()
        {
            Correct = 0;
            Error = 0;
            LastLength = 0;
            btnSubmit.Enabled = false;
            StartChallenge = false;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            _ResetBlackColorsOfLabels();
            labBackSpace.BackColor = Color.Black;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _Reset();

        }


    }
}