﻿using EventSeller.DataLayer.Entities;

namespace DataLayer.Model
{
    public class Event
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long EventTypeID { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual ICollection<EventSession> EventSessions { get; set; }
        public DateTime? StartEventDateTime { get; set; }
        public DateTime? EndEventDateTime { get; set; }
    }
}
