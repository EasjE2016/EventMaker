using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EventMaker.Model;
using Windows.Storage;

namespace EventMaker.Persistency
{

    class  PersistencyService
    {

        static StorageFolder localfolder = null;
        static private readonly string filnavn = "eventJson.json";


      
        public static async  void GemDataTilAsync()
        {
            localfolder = ApplicationData.Current.LocalFolder;
            string jsonText = EventCatalogSingleton.Instance.getJson();
            StorageFile file = await localfolder.CreateFileAsync(filnavn, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, jsonText);

        }


        public static async void HentDataFraDiskAsync()
        {
           
                localfolder = ApplicationData.Current.LocalFolder;
                StorageFile file = await localfolder.GetFileAsync(filnavn);
                string jsonText = await FileIO.ReadTextAsync(file);
                EventCatalogSingleton.Instance.Events.Clear();
                EventCatalogSingleton.Instance.IndsetJson(jsonText);
            
         
        }





       // public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
       // {
         

       //}

        //public static async Task<List<Event>> LoadEventsFromJsonAsync()
        //{

        //}

        //public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        //{

        //}

        //public static async Task<string> DeSerializeEventsFileAsync(string fileName)
        //{

        //}
    }
}
