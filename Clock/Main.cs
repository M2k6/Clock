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
    public partial class Main : Form
    {
        /*
        Countdown countdown = new Countdown();
        Alarm alarm = new Alarm();
        */
        public Main()
        {
            InitializeComponent();
            timer.Start();
        }
        private void btnCountdown_Click(object sender, EventArgs e)
        {
            /*
            countdown.Show();
            this.Hide();
            */
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour - 10 < 0)
            lbHour.Text = '0' + DateTime.Now.Hour.ToString();
            else lbHour.Text = DateTime.Now.Hour.ToString();
            if (DateTime.Now.Minute - 10 < 0)
            lbMinute.Text = '0' + DateTime.Now.Minute.ToString();
            else lbMinute.Text = DateTime.Now.Minute.ToString();
            if (DateTime.Now.Second - 10 < 0)
            lbSec.Text = '0' + DateTime.Now.Second.ToString();
            else lbSec.Text = DateTime.Now.Second.ToString();
            
        }
        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            /*
            alarm.Show();
            this.Hide();
            */
        }
    }
}
