using System;
using MeetingTracker.Models;

namespace MeetingTracker
{
    public class StatusService
    {
        public void UpdateMeetingItemStatus(int meetingItemID, string newStatus, string actionRequired, DateTime? dueDate)
        {
            using (var context = new MeetingContext())
            {
                var meetingItem = context.MeetingItem.Find(meetingItemID);
                if (meetingItem != null)
                {
                    var newStatusEntry = new MeetingItemStatus
                    {
                        MeetingItemID = meetingItem.MeetingItemID,
                        MeetingID = meetingItem.MeetingID,
                        ActionRequired = actionRequired,
                        Status = newStatus,
                        DueDate = dueDate
                    };

                    context.MeetingItemStatus.Add(newStatusEntry);
                    context.SaveChanges();
                    Console.WriteLine("Meeting item status updated successfully.");
                }
                else
                {
                    Console.WriteLine("Meeting item not found.");
                }
            }
        }
    }
}
