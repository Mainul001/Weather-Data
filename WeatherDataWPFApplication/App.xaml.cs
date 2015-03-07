using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WeatherDataWPFApplication {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        public static void Start() {
            WeatherData weather = WeatherApiClient.GetWeatherForecast("http://api.openweathermap.org/data/2.5/forecast/daily?q=Dhaka&mode=json&units=metric&cnt=1");
            
        }

    }
}
