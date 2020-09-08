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
using static WpfApp1.ApiGetSet;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApiCall Apicall = new ApiCall();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            string city = cityInput.Text;
            Root weather = Apicall.getInfo(city);
            
            foreach (var item in weather.list)
            {
                weatherText.Text = $"Temperaturen er: {Math.Round(item.main.temp).ToString()}";
                foreach (var ting in item.weather)
                {
                    if(ting.main == "Clouds")
                    {
                        Bg.ImageSource = new BitmapImage(new Uri(@"C:\Users\nico936d\Documents\S-2\Uge_37\Tirsdag_VejrAPI\VejrAPI\WpfApp1\Assets\BackgroundClouds.jpg"));
                    } else if(ting.description == "few clouds")
                    {
                        Bg.ImageSource = new BitmapImage(new Uri(@"C:\Users\nico936d\Documents\S-2\Uge_37\Tirsdag_VejrAPI\VejrAPI\WpfApp1\Assets\BackgroundSunClouds.jpg"));
                    }
                }
            }
        }
    }
}
