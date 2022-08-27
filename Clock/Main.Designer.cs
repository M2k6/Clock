namespace Clock
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCountdown = new System.Windows.Forms.Button();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCountdown
            // 
            this.btnCountdown.Location = new System.Drawing.Point(279, 223);
            this.btnCountdown.Name = "btnCountdown";
            this.btnCountdown.Size = new System.Drawing.Size(210, 49);
            this.btnCountdown.TabIndex = 0;
            this.btnCountdown.Text = "Countdownn";
            this.btnCountdown.UseVisualStyleBackColor = true;
            this.btnCountdown.Click += new System.EventHandler(this.btnCountdown_Click);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(279, 304);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(210, 49);
            this.btnSetAlarm.TabIndex = 1;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giờ hiện tại :";
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMinute.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMinute.Location = new System.Drawing.Point(354, 103);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(80, 55);
            this.lbMinute.TabIndex = 3;
            this.lbMinute.Text = "00";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHour.ForeColor = System.Drawing.SystemColors.Control;
            this.lbHour.Location = new System.Drawing.Point(177, 103);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(80, 55);
            this.lbHour.TabIndex = 4;
            this.lbHour.Text = "00";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSec.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSec.Location = new System.Drawing.Point(526, 103);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(80, 55);
            this.lbSec.TabIndex = 5;
            this.lbSec.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 403);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.btnCountdown);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountdown;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Timer timer;
    }
}