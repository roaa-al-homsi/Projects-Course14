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
    public partial class FrmNumberofDigitsInMatrix : Form
    {
        Random rdm = new Random();
        int Answer = 0;
        public FrmNumberofDigitsInMatrix()
        {
            InitializeComponent();
        }

        private void InitiLoad ()
        {
            labNumberToCheck.Text = rdm.Next(1, 10).ToString();

            for (int i = 0; i < 36; i++)
            {
                Label l = addlabel(i);
                flowLayoutPanel1.Controls.Add(l);
            }
        }

        void RemoveAllControlsInPanel()
        {
            // while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            flowLayoutPanel1.Controls.Clear();
        }

        private void FrmNumberofDigitsInMatrix_Load(object sender, EventArgs e)
        { 
            InitiLoad();
         
        }

        Label addlabel(int i)
        {
            Label l = new Label();
            l.Name = "label" + i.ToString();
            l.Text = rdm.Next(1, 10).ToString();
            l.ForeColor = Color.White;
            l.BackColor = Color.Black;
            l.Font = new Font("Serif", 14, FontStyle.Bold);
            l.Width = 50;
            l.Height = 50;
            l.TextAlign = ContentAlignment.TopCenter;
            l.Margin = new Padding(10);

            return l;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
          RemoveAllControlsInPanel();
          InitiLoad();

            labResult.Text = "";
            textBox1.Text = "";
            labResult.BackColor = Color.Thistle;

        }

        int CountFreqNumber()
        {
            byte Counter = 0;

           // while (flowLayoutPanel1.Controls.Count > 0) { }
           
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if(c.GetType()==typeof(Label))
                {
                    Label defineLabel = (Label)c;
                    if (defineLabel.Text == labNumberToCheck.Text)
                    {
                        Counter++;
                        // flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
            return Counter;
        }

        void CheckAnswer()
        {
            if (CountFreqNumber()== Convert.ToInt32(Answer))
            {
                labResult.BackColor = Color.Green;
                labResult.Text = "Correct";
            }
            else
            {
                labResult.BackColor = Color.Red;
                labResult.Text = "Wrong";
            }
              
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckAnswer();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text,out Answer) && textBox1.Text !="")
            {
                MessageBox.Show("Error,You Should Enter Only Numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }





    }

}

