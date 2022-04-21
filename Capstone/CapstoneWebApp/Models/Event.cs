using System;
using System.Collections.Generic;

namespace CapstoneWebApp.Models
{
    public class Event
    {
        public class EventData
        {
            public string _id { get; set; }
            public string ap { get; set; }
            public string ap_displayName { get; set; }
            public string site_id { get; set; }
            public string ap_model { get; set; }
            public string ap_name { get; set; }
            public long bytes { get; set; }
            public DateTime datetime { get; set; }
            public int duration { get; set; }
            public string hostname { get; set; }
            public bool is_negative { get; set; }
            public string key { get; set; }
            public string msg { get; set; }
            public string ssid { get; set; }
            public string subsystem { get; set; }
            public object time { get; set; }
            public string user { get; set; } // mac id of user 
            public string channel { get; set; }
            public string radio { get; set; }
            public string channel_from { get; set; }
            public string channel_to { get; set; }

        }

        public class Events
        {
            public List<EventData> data { get; set; }
        }
    }
}
