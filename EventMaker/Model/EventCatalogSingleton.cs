using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance;

        public static EventCatalogSingleton Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new EventCatalogSingleton();
                }
                return _instance;
            }
        }


        public ObservableCollection<Event> Events { get; set; }


        private EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>();
        }

        public void addEvent(Event MyEvent)
        {
            this.Events.Add(MyEvent);
        }
    }
}
