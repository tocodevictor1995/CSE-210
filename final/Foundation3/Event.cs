using System;

namespace EventPlanning
{
    public class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private TimeSpan time;
        private Address address;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public Address Address { get => address; set => address = value; }

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public virtual string GenerateStandardMessage()
        {
            return $"Event: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
        }

        public virtual string GenerateFullMessage()
        {
            return GenerateStandardMessage();
        }

        public virtual string GenerateShortDescription()
        {
            return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
