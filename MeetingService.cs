using System;
using System.Linq;
using MeetingTracker.Models;

namespace MeetingTracker
{
    public class MeetingService
    {
        public void CreateNewMeeting(int previousMeetingID, string meetingNumber, int meetingTypeID)
        {
            using (var context = new MeetingContext())
            {
                var meeting = new Meeting
                {
                    MeetingNumber = meetingNumber,
                    MeetingDate = DateTime.Now,
                    MeetingTypeID = meetingTypeID,
                    PreviousMeetingID = previousMeetingID
                };

                context.Meeting.Add(meeting);
                context.SaveChanges();

                var meetingItems = context.MeetingItem
                    .Where(mi => mi.MeetingID == previousMeetingID)
                    .ToList();

                foreach (var item in meetingItems)
                {
                    context.MeetingItem.Add(new MeetingItem
                    {
                        MeetingID = meeting.MeetingID,
                        Description = item.Description,
                        PersonResponsible = item.PersonResponsible,
                        CurrentStatusID = item.CurrentStatusID
                    });
                }

                context.SaveChanges();
                Console.WriteLine("Meeting created successfully.");
            }
        }
    }    
}
