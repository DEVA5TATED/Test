using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Application
    {
        private Application _application;
        private List<EventList> _eventLists;
        private string _name = "Имя";

        public Application(List<EventList> eventLists)
        {
            this._eventLists = eventLists;
        }

        public Application GetApplication()
        {
            return _application;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
