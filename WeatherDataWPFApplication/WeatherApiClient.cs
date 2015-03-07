using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace WeatherDataWPFApplication {
    class WeatherApiClient {

        public static WeatherData GetWeatherForecast(string weatherApi) {
            var url = weatherApi;
            string content = new WebClient().DownloadString(url);


            //Before you use DataContractJsonSerializer class you need to add a reference to  "System.Runtime.Serialization"
            //Go to Solution Explorer -> References -> Right Click -> Add References -> then check the box next to System.Runtime.Serialization

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(WeatherData));

            var ms = new MemoryStream(Encoding.Unicode.GetBytes(content));

            WeatherData data = (WeatherData)serializer.ReadObject(ms);

            ms.Close();
            return data;
        }
    }
}
