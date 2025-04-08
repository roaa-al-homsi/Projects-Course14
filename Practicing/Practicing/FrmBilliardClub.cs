using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practicing
{
    public partial class FrmBilliardClub : Form
    {
        public FrmBilliardClub()
        {
            InitializeComponent();
        }

        struct stTimer
        {
            public byte Seconds;
            public byte Minutes;
        }
        stTimer Timer1 = new stTimer();
        stTimer Timer2 = new stTimer();
        stTimer Timer3 = new stTimer();
        stTimer Timer4 = new stTimer();
        stTimer Timer5 = new stTimer();
        stTimer Timer6 = new stTimer();

        float Price = 0;

        private void AfterClickAddButton(Label L, Button btn)
        {
            L.Text = textBox1.Text;
            btn.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(labPlayerName1.Text))
                AfterClickAddButton(labPlayerName1, btnStart1);

            else if (labPlayerName2.Text == " ")
                AfterClickAddButton(labPlayerName2, btnStart2);

            else if (labPlayerName3.Text == " ")
                AfterClickAddButton(labPlayerName3, btnStart3);

            else if (labPlayerName4.Text == " ")
                AfterClickAddButton(labPlayerName4, btnStart4);

            else if (labPlayerName5.Text == " ")
                AfterClickAddButton(labPlayerName5, btnStart5);

            else if (labPlayerName6.Text == " ")
                AfterClickAddButton(labPlayerName6, btnStart6);

            else
                MessageBox.Show("Error,There are not an empty table in club", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Text = " ";

        }

        private void StartTimer(ref byte Seconds, ref byte Minutes, Label lab, Button btnEnd)
        {
            Seconds++;
            if (Seconds == 60)
            {
                Seconds = 0;
                Minutes++;
            }
            lab.Text = $"{Minutes:D2}:{Seconds:D2}";
            btnEnd.Tag = Minutes;

            //Seconds++;
            //if (Seconds == 60)
            //{
            //    Seconds = 0;
            //    Minutes++;
            //}
            //if (Seconds < 10)
            //{
            //    if (Minutes < 10)
            //    {
            //        lab.Text = "0" + Minutes.ToString() + ":" + "0" + Seconds.ToString();
            //    }
            //    else
            //    {
            //        lab.Text = Minutes.ToString() + ":" + "0" + Seconds.ToString();
            //    }
            //}
            //else
            //{
            //    //here surely seconds is greater than 10
            //    if (Minutes < 10)
            //    {
            //        lab.Text = "0" + Minutes.ToString() + ":" + Seconds.ToString();
            //    }
            //    else
            //    {
            //        lab.Text = Minutes.ToString() + ":" + Seconds.ToString();
            //    }

            //}
        }

        private void GetPrice(Button btnEnd)
        {
            Price = Convert.ToSingle(numericUpDown1.Value * Convert.ToDecimal(btnEnd.Tag));
            MessageBox.Show($"Game Over The total price is : {Price}");
        }

        //Start Button 
        private void ChangeModeAfterStartBooking(Button btnS, Button btnP, Button btnE, GroupBox Grb, Timer T)
        {
            T.Enabled = true;
            if (btnS.Text == "Reusem")
                btnS.Text = "Start";

            btnS.Enabled = false;
            btnP.Enabled = true;
            btnE.Enabled = true;
            Grb.BackColor = Color.Gray;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            ChangeModeAfterStartBooking((Button)sender, btnPause1, btnEndTable1, groupBox1, timer1);
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            ChangeModeAfterStartBooking((Button)sender, btnPause2, btnEndTable2, groupBox2, timer2);
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            ChangeModeAfterStartBooking((Button)sender, btnPause3, btnEndTable3, groupBox3, timer3);
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            ChangeModeAfterStartBooking((Button)sender, btnPause4, btnEndTable4, groupBox4, timer4);
        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            ChangeModeAfterStartBooking((Button)sender, btnPause5, btnEndTable5, groupBox5, timer5);
        }

        private void btnStart6_Click(object sender, EventArgs e)
        {
            ChangeModeAfterStartBooking((Button)sender, btnPause6, btnEndTable6, groupBox6, timer6);
        }

        //Pause Button

        private void PauseGame(Button btnP, Button btnS, GroupBox Grb, Timer T)
        {
            btnP.Enabled = false;
            btnS.Enabled = true;
            btnS.Text = "Reusem";
            Grb.BackColor = Color.Yellow;
            T.Enabled = false;
        }

        private void btnPause1_Click(object sender, EventArgs e)
        {
            PauseGame((Button)sender, btnStart1, groupBox1, timer1);

        }

        private void btnPause2_Click(object sender, EventArgs e)
        {
            PauseGame((Button)sender, btnStart2, groupBox2, timer2);
        }

        private void btnPause3_Click(object sender, EventArgs e)
        {
            PauseGame((Button)sender, btnStart3, groupBox3, timer3);
        }

        private void btnPause4_Click(object sender, EventArgs e)
        {
            PauseGame((Button)sender, btnStart4, groupBox4, timer4);
        }

        private void btnPause5_Click(object sender, EventArgs e)
        {
            PauseGame((Button)sender, btnStart5, groupBox5, timer5);
        }

        private void btnPause6_Click(object sender, EventArgs e)
        {
            PauseGame((Button)sender, btnStart6, groupBox6, timer6);
        }

        //End Buuton 

        private void EndBookingTable(Button btnE, Button btnP, Button btnS, GroupBox Grb, Timer T, Label labName, Label LabTime)
        {
            if (btnS.Text == "Reusem")
                btnS.Text = "Start";

            btnP.Enabled = false;
            btnS.Enabled = false;
            btnE.Enabled = false;
            Grb.BackColor = Color.Transparent;
            labName.Text = " ";
            LabTime.Text = "00:00";
            T.Stop();

            GetPrice(btnE);
        }

        private void btnEndTable1_Click(object sender, EventArgs e)
        {
            EndBookingTable((Button)sender, btnPause1, btnStart1, groupBox1, timer1, labPlayerName1, labTimeTable1);
        }

        private void btnEndTable2_Click(object sender, EventArgs e)
        {
            EndBookingTable((Button)sender, btnPause2, btnStart2, groupBox2, timer2, labPlayerName2, labTimeTable2);
        }

        private void btnEndTable3_Click(object sender, EventArgs e)
        {
            EndBookingTable((Button)sender, btnPause3, btnStart3, groupBox3, timer3, labPlayerName3, labTimeTable3);
        }

        private void btnEndTable4_Click(object sender, EventArgs e)
        {
            EndBookingTable((Button)sender, btnPause4, btnStart4, groupBox4, timer4, labPlayerName4, labTimeTable4);
        }

        private void btnEndTable5_Click(object sender, EventArgs e)
        {
            EndBookingTable((Button)sender, btnPause5, btnStart5, groupBox5, timer5, labPlayerName5, labTimeTable5);
        }

        private void btnEndTable6_Click(object sender, EventArgs e)
        {
            EndBookingTable((Button)sender, btnPause6, btnStart6, groupBox6, timer6, labPlayerName6, labTimeTable6);
        }

        private void FrmBilliardClub_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
           // labDate.Text = "* " + DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss ");
            labDate.Text = $"* {DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss ")} ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartTimer(ref Timer1.Seconds, ref Timer1.Minutes, labTimeTable1, btnEndTable1);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            StartTimer(ref Timer2.Seconds, ref Timer2.Minutes, labTimeTable2, btnEndTable2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            StartTimer(ref Timer3.Seconds, ref Timer3.Minutes, labTimeTable3, btnEndTable3);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            StartTimer(ref Timer4.Seconds, ref Timer4.Minutes, labTimeTable4, btnEndTable4);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            StartTimer(ref Timer5.Seconds, ref Timer5.Minutes, labTimeTable5, btnEndTable5);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            StartTimer(ref Timer6.Seconds, ref Timer6.Minutes, labTimeTable6, btnEndTable6);
        }
    }
}
