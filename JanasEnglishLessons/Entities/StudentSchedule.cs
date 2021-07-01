using System;
using System.Collections.Generic;
using System.Text;

namespace JanasEnglishLessons
{
    public class StudentSchedule
    {
        public string Name { get; set; }
        public int DayNo { get; set; }
        public string DayOfWeek { get; set; }
        public DateTime TimeStartRange { get; set; }
        public DateTime TimeEndRange { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
