using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EventMaker.Model;

namespace EventMaker.Persistency
{
    class PersistencyService
    {
        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        {

        }

        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {

        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {

        }

        public static async Task<string> DeSerializeEventsFileAsync(string fileName)
        {

        }
    }
}
