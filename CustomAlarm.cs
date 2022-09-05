using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class CustomAlarm : Form
    {
        public List<Alarm> alarms = new List<Alarm>();

        public CustomAlarm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            Alarm a = new Alarm();
            a.time = TimePick.Value;
            a.on = BoxOn.Checked;

            bool found = false;

            foreach(Alarm b in alarms)
            {
                if (b.ToString().ToLower().Split('m')[0] == a.ToString().ToLower().Split('m')[0])
                {
                    MessageBox.Show("Alarm already exists.");
                    found = true;
                    break;
                }
            }

            if(!found)
               alarms.Add(a);

            Hide();
        }

        public void setTime(int ind)
        {
            TimePick.Value = alarms[ind].time;
        }

        public void setNow()
        {
            DateTime now = DateTime.Now;

            TimePick.Value = now;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
