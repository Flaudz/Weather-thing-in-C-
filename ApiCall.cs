using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static WpfApp1.ApiGetSet;

namespace WpfApp1
{
    public class ApiCall
    {
        public Root getInfo(string city)
        {
            var json = new WebClient().DownloadString($"http://api.openweathermap.org/data/2.5/find?q={city}&units=metric&APPID=050936d1aac5cc35d9f3df894ba7f990");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
            return myDeserializedClass;
        }
    }
}
