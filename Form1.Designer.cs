namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTime1 = new System.Windows.Forms.DateTimePicker();
            this.txtMessage1 = new System.Windows.Forms.TextBox();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lstAlarms = new System.Windows.Forms.ListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(287, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "اختر وقت التنبيه";
            // 
            // dtpTime1
            // 
            this.dtpTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime1.Location = new System.Drawing.Point(31, 73);
            this.dtpTime1.Name = "dtpTime1";
            this.dtpTime1.ShowUpDown = true;
            this.dtpTime1.Size = new System.Drawing.Size(200, 27);
            this.dtpTime1.TabIndex = 1;
            // 
            // txtMessage1
            // 
            this.txtMessage1.Location = new System.Drawing.Point(31, 147);
            this.txtMessage1.Multiline = true;
            this.txtMessage1.Name = "txtMessage1";
            this.txtMessage1.Size = new System.Drawing.Size(200, 27);
            this.txtMessage1.TabIndex = 2;
            this.txtMessage1.Text = "Name Of Alarm";
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(31, 247);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(200, 36);
            this.btnStart1.TabIndex = 3;
            this.btnStart1.Text = "Set Alarm";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lstAlarms
            // 
            this.lstAlarms.FormattingEnabled = true;
            this.lstAlarms.ItemHeight = 19;
            this.lstAlarms.Location = new System.Drawing.Point(319, 147);
            this.lstAlarms.Name = "lstAlarms";
            this.lstAlarms.Size = new System.Drawing.Size(161, 156);
            this.lstAlarms.TabIndex = 4;
            this.lstAlarms.SelectedIndexChanged += new System.EventHandler(this.lstAlarms_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(26, 4);
            this.checkedListBox2.TabIndex = 5;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblCurrentTime.Location = new System.Drawing.Point(118, 9);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(245, 58);
            this.lblCurrentTime.TabIndex = 6;
            this.lblCurrentTime.Text = "00:00:00";
            this.lblCurrentTime.Click += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(346, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Alarms";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.lstAlarms);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.txtMessage1);
            this.Controls.Add(this.dtpTime1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTime1;
        private System.Windows.Forms.TextBox txtMessage1;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox lstAlarms;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label label3;
    }
}

