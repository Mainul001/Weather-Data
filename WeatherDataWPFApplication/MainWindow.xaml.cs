using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherDataWPFApplication {

    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            SetTodayDate();
            Start();
        }

        public void Start() {
            try {
                WeatherData t = WeatherApiClient.GetWeatherForecast("http://api.openweathermap.org/data/2.5/forecast/daily?q=Dhaka&mode=json&units=metric&cnt=1");
                //SetLabels(today);
                MorningTempLabel.Content = t.list[0].temp.morn;
                NoonTempLabel.Content = t.list[0].temp.day;
                NightTempLabel.Content = t.list[0].temp.night;
                HighestTempLabel.Content = t.list[0].temp.max;
                LowestTempLabel.Content = t.list[0].temp.min;
            } catch(Exception ex) {
                ClearLabels();
                MorningTempLabel.Content = "দুঃখিত,  আপনার ইন্টারনেট সংযোগ টি বিচ্ছিন্ন হয়ে গেছে।";
            }
        }

        public void ClearLabels() {
            MorningTempLabel.Content = "";
            NoonTempLabel.Content = "";
            NightTempLabel.Content = "";
            HighestTempLabel.Content = "";
            LowestTempLabel.Content = "";
        }

        //public void SetLabels(WeatherData t) {
            //ClearLabels();

            //MorningTempLabel.Content = t.list[0].temp.morn;
            //NoonTempLabel.Content = t.list[0].temp.day;
            //NightTempLabel.Content = t.list[0].temp.night;
            //HighestTempLabel.Content = t.list[0].temp.max;
            //LowestTempLabel.Content = t.list[0].temp.min;
        //}

        public void SetTodayDate() {
            DateTime today = DateTime.Today;
            
            switch(today.Day) {

                //০ ১ ২ ৩ ৪ ৫ ৬ ৭ ৮ ৯

                case 1:
                    DateLabel2.Content = "(১";
                    break;

                case 2:
                    DateLabel2.Content = "(২";
                    break;

                case 3:
                    DateLabel2.Content = "(৩";
                    break;

                case 4:
                    DateLabel2.Content = "(৪";
                    break;

                case 5:
                    DateLabel2.Content = "(৫";
                    break;

                case 6:
                    DateLabel2.Content = "(৬";
                    break;

                case 7:
                    DateLabel2.Content = "(৭";
                    break;

                case 8:
                    DateLabel2.Content = "(৮";
                    break;

                case 9:
                    DateLabel2.Content = "(৯";
                    break;

                case 10:
                    DateLabel2.Content = "(১০";
                    break;

                case 11:
                    DateLabel2.Content = "(১১";
                    break;

                case 12:
                    DateLabel2.Content = "(১২";
                    break;

                case 13:
                    DateLabel2.Content = "(১৩";
                    break;

                case 14:
                    DateLabel2.Content = "(১৪";
                    break;

                case 15:
                    DateLabel2.Content = "(১৫";
                    break;

                case 16:
                    DateLabel2.Content = "(১৬";
                    break;

                case 17:
                    DateLabel2.Content = "(১৭";
                    break;

                case 18:
                    DateLabel2.Content = "(১৮";
                    break;

                case 19:
                    DateLabel2.Content = "(১৯";
                    break;

                case 20:
                    DateLabel2.Content = "(২০";
                    break;

                case 21:
                    DateLabel2.Content = "(২১";
                    break;

                case 22:
                    DateLabel2.Content = "(২২";
                    break;

                case 23:
                    DateLabel2.Content = "(২৩";
                    break;

                case 24:
                    DateLabel2.Content = "(২৪";
                    break;

                case 25:
                    DateLabel2.Content = "(২৫";
                    break;

                case 26:
                    DateLabel2.Content = "(২৬";
                    break;

                case 27:
                    DateLabel2.Content = "(২৭";
                    break;

                case 28:
                    DateLabel2.Content = "(২৮";
                    break;

                case 29:
                    DateLabel2.Content = "(২৯";
                    break;

                case 30:
                    DateLabel2.Content = "(৩০";
                    break;

                case 31:
                    DateLabel2.Content = "(৩১";
                    break;
            }

        }

    }
}
