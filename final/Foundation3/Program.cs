using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address lectureAddress = new Address("123 Lecture St", "Lecture City", "Lecture State", "12345");
            Address receptionAddress = new Address("456 Reception St", "Reception City", "Reception State", "67890");
            Address outdoorGatheringAddress = new Address("789 Outdoor St", "Outdoor City", "Outdoor State", "98765");

            // Create events
            Event lecture = new Lecture("Interesting Topic", "Engaging lecture on a fascinating subject", DateTime.Now, new TimeSpan(18, 0, 0), lectureAddress, "John Doe", 50);
            Event reception = new Reception("Networking Event", "Casual reception for professionals to connect", DateTime.Now.AddDays(7), new TimeSpan(19, 0, 0), receptionAddress, "rsvp@example.com");
            Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Relaxing day out in nature with friends", DateTime.Now.AddDays(14), new TimeSpan(12, 0, 0), outdoorGatheringAddress, "Sunny with a chance of clouds");

            // Generate messages
            Console.WriteLine("Standard Messages:");
            Console.WriteLine(lecture.GenerateStandardMessage());
            Console.WriteLine(reception.GenerateStandardMessage());
            Console.WriteLine(outdoorGathering.GenerateStandardMessage());

            Console.WriteLine("\nFull Messages:");
            Console.WriteLine(lecture.GenerateFullMessage());
            Console.WriteLine(reception.GenerateFullMessage());
            Console.WriteLine(outdoorGathering.GenerateFullMessage());

            Console.WriteLine("\nShort Descriptions:");
            Console.WriteLine(lecture.GenerateShortDescription());
            Console.WriteLine(reception.GenerateShortDescription());
            Console.WriteLine(outdoorGathering.GenerateShortDescription());
        }
    }
}
