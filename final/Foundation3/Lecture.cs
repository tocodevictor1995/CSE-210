using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public string Speaker { get => speaker; set => speaker = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) 
            : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GenerateFullMessage()
        {
            return $"{base.GenerateFullMessage()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }
    }
}
