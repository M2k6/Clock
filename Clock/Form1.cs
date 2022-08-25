using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        int hour, minute, secs,secs2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lbHours.Text = counter_hours.Value.ToString();
            lbSecs.Text = counter_secs.Value.ToString();
            lbMinutes.Text = counter_minute.Value.ToString();
            lbMiliSecs.Text = "00";
            btnPause.Visible = false;
            btnContinue.Visible = false;
            btnStart.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            hour = int.Parse(lbHours.Text);
            minute = int.Parse(lbMinutes.Text);
            secs = int.Parse(lbSecs.Text);
            btnStart.Visible = false;
            btnPause.Visible = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnPause.Visible = true;
            btnContinue.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnContinue.Visible = true;
            btnPause.Visible = false;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (counter_hours.Value > 24 || counter_minute.Value > 60 || counter_secs.Value > 60) MessageBox.Show("Sai rồi bạn eii", "Error");
            else
            {
                lbHours.Text = counter_hours.Value.ToString();
                lbMinutes.Text = counter_minute.Value.ToString();
                lbSecs.Text = counter_secs.Value.ToString();
                btnStart.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnStart.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (secs2 > 0) secs2--;
            if (secs2 == 0 && secs == 0 && minute == 0 && hour == 0)
            {
                timer.Stop();
                MessageBox.Show("Finish");
                btnStart.Visible = true;
                btnPause.Visible = false;
            }
            else
            {
                if (secs2 == 0 && secs == 0 && minute == 0 && hour >= 0)
                {
                    hour--;
                    minute = 59;
                    secs = 60;
                    secs2 = 10;
                }
                if (secs2 == 0 && secs == 0 && minute >= 0 && hour == 0)
                {
                    minute--;
                    secs = 60;
                    secs2 = 10;
                }
                if (secs2 == 0 && secs >= 0 && minute == 0 && hour == 0)
                {
                    secs--;
                    secs2 = 10;
                }
                if (secs2 == 0 && secs > 0)
                {
                    secs--;
                    secs2 = 10;
                }
                if (secs == 0 && secs2 == 0)
                {
                    minute--;
                    secs = 60;
                }
                if (minute == 0 && secs == 0 && secs2 == 0)
                {
                    hour--;
                    minute = 59;
                }
            }
            lbHours.Text = hour.ToString();
            lbMiliSecs.Text = secs2.ToString();
            lbMinutes.Text = minute.ToString();
            lbSecs.Text = secs.ToString();
        }
    }
}
