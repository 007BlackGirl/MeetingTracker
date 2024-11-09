using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingTracker.Models
{
    public class MeetingItem
    {
        public int MeetingItemID { get; set; }
        public int MeetingID { get; set; }
        public string? Description { get; set; }
        public string? PersonResponsible { get; set; }
        public int? CurrentStatusID { get; set; }

        public virtual Meeting? Meeting { get; set; }
    }
}