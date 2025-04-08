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
    public partial class FrmMainScreenAllProjects : Form
    {
        public FrmMainScreenAllProjects()
        {
            InitializeComponent();
        }

        private void btnGenerateRandomChar_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmGenerateRandomCharacters();
            frm1.Show();

        }

        private void btnNumberofDigits_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmNumberofDigitsInMatrix();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmCalculator_Simple_();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmKeyboard();
            frm1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmMemoryGame();
            frm1.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmBilliardClub();
            frm1.Show();
        }
        private void btnMathGameProject_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmMainScreenMathGame();
            frm1.Show();


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form frm1 = new FrmMenuStripcs();
            frm1.Show();
        }
    }
}
