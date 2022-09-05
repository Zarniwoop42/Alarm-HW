using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    public class Alarm
    {
        public DateTime time;
        public DateTime currentCount;
        public bool on;
        public bool snoozed;
        public bool stopped;
        public bool ringing;

        public DateTime snoozeTime;

        public override string ToString()
        {

            string s = time.ToString("h:mm tt ").ToLower();

            if (snoozed)
            {
                s += " Snoozing";
            }
            else if(stopped){
                s += " Stopped";
            }
            else if(ringing){
                s += " RINGING";
            }
            else
            {
                if (on)
                    s += " Running";
                else
                    s += " Off";
            }

            return s;
        }

    }
}
