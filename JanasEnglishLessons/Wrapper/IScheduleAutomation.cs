using JanasEnglishLessons.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static JanasEnglishLessons.JanasEnglishLessons;

namespace JanasEnglishLessons.Wrapper
{
    public interface IScheduleAutomation
    {
        List<OutputSchedule> GenerateSchedule(IReadOnlyDictionary<string, PreferredTimeRange> weeklySched);
        List<StudentSchedule> ProcessStudentScheduleList(IReadOnlyDictionary<string, PreferredTimeRange> weeklySched);
        int GetDayNumber(string DayOfWeek);
    }
}
