using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.ViewModel;
using EventMaker.Persistency;
using EventMaker.Model;
using EventMaker.Converter;

namespace EventMaker.Handler
{
    class myEventHandler
    {
        /*Properties*/
        public EventViewModel EventViewModel { get; set; }
        //public PersistencyService PersistenctService { get; set; }


        /*Constroctur*/
        public myEventHandler(EventViewModel evm)
        {
            this.EventViewModel = evm;
            //this.PersistenctService = ps;
        }

        /*Metodes*/
        public void CreateEvent()
        {
            Event nyEvent = new Event(EventViewModel.Id, EventViewModel.Name, EventViewModel.Description, EventViewModel.Place, DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventViewModel._date, EventViewModel._time));
            EventCatalogSingleton.Instance.Events.Add(nyEvent);

            PersistencyService.GemDataTilAsync();
        }
    }
}
