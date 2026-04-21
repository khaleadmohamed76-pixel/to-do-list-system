using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Alarm[] alarmList = new Alarm[5];
        int currentAlarmCount = 0;

        public Form1()
        {
            InitializeComponent();
            // تأكد ان التايمر في الديزاين اسمه timer2
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1B2631");
            this.ForeColor = ColorTranslator.FromHtml("#D4AF37");

            if (lstAlarms != null)
            {
                lstAlarms.BackColor = ColorTranslator.FromHtml("#17202A");
                lstAlarms.ForeColor = ColorTranslator.FromHtml("#D4AF37");
                lstAlarms.BorderStyle = BorderStyle.None;
            }

            lblCurrentTime.ForeColor = Color.FromArgb(212, 175, 55);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (currentAlarmCount < 5)
            {
                Alarm newAlarm = new Alarm(dtpTime1.Value, txtMessage1.Text);
                alarmList[currentAlarmCount] = newAlarm;
                currentAlarmCount++;

                string alarmInfo = $"{currentAlarmCount}. {newAlarm.Message} - [{newAlarm.AlarmTime.ToShortTimeString()}]";
                lstAlarms.Items.Add(alarmInfo);

                MessageBox.Show("تم إضافة المنبه بنجاح!");
            }
            else
            {
                MessageBox.Show("القائمة ممتلئة!");
            }
        }

        // ركز هنا: خليتها timer2_Tick عشان تطابق timer2 اللي شغال فوق
        private void timer2_Tick(object sender, EventArgs e)
        {
            // تحديث الساعة
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            // مراقبة المنبهات
            for (int i = 0; i < currentAlarmCount; i++)
            {
                if (!alarmList[i].IsFired &&
                    DateTime.Now.Hour == alarmList[i].AlarmTime.Hour &&
                    DateTime.Now.Minute == alarmList[i].AlarmTime.Minute)
                {
                    alarmList[i].IsFired = true;
                    MessageBox.Show(alarmList[i].Message, "تنبيه المنبه!");
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void lstAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Alarm
    {
        public DateTime AlarmTime { get; set; }
        public string Message { get; set; }
        public bool IsFired { get; set; }

        public Alarm(DateTime time, string msg)
        {
            AlarmTime = time;
            Message = msg;
            IsFired = false;
        }
    }
}