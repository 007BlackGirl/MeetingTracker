
using System;

namespace MeetingTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var meetingService = new MeetingService();
            var statusService = new StatusService();

            Console.WriteLine("1. Create New Meeting");
            Console.WriteLine("2. Update Meeting Item Status");
            Console.Write("Select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter Previous Meeting ID: ");
                    int previousMeetingID = int.Parse(Console.ReadLine());
                    Console.Write("Enter Meeting Number: ");
                    string meetingNumber = Console.ReadLine();
                    Console.Write("Enter Meeting Type ID: ");
                    int meetingTypeID = int.Parse(Console.ReadLine());
                    meetingService.CreateNewMeeting(previousMeetingID, meetingNumber, meetingTypeID);
                    break;

                case "2":
                    Console.Write("Enter Meeting Item ID: ");
                    int meetingItemID = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Status: ");
                    string newStatus = Console.ReadLine();
                    Console.Write("Enter Action Required: ");
                    string actionRequired = Console.ReadLine();
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate = DateTime.Parse(Console.ReadLine());
                    statusService.UpdateMeetingItemStatus(meetingItemID, newStatus, actionRequired, dueDate);
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
