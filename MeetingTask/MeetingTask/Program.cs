using System;
using Models;

namespace MeetingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();

            Meeting meeting01 = new Meeting {
                Name = "meeting1",
                FromDate = new DateTime(2022, 4, 11, 11, 30, 0),
                ToDate = new DateTime(2022, 4, 11, 12, 0, 0)
            };

            Meeting meeting02 = new Meeting
            {
                Name = "meeting2",
                FromDate = new DateTime(2022, 4, 11, 13, 24, 0),
                ToDate = new DateTime(2022, 4, 11, 15, 0, 0)
             };


            meetingSchedule.Meetings.Add(meeting01);
            meetingSchedule.Meetings.Add(meeting02);
            DateTime from = new DateTime(2022, 1, 11, 10, 24, 0);
            DateTime to = new DateTime(2022, 1, 11, 12, 0, 0);
            meetingSchedule.SetMeeting("meeting3", from, to);

            foreach (var item in meetingSchedule.Meetings)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(meetingSchedule.FindMeetingsCount(new DateTime(2022, 4, 15, 11, 29, 0)));

            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("meeting"));

            foreach (Meeting item in meetingSchedule.GetExistMeetings("meeting"))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
