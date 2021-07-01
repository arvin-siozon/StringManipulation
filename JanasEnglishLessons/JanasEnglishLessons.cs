using JanasEnglishLessons.Wrapper;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace JanasEnglishLessons
{
    public class JanasEnglishLessons
    {
        private readonly ITestOutputHelper _output;
     
        public JanasEnglishLessons(ITestOutputHelper output)
        {
            _output = output;

        }

        [Fact]
        public void TestWeek1()
        {
            IScheduleAutomation scheduleAutomation = new ScheduleAutomation();
            var lessonSchedule = scheduleAutomation.GenerateSchedule(Week1);
            foreach(var sched in lessonSchedule)
            {
                _output.WriteLine(sched.StudentShedule);
            }
            /*
    
            Jana is a professional English teacher which offers private lessons to her students
            and is annoyed about having to manually plan her week schedule.

            Please help her automating this.
    
            * Allocate for each student a lesson of exactly one hour in the student's preferred time range.

            * Note that Jana likes to have a break of 15 minutes between her lessons. Fulfill her wish.

            => Write a function which takes a `IReadOnlyDictionary<string, PreferredTimeRange>` (see below) and 
            produces a schedule like the following (text format):

            Example for Week1 (see below):
    
              Tue 12:00-13:00 (Isabel)
              Wed 11:00-12:00 (July)
              Wed 12:15-13:15 (Rupert)
              Wed 16:30-17:30 (Patrick)
              Thu 11:00-12:00 (Ulrich)


            => Code this in a test driven way (use also more examples, like `Week2`, or additional ones). Also think
               about edge / error cases.



            BONUS: You could make her even happier if you optimize her schedule by grouping the lessons together (and
            still respect the student's time constraints and the 15 minutes break). For example in `Week1` to start
            later at Wed, avoiding the gap:

              ...
              Wed 14:00-15:00 (July)
              Wed 15:15-16:15 (Rupert)
              Wed 16:30-17:30 (Patrick)
              ...
    
            */
        }
        [Fact]
        public void TestWeek2()
        {
            IScheduleAutomation scheduleAutomation = new ScheduleAutomation();
            var lessonSchedule = scheduleAutomation.GenerateSchedule(Week2);
            foreach (var sched in lessonSchedule)
            {
                _output.WriteLine(sched.StudentShedule);
            }
           
        }
        [Fact]
        public void TestWeek3()
        {
            IScheduleAutomation scheduleAutomation = new ScheduleAutomation();
            var lessonSchedule = scheduleAutomation.GenerateSchedule(Week3);
            foreach (var sched in lessonSchedule)
            {
                _output.WriteLine(sched.StudentShedule);
            }

        }
        public IReadOnlyDictionary<string, PreferredTimeRange> Week1 =
            new Dictionary<string, PreferredTimeRange>
            {
              {
                    "July",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(11, 00), new TimeOfDay(17, 00))
                },
                {
                    "Patrick",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(16, 30), new TimeOfDay(18, 00))
                },
                {
                    "Rupert",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(11, 15), new TimeOfDay(20, 00))
                },
                {
                    "Isabel",
                    new PreferredTimeRange(Weekday.Tue, new TimeOfDay(12, 00), new TimeOfDay(16, 00))
                },
                {
                    "Ulrich",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(11, 00), new TimeOfDay(18, 00))
                },
            };

        public IReadOnlyDictionary<string, PreferredTimeRange> Week2 =
            new Dictionary<string, PreferredTimeRange>
            {
                {
                    "Andreas",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(16, 00), new TimeOfDay(20, 00))
                },
                {
                    "Isabel",
                    new PreferredTimeRange(Weekday.Mon, new TimeOfDay(15, 30), new TimeOfDay(20, 00))
                },
                {
                    "July",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(8, 00), new TimeOfDay(12, 00))
                },
                {
                    "Patrick",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(8, 30), new TimeOfDay(11, 00))
                },
                {
                    "Ulrich",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(15, 00), new TimeOfDay(21, 00))
                },
            };
        public IReadOnlyDictionary<string, PreferredTimeRange> Week3 =
         new Dictionary<string, PreferredTimeRange>
         {
               {
                    "July",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(11, 00), new TimeOfDay(17, 00))
                },
                 {
                    "Brad",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(11, 00), new TimeOfDay(14, 00))
                },
                  {
                    "Dude",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(11, 00), new TimeOfDay(13, 00))
                },
                {
                    "Patrick",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(16, 30), new TimeOfDay(18, 00))
                },
                {
                    "Rupert",
                    new PreferredTimeRange(Weekday.Wed, new TimeOfDay(11, 15), new TimeOfDay(20, 00))
                },

                {
                    "Isabel",
                    new PreferredTimeRange(Weekday.Tue, new TimeOfDay(12, 00), new TimeOfDay(16, 00))
                },
                 {
                    "Jade",
                    new PreferredTimeRange(Weekday.Tue, new TimeOfDay(12, 00), new TimeOfDay(18, 00))
                },
                  {
                    "Rave",
                    new PreferredTimeRange(Weekday.Tue, new TimeOfDay(11, 00), new TimeOfDay(13, 00))
                },

                {
                    "Ulrich",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(11, 00), new TimeOfDay(15, 00))
                },
                 {
                    "Dave",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(12, 00), new TimeOfDay(14, 00))
                },
                  {
                    "John",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(14, 00), new TimeOfDay(15, 30))
                },
                  {
                    "Rein",
                    new PreferredTimeRange(Weekday.Thu, new TimeOfDay(14, 00), new TimeOfDay(16, 00))
                },
                   {
                    "Jerry",
                    new PreferredTimeRange(Weekday.Fri, new TimeOfDay(13, 00), new TimeOfDay(15, 00))
                },
                 {
                    "Remi",
                    new PreferredTimeRange(Weekday.Fri, new TimeOfDay(01, 00), new TimeOfDay(14, 00))
                },
                  {
                    "Ron",
                    new PreferredTimeRange(Weekday.Fri, new TimeOfDay(09, 00), new TimeOfDay(11, 30))
                },
                  {
                    "Dong",
                    new PreferredTimeRange(Weekday.Fri, new TimeOfDay(10, 00), new TimeOfDay(12, 00))
                },

                  {
                    "Ben",
                    new PreferredTimeRange(Weekday.Mon, new TimeOfDay(13, 00), new TimeOfDay(15, 00))
                },
                 {
                    "Drew",
                    new PreferredTimeRange(Weekday.Mon, new TimeOfDay(10, 00), new TimeOfDay(12, 00))
                },
                  {
                    "Ryan",
                    new PreferredTimeRange(Weekday.Mon, new TimeOfDay(09, 00), new TimeOfDay(11, 30))
                },
                  {
                    "Theo",
                    new PreferredTimeRange(Weekday.Mon, new TimeOfDay(10, 00), new TimeOfDay(12, 30))
                },


         };
        public class PreferredTimeRange
        {
            public Weekday Weekday { get; }
            public TimeOfDay Start { get; }
            public TimeOfDay End { get; }

            public PreferredTimeRange(Weekday weekday, TimeOfDay start, TimeOfDay end)
            {
                Weekday = weekday;
                Start = start;
                End = end;
            }
        }

        public class TimeOfDay
        {
            public int Hour { get; }
            public int Min { get; }

            public TimeOfDay(int hour, int min)
            {
                Hour = hour;
                Min = min;
            }
        }

        public enum Weekday
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
        }
    }
}