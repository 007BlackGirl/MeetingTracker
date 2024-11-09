using System.ComponentModel.DataAnnotations;

namespace MeetingTracker.Models
{
    public class MeetingType
    {
        public int MeetingTypeID { get; set; }
        public string? TypeName { get; set; }
    }
}