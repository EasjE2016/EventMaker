using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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


        /// <summary>
        /// Giver mig Json format for events object
        /// </summary>
        /// <returns></returns>
        public string getJson()
        {
            string json = JsonConvert.SerializeObject(Events);
            return json;
        }

        /// <summary>
        /// En methode som modtager en string af json og deserializerer til objekter. 
        /// </summary>
        /// <param name="jsonText"></param>
        public void IndsetJson(string jsonText)
        {
            List<Event> nyListe = JsonConvert.DeserializeObject<List<Event>>(jsonText);

            foreach (var EventItem in nyListe)
            {
                
                this.Events.Add(EventItem);
            }
        }

    }
}
