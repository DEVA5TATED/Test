using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class EventList
    {
        private string _weekend;
        private List<Event> _events;

        public EventList(string weekend, List<Event> events)
        {
            this._weekend = weekend;
            this._events = events;
        }
        public string GetWeekend()
        {
            return _weekend;
        }
        public List<Event> GetEvents()
        {
            return _events;
        }
    }
}
