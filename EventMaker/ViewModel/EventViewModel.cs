using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {

        private EventCatalogSingleton _eventSingleton;

        public EventCatalogSingleton Eventsingelton
        {
            get { return _eventSingleton; }
            set { _eventSingleton = value; }
        }


        public EventViewModel()
        {
            Eventsingelton = EventCatalogSingleton.Instance;
        }

    }
}

