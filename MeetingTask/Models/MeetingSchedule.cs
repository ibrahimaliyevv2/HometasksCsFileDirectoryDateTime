using System;
using System.Collections.Generic;

namespace Models
{
    public class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();

        public void SetMeeting(string name, DateTime from, DateTime to)
        {
            if(!Meetings.Exists(x=>x.FromDate<from && x.ToDate > to){
                Meetings.Add(new Meeting {Name=name,FromDate=from, ToDate=to });
            }
            else
            {
                throw new Exception("exception occured");
            }
        }

        public int FindMeetingsCount(DateTime date)
        {
            return Meetings.FindAll(x => x.FromDate > date).Count;
        }

        public bool IsExistsMeetingByName(string name)
        {
            return Meetings.Exists(x => x.Name == name);
        }

        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(x => x.Name.Contains(name));
        }
    }
}
