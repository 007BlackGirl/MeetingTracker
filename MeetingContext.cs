using Microsoft.EntityFrameworkCore;
using MeetingTracker.Models;

namespace MeetingTracker
{
    public class MeetingContext : DbContext
    {
        public DbSet<MeetingType> MeetingType { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<MeetingItem> MeetingItem { get; set; }
        public DbSet<MeetingItemStatus> MeetingItemStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MeetingTrackerDB;User Id=sa;Password=dockerStrongPwd123;;TrustServerCertificate=true");
        }
    }
}