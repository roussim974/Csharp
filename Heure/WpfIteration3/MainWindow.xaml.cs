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
using LibMetro;
using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json;

namespace WpfIteration3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            

            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mapBing.Children.Clear();
            var Lat = lat.Text;
            var Lon = lon.Text;
            var Rayon = rayon.Text;


            Metro metro = new Metro();

            List<BusStop> donnees = JsonConvert.DeserializeObject<List<BusStop>>(metro.getMetro($"http://data.metromobilite.fr/api/linesNear/json?x={Lon}&y={Lat}&dist={Rayon}&details=false"));

            List<BusStop> noDoublon = donnees.GroupBy(u => u.name).Select(grp => grp.First()).ToList();

            foreach (BusStop busStop in noDoublon)
            {
                listBusStop.Items.Add(busStop.name);

                //Console.Write(busStop.id + busStop.name + busStop.lon + busStop.lat);

                foreach (string line in busStop.lines)
                {

                    Pushpin pushpin = new Pushpin();
                    Location location = new Location(busStop.lat, busStop.lon);
                    pushpin.Location = location;
                    mapBing.Children.Add(pushpin);
                    listLines.Items.Add(line);
                    
                    //Console.WriteLine(line);
                }

            }
            //Console.Read();
        }


        private void ListBusStop_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            //var z = listBusStop.SelectedItem;

            
        }

        private void lon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}