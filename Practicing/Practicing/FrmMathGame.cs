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
    public partial class FrmMathGame : Form
    {

        FrmMainScreenMathGame _MainMenuForm = new FrmMainScreenMathGame();

        public FrmMathGame(FrmMainScreenMathGame MainMenuForm)
        {
            InitializeComponent();

            _MainMenuForm = MainMenuForm;

        }

        public FrmMathGame()
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStartMathGame StartMathGame = new FrmStartMathGame(this);
            StartMathGame.ShowDialog();
        }
    }









}
