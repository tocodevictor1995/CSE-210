using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string rsvpEmail;

        public string RsvpEmail { get => rsvpEmail; set => rsvpEmail = value; }

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) 
            : base(title, description, date, time, address)
        {
            RsvpEmail = rsvpEmail;
        }

        public override string GenerateFullMessage()
        {
            return $"{base.GenerateFullMessage()}\nRSVP Email: {RsvpEmail}";
        }
    }
}
