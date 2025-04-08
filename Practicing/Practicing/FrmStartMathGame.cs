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
    public partial class FrmStartMathGame : Form
    {
        FrmMathGame _StartMathGame = new FrmMathGame();


        public FrmStartMathGame()
        {
            InitializeComponent();
        }

        public FrmStartMathGame(FrmMathGame StartMathGame)
        {
            InitializeComponent();
            _StartMathGame = StartMathGame;

        }


    }
}
