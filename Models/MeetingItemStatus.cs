using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingTracker.Models
{
    public class MeetingItemStatus
    {
        public int MeetingItemStatusID { get; set; }
        public int MeetingItemID { get; set; }
        public int MeetingID { get; set; }
        public string? ActionRequired { get; set; }
        public string? Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }

        public virtual MeetingItem? MeetingItem { get; set; }
    }
}