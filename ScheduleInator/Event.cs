﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomTime;

namespace ScheduleInator
{
    class Event
    {
        private int startTime { get; set; }
        private int endTime { get; set; }
        private string name { get; set; }
        private string type { get; set; }
        private int dueDate { get; set; }

        public Event(int startTime, int endTime, string name, string type, int dueDate, CustomTime specifiedTime,CustomTime dueDate )
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.name = name;
            this.type = type;
            this.dueDate = dueDate;
        }

        public ModifyTime(int day, Time time)
        {
            this.specifiedTime.addTimeToDay(day, time)
        }
    }
}
