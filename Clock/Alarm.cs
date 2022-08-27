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
    public partial class Alarm : Form
    {
        Main main = new Main();
        int hour, minute;
        public Alarm()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Calendar.Visible = false;
            btnChoose.Visible = false;
            btnUp.Visible = true;
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            Calendar.Visible = true;
            btnChoose.Visible = true;
            btnUp.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(hours.Text) > 24 || int.Parse(minutes.Text) > 60)
            {
                MessageBox.Show("Your wrong alarm", "Error");
            }
            else if (DateTime.Now.Day == Calendar.SelectionEnd.Day && DateTime.Now.Hour > Calendar.SelectionEnd.Hour || DateTime.Now.Day == Calendar.SelectionEnd.Day && DateTime.Now.Hour == Calendar.SelectionEnd.Hour && DateTime.Now.Minute > Calendar.SelectionEnd.Minute)
            {
                MessageBox.Show("Your wrong alarm", "Error");
            }
            else
            {
                DateTime time = new DateTime(Calendar.SelectionEnd.Year, Calendar.SelectionEnd.Month, Calendar.SelectionEnd.Day, int.Parse(hours.Text), int.Parse(minutes.Text), 0);
                TimeSpan time_subtract = time.Subtract(Calendar.TodayDate);
                if (time_subtract.Hours < 10)
                {
                    lbHour.Text = '0' + time_subtract.Hours.ToString();
                }
                else if (time_subtract.Minutes < 10)
                {
                    lbMinute.Text = '0' + time_subtract.Minutes.ToString();
                }
                else
                {
                    lbHour.Text = time_subtract.Hours.ToString();
                    lbMinute.Text = time_subtract.Minutes.ToString();
                    hour = time_subtract.Hours;
                    minute = time_subtract.Minutes;
                    timer.Start();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (minute == 0 && hour == 0) { timer.Stop(); }
            if (minute > 0) minute--;
            if (minute == 0)
            {
                minute = 59;
                hour--;
            }
            if (hour < 10) lbHour.Text = '0' + hour.ToString();
            else lbHour.Text = hour.ToString();
            if (minute < 10) lbMinute.Text = '0' + minute.ToString();
            else if (minute > 10) lbMinute.Text = minute.ToString();
        }
    }
}
