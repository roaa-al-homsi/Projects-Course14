﻿using System;
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
    public partial class FrmMainScreenMathGame : Form
    {
        public FrmMainScreenMathGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMathGame MathGame = new FrmMathGame(this);
            MathGame.ShowDialog();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();






        }





    }
}
