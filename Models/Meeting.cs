using System;
using System.ComponentModel.DataAnnotations;
using MeetingTracker.Models;

namespace MeetingTracker.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }
        public int MeetingTypeID { get; set; }
        public string? MeetingNumber { get; set; }
        public DateTime MeetingDate { get; set; }
        public int PreviousMeetingID { get; set; }

        public virtual MeetingType? MeetingType { get; set; }
        public virtual ICollection<MeetingItem>? MeetingItems { get; set; }
    }
}
