﻿using System;

namespace Timotheus.Schedule
{
    public class Event
    {
        private string name;
        private string description;
        private string location;

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Changed;
        public DateTime Created;

        public string Name { get { return name;  } set { name = value.Replace("\r\n", ""); Changed = DateTime.Now; } }
        public string Description { get { return description; } set { description = value; Changed = DateTime.Now; } }
        public string Location { get { return location; } set { location = value.Replace("\r\n", ""); Changed = DateTime.Now; } }
        public readonly string UID;
        public bool Deleted;

        //Constructors
        public Event(DateTime StartTime, DateTime EndTime, DateTime Created, string Name, string Description, string Location, string UID)
        {
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Created = Created;
            this.Name = Name;
            this.Location = Location;
            this.Description = Description;
            Changed = Created;
            Deleted = false;
            if (UID == null)
                this.UID = GenerateUID();
            else
                this.UID = UID;
        }
        public Event(DateTime StartTime, DateTime EndTime, string Name, string Description, string Location, string UID) : this(StartTime, EndTime, DateTime.Now, Name, Description, Location, UID) { }
        public Event(DateTime StartTime, DateTime EndTime, string Name, string Description, string UID) : this(StartTime, EndTime, DateTime.Now, Name, Description, null, UID) { }
        public Event(DateTime StartTime, DateTime EndTime, string Name, string Description) : this(StartTime, EndTime, DateTime.Now, Name, Description, null, null) { }

        //Generates an unique ID for the event to be used on the remote calendar.
        public static string GenerateUID()
        {
            byte[] data = new byte[16];
            Random rnd = new Random();
            rnd.NextBytes(data);
            string tempUID = BitConverter.ToString(data).Replace("-", "");
            string UID = tempUID.Substring(0,8) + "-" + tempUID.Substring(8,4) + "-" + tempUID.Substring(12, 4) + "-" + tempUID.Substring(16, 4) + "-" + tempUID.Substring(20, 12);
            return UID;
        }

        //Updates the variables of this event with the variables of a separate event ev.
        public void Update(Event ev)
        {
            if (UID == ev.UID)
            {
                Name = ev.Name;
                Description = ev.Description;
                Location = ev.Location;
                StartTime = ev.StartTime;
                EndTime = ev.EndTime;
                Created = ev.Created;
            }
        }

        //Checks if another object has the same values as this.
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Event @event)
            {
                Event ev = @event;
                equals = StartTime.Equals(ev.StartTime) && EndTime.Equals(ev.EndTime) && Created.Equals(ev.Created) && Name.Equals(ev.Name) && Description.Equals(ev.Description) && Location.Equals(ev.Location) && UID == ev.UID;
            }
            return equals;
        }

        //Returns the hash code of this.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}