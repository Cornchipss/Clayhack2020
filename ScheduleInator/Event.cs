﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleInator
{
    [Serializable]
    public class Event
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public CustomTime SpecifiedTime { get; set; }

        public DateTime? dueDate;

        public int ETA { get; set; }

        public Event(string name, DateTime? dueDate, CustomTime specifiedTime )
        {
            this.SpecifiedTime = specifiedTime;
            this.Name = name;
            this.dueDate = dueDate;
        }

        public Event(string name, string type, int eta)
        {
            this.Type = type;
            this.Name = name;
            this.ETA = eta;
        }

        public void ModifyTime(int day, Time time)
        {
            //this.specifiedTime.addTimeToDay(day, time);
        }
    }
}
