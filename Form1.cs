using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class Form1 : Form
    {

        CustomAlarm customAlarm = new CustomAlarm();

        public Form1()
        {
            InitializeComponent();

            if (File.Exists("..\\..\\alarms.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\alarms.txt");
                while (!sr.EndOfStream && AlarmsList.Items.Count < 6)
                {
                    string alarmsFromFile = sr.ReadLine();
                    if (alarmsFromFile != "" && alarmsFromFile != null && alarmsFromFile.Length > 2)
                    {
                        Alarm n = new Alarm();

                        n.time = DateTime.Parse(alarmsFromFile.ToLower().Split('m')[0] + "m");

                        if (alarmsFromFile.Contains("Off"))
                            n.on = false;
                        else
                            n.on = true;

                        customAlarm.alarms.Add(n);
                        UpdateAlarms();
                    }
                }
                sr.Dispose();
                sr.Close();
            }


            Timer checkTimer = new Timer();

            checkTimer.Tick += new EventHandler(checkTime);
            checkTimer.Interval = 1000;
            checkTimer.Enabled = true;
        }

        private void checkTime(object source, EventArgs e)
        {
            string n = DateTime.Now.ToString("h:mm tt").ToLower();

            bool ring = false;
            bool ring2 = false;

            foreach (string a in AlarmsList.Items)
            {
                if (a.Contains("RINGING"))
                    ring2 = true;
                if (a.Contains("Running") && isTime(a, n))
                {
                    ring = true;
                    TextMessage.Text = "ALARM RINGING";
                    foreach (Alarm b in customAlarm.alarms)
                        if (b.time.ToString("h:mm tt ").ToLower().Split('m')[0] == a.ToString().Split('m')[0])
                            b.ringing = true;
                }
                if (a.Contains("Snoozing"))
                {
                    foreach (Alarm b in customAlarm.alarms)
                        if (b.time.ToString("h:mm tt ").ToLower().Split('m')[0] == a.ToString().Split('m')[0])
                        {
                            if (DateTime.Now >= b.snoozeTime.AddMilliseconds(3000))
                            {
                                b.ringing = true;
                                b.snoozed = false;
                                ring = true;
                                TextMessage.Text = "ALARM RINGING";
                            }
                            break;
                        }
                }
            }

            if (ring)
                UpdateAlarms();
            else if (!ring2)
                TextMessage.Text = "";

        }

        private bool isTime(string t, string n)
        {
            t = t.ToLower().Split('m')[0] + "m";
            if (t == n)
                return true;
            else
                return false;
        }

        private void RemoveAlarm(Alarm a)
        {
            foreach (Alarm b in customAlarm.alarms)
            {
                if (b.time.ToString("h:mm tt ").ToLower().Split('m')[0] == a.ToString().ToLower().Split('m')[0])
                {
                    customAlarm.alarms.Remove(b);
                    break;
                }
            }
            UpdateAlarms();
        }

        private void AddAlarm(object sender, EventArgs e)
        {
            if (AlarmsList.Items.Count < 6)
            {
                customAlarm.setNow();

                customAlarm.Show();
            }
            else
                ButtonAdd.Enabled = false;
        }

        private void AlarmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkState();
        }

        private void UpdateList(object sender, EventArgs e)
        {
            UpdateAlarms();
        }

        private void UpdateAlarms()
        {
            AlarmsList.Items.Clear();

            bool ring = false;

            foreach (Alarm a in customAlarm.alarms)
            {
                AlarmsList.Items.Add(a.ToString());
                if (a.ringing)
                    ring = true;
            }
            if (!ring)
                TextMessage.Text = "";
            if (AlarmsList.Items.Count >= 5)
                ButtonAdd.Enabled = false;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (AlarmsList.SelectedIndex != -1)
            {
                customAlarm.setTime(AlarmsList.SelectedIndex);

                foreach (Alarm a in customAlarm.alarms)
                {
                    if (a.time.ToString("h:mm tt ").ToLower().Split('m')[0] == AlarmsList.SelectedItem.ToString().ToLower().Split('m')[0])
                    {
                        customAlarm.alarms.Remove(a);
                        break;
                    }
                }
                customAlarm.Show();
            }
            else
                checkState();
        }

        private void checkState()
        {
            ButtonStop.Text = "Stop";

            if (AlarmsList.SelectedIndex == -1)
            {
                ButtonEdit.Enabled = false;
                ButtonStop.Enabled = false;
                ButtonSnooze.Enabled = false;
            }
            else
            {
                ButtonEdit.Enabled = true;

                if (AlarmsList.SelectedItem.ToString().Contains("RINGING"))
                {
                    ButtonStop.Enabled = true;
                    ButtonSnooze.Enabled = true;
                }
                else
                {
                    ButtonStop.Enabled = false;
                    ButtonSnooze.Enabled = false;

                }

                //  if (AlarmsList.SelectedItem.ToString().Contains("Stopped"))
                //       ButtonStop.Text = "Start";

            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            foreach (Alarm a in customAlarm.alarms)
            {
                if (a.time.ToString("h:mm tt ").ToLower().Split('m')[0] == AlarmsList.SelectedItem.ToString().Split('m')[0])
                {
                    //if (ButtonStop.Text == "Stop")
                    a.stopped = true;
                    /*else
                    {
                        a.stopped = false;
                        a.on = true;
                        ButtonStop.Text = "Stop";
                    }*/

                    break;
                }
            }
            UpdateAlarms();
        }

        private void ButtonSnooze_Click(object sender, EventArgs e)
        {
            foreach (Alarm a in customAlarm.alarms)
            {
                if (a.time.ToString("h:mm tt ").ToLower().Split('m')[0] == AlarmsList.SelectedItem.ToString().Split('m')[0])
                {
                    a.snoozed = true;
                    a.snoozeTime = DateTime.Now;
                }
            }
            UpdateAlarms();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!File.Exists("..\\..\\alarms.txt"))
                File.Create("..\\..\\alarms.txt").Dispose();

            StreamWriter sw = new StreamWriter("..\\..\\alarms.txt");
            foreach (string s in AlarmsList.Items)
            {
                sw.WriteLine(s);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
