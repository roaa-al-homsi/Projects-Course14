using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Practicing
{
    public partial class FrmGenerateRandomCharacters : Form
    {
        Random rnd = new Random();
        int NumberOfDigits = 0;

        public FrmGenerateRandomCharacters()
        {
            InitializeComponent();
        }

        string GenerateRandomCharacters(short From, short To)
        {
            string sText = " ";

            for (int i = 0; i < NumberOfDigits; i++)
            {

                sText += Convert.ToChar(rnd.Next(From, To));
            }
            return sText;
        }

        void GenerateChoice()
        {
            if (chkbLetters.Checked)
            {
               labResult.Text = GenerateRandomCharacters(65,90);
            }
            else if (chkSymbols.Checked)
            {
                labResult.Text = GenerateRandomCharacters(32,47);
            }
            else if (chkMix.Checked)
            {
                labResult.Text = GenerateRandomCharacters(32,90);
            }
            else if (chkNumbers.Checked)
            {
                labResult.Text = GenerateRandomCharacters(1,9);
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            chkbLetters.Enabled = true;
            chkMix.Enabled = true;
            chkNumbers.Enabled = true;
            chkSymbols.Enabled = true;

            btnCopy.Enabled = true;


        }

        private void txtNumberofDigits_TextChanged_1(object sender, EventArgs e)
        {

            if(int.TryParse(txtNumberofDigits.Text, out NumberOfDigits))
            {


            }
            else
            {
                MessageBox.Show("Error, You Should Enter Numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void chkbLetters_CheckedChanged(object sender, EventArgs e)
        {
            chkNumbers.Enabled = false;
            chkMix.Enabled = false;
            chkSymbols.Enabled = false;

            btnGenerate.Enabled = true;

        }

        private void chkSymbols_CheckedChanged(object sender, EventArgs e)
        {
            chkNumbers.Enabled = false;
            chkMix.Enabled = false;
            chkbLetters.Enabled = false;

            btnGenerate.Enabled = true;
           
        }

        private void chkMix_CheckedChanged(object sender, EventArgs e)
        {
            chkNumbers.Enabled = false;
            chkSymbols.Enabled = false;
            chkbLetters.Enabled = false;

            btnGenerate.Enabled = true;
        }

        private void chkNumbers_CheckedChanged(object sender, EventArgs e)
        {
            chkSymbols.Enabled = false;
            chkMix.Enabled = false;
            chkbLetters.Enabled = false;

            btnGenerate.Enabled = true;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateChoice();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The text has been copied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        void ResetMode()
        {
            groupBox1.Visible = false;
            labResult.Text = " ";

            chkbLetters.Checked = false;
            chkSymbols.Checked = false;
            chkNumbers.Checked = false;
            chkMix.Checked = false;
            txtNumberofDigits.Text = "0";
            btnGenerate.Enabled = false;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMode();
        }

        private void FrmGenerateRandomCharacters_Load(object sender, EventArgs e)
        {

        }
    }
}


