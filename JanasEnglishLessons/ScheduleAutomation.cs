using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static JanasEnglishLessons.JanasEnglishLessons;
using JanasEnglishLessons.Wrapper;
using System.Globalization;
using JanasEnglishLessons.Entities;

namespace JanasEnglishLessons
{
    public class ScheduleAutomation : IScheduleAutomation
    {
        public List<OutputSchedule> GenerateSchedule(IReadOnlyDictionary<string, PreferredTimeRange> weeklySched)
        {
            var outputScheduleList = new List<OutputSchedule>();
            var processSchedule = ProcessStudentScheduleList(weeklySched);
            var dayNo = 0;
            var counter = 0;
            DateTime timeStart = new DateTime();
            DateTime endTime = new DateTime();
            foreach (var schedule in processSchedule)
            {
                var name = schedule.Name;
                var dayOfWeek = schedule.DayOfWeek;

                DateTime previousEndTime;
                if (dayNo != schedule.DayNo)
                {
                    counter = 0;
                }
               
                if (counter == 0)
                {
                    timeStart = schedule.TimeStartRange;
                    endTime = schedule.TimeStartRange.AddHours(1);
                    previousEndTime = endTime;
                }
                else
                {
                    if(schedule.TimeStartRange > endTime.AddMinutes(15))
                    {
                        timeStart = schedule.TimeStartRange;
                        endTime = timeStart.AddHours(1);
                    }
                    else
                    {
                        timeStart = endTime.AddMinutes(15);
                        endTime = timeStart.AddHours(1);
                    }
                   
                }
               
                var outputSchedule = new OutputSchedule
                {
                    StudentShedule = string.Format("{0} {1}-{2} ({3})", dayOfWeek, timeStart.ToString("HH:mm"), endTime.ToString("HH:mm"), name)
                };
              
                counter++;
                dayNo = schedule.DayNo;
                outputScheduleList.Add(outputSchedule);
            }

            return outputScheduleList;
        }
        public List<StudentSchedule> ProcessStudentScheduleList(IReadOnlyDictionary<string, PreferredTimeRange> weeklySched)
        {
            var studendSchedule = new List<StudentSchedule>();
            foreach (var item in weeklySched)
            {
                var day = item.Key;

                var dayx = item.Value.Weekday;
                var timeStart = Convert.ToDateTime(string.Format("{0}:{1}", item.Value.Start.Hour, item.Value.Start.Min));
                var timeEnd = Convert.ToDateTime(string.Format("{0}:{1}", item.Value.End.Hour, item.Value.End.Min));
                //var time1 = startTime.ToString("hh:mm:ss tt", CultureInfo.CurrentCulture);
                //var time2 = startEnd.ToString("hh:mm:ss tt", CultureInfo.CurrentCulture);
                var studentInfo = new StudentSchedule
                {
                    DayNo = GetDayNumber(item.Value.Weekday.ToString()),
                    Name = item.Key,
                    DayOfWeek = item.Value.Weekday.ToString(),
                    TimeStartRange = timeStart,
                    TimeEndRange = timeEnd
                };
                studendSchedule.Add(studentInfo);
                /*
                 string time = "16:23:01";
                var result = Convert.ToDateTime(time);
                string test = result.ToString("hh:mm:ss tt", CultureInfo.CurrentCulture);

                 */
            }
            return studendSchedule.OrderBy(a => a.DayNo).ThenBy(a => a.TimeStartRange).ThenBy(a => a.TimeEndRange).ToList();
        }
        public int GetDayNumber(string DayOfWeek)
        {
            var day = 0;
            switch (DayOfWeek)
            {

                case "Mon":
                    day = 1;
                    break;

                case "Tue":
                    day = 2;
                    break;
                case "Wed":
                    day = 3;
                    break;
                case "Thu":
                    day = 4;
                    break;
                case "Fri":
                    day = 5;
                    break;
            }
            return day;
        }
    }
}
