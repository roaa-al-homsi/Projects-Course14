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
    public partial class FrmCalculator_Simple_ : Form
    {
        enum enOperations { Add = '+', Minus = '-', Divide = '/', Multi = '*', Mode = '%' };
        enOperations CurrentOperation;
        double Num1 = 0;
        double Num2 = 0;


        public FrmCalculator_Simple_()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Simple__Load(object sender, EventArgs e)
        {
            butEqual.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button1.Text;
            GetTwoNumbers();
        }
        
    



        private void button10_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button0.Text;
            GetTwoNumbers();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button9.Text;
            GetTwoNumbers();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button8.Text;
            GetTwoNumbers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button7.Text;
            GetTwoNumbers();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button6.Text;
            GetTwoNumbers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button5.Text;
            GetTwoNumbers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button4.Text;
            GetTwoNumbers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button3.Text;
            GetTwoNumbers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button2.Text;
            GetTwoNumbers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butSum_Click(object sender, EventArgs e)
        {
            CurrentOperation = enOperations.Add;
            labShowResult.Text += butSum.Text;

            butMinus.Enabled = false;
            butDivide.Enabled = false;
            butMode.Enabled = false;
            butMultiply.Enabled = false;

        }

        private void butMinus_Click(object sender, EventArgs e)
        {

            CurrentOperation = enOperations.Minus;
            labShowResult.Text += butMinus.Text;

            butSum.Enabled = false;
            butDivide.Enabled = false;
            butMode.Enabled = false;
            butMultiply.Enabled = false;

        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            CurrentOperation = enOperations.Multi;
            labShowResult.Text += butMultiply.Text;

            butSum.Enabled = false;
            butDivide.Enabled = false;
            butMode.Enabled = false;
            butMinus.Enabled = false;
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            CurrentOperation = enOperations.Divide;
            labShowResult.Text += butDivide.Text;
        }

        private void butMode_Click(object sender, EventArgs e)
        {
            CurrentOperation = enOperations.Mode;
            labShowResult.Text += butMode.Text;

            butSum.Enabled = false;
            butDivide.Enabled = false;
            butMinus.Enabled = false;
            butMultiply.Enabled = false;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            labShowResult.Text = " ";

            butSum.Enabled = true;
            butDivide.Enabled = true;
            butMode.Enabled = true;
            butMultiply.Enabled = true;
            butMinus.Enabled = true;


        }


        private void IsNegativeNumber()
        {
            int counter = 0;
         

            if (labShowResult.Text[0] == '-')
            {
                labShowResult.Text = labShowResult.Text.Remove(0, 1);
                Num1 = -1;
            }

            for (int i = 0; i < labShowResult.Text.Length; i++)
            {
                if (labShowResult.Text[i] == '-')
                {
                    counter++;
                    if (counter == 2)
                    {
                
                        labShowResult.Text = labShowResult.Text.Remove(i, 1);
                        Num2 =-1;
                    }
                }
            }

        }

        private void GetTwoNumbers()
        {
            IsNegativeNumber();
            string[] Numbers;
            Numbers = labShowResult.Text.Split((char)CurrentOperation);
            if (Numbers.Length > 1)
            {
                butEqual.Enabled = true;
                Num1 = Convert.ToDouble(Numbers[0]);
                Num2 = Convert.ToDouble(Numbers[1]);
              //bool IsDigit = Double.TryParse(Numbers[1], out Double Num2);
              
            }
        }

        private double GetResult()
        {
            switch (CurrentOperation)
            {
                case enOperations.Add:

                    return Num1 + Num2;

                case enOperations.Minus:
                    return Num1 - Num2;

                case enOperations.Multi:
                    return Num1 * Num2;

                case enOperations.Divide:
                    return Num1 / Num2;

                case enOperations.Mode:
                    return Num1 % Num2;

                default:
                    return 0;
            }
        }
        private void butEqual_Click(object sender, EventArgs e)
        {

          labShowResult.Text = GetResult().ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (labShowResult.Text != "")

                labShowResult.Text = labShowResult.Text.Substring(0, labShowResult.Text.Length - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            labShowResult.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {



        }
    }
}
