namespace Clock
{
    partial class Countdown
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.counter_secs = new System.Windows.Forms.NumericUpDown();
            this.counter_minute = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbSecs = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMiliSecs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHours = new System.Windows.Forms.Label();
            this.counter_hours = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.counter_secs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_minute)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counter_hours)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // counter_secs
            // 
            this.counter_secs.Location = new System.Drawing.Point(527, 340);
            this.counter_secs.Name = "counter_secs";
            this.counter_secs.Size = new System.Drawing.Size(64, 26);
            this.counter_secs.TabIndex = 36;
            // 
            // counter_minute
            // 
            this.counter_minute.Location = new System.Drawing.Point(448, 340);
            this.counter_minute.Name = "counter_minute";
            this.counter_minute.Size = new System.Drawing.Size(64, 26);
            this.counter_minute.TabIndex = 35;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(422, 250);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 56);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(422, 250);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(143, 56);
            this.btnContinue.TabIndex = 34;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(422, 250);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(143, 56);
            this.btnPause.TabIndex = 33;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(489, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = ".";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(361, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(228, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(572, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "1/10";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(418, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "secs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(307, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "mins";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(144, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "hours";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.lbMinutes);
            this.panel2.Location = new System.Drawing.Point(262, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 131);
            this.panel2.TabIndex = 25;
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMinutes.Location = new System.Drawing.Point(25, 53);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(47, 35);
            this.lbMinutes.TabIndex = 15;
            this.lbMinutes.Text = "00";
            this.lbMinutes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.lbSecs);
            this.panel3.Location = new System.Drawing.Point(379, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 131);
            this.panel3.TabIndex = 24;
            // 
            // lbSecs
            // 
            this.lbSecs.AutoSize = true;
            this.lbSecs.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSecs.Location = new System.Drawing.Point(28, 53);
            this.lbSecs.Name = "lbSecs";
            this.lbSecs.Size = new System.Drawing.Size(47, 35);
            this.lbSecs.TabIndex = 16;
            this.lbSecs.Text = "00";
            this.lbSecs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.lbMiliSecs);
            this.panel4.Location = new System.Drawing.Point(530, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 131);
            this.panel4.TabIndex = 23;
            // 
            // lbMiliSecs
            // 
            this.lbMiliSecs.AutoSize = true;
            this.lbMiliSecs.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiliSecs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMiliSecs.Location = new System.Drawing.Point(22, 53);
            this.lbMiliSecs.Name = "lbMiliSecs";
            this.lbMiliSecs.Size = new System.Drawing.Size(47, 35);
            this.lbMiliSecs.TabIndex = 17;
            this.lbMiliSecs.Text = "00";
            this.lbMiliSecs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.lbHours);
            this.panel1.Location = new System.Drawing.Point(111, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 131);
            this.panel1.TabIndex = 22;
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbHours.Location = new System.Drawing.Point(31, 53);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(47, 35);
            this.lbHours.TabIndex = 14;
            this.lbHours.Text = "00";
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // counter_hours
            // 
            this.counter_hours.Location = new System.Drawing.Point(372, 341);
            this.counter_hours.Name = "counter_hours";
            this.counter_hours.Size = new System.Drawing.Size(64, 26);
            this.counter_hours.TabIndex = 21;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(240, 340);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(87, 30);
            this.btnSet.TabIndex = 20;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(180, 252);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 56);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 403);
            this.Controls.Add(this.counter_secs);
            this.Controls.Add(this.counter_minute);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.counter_hours);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.counter_secs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_minute)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counter_hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown counter_secs;
        private System.Windows.Forms.NumericUpDown counter_minute;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSecs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMiliSecs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.NumericUpDown counter_hours;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnReset;
    }
}

