
using System;
using System.Collections.Generic;
using System.Linq;
using LibMetro;
using Newtonsoft.Json;

namespace Iteration2
{
    class Program
    {
        static void Main(string[] args)
        {

            Metro metro = new Metro();

            List<BusStop> donnees = JsonConvert.DeserializeObject<List<BusStop>>(metro.getMetro("http://data.metromobilite.fr/api/linesNear/json?x=5.704708&y=45.205311&dist=1600&details=false"));

            List<BusStop> noDoublon = donnees.GroupBy(u => u.name).Select(grp => grp.First()).ToList();

            foreach (BusStop busStop in noDoublon)
            {
                Console.Write(busStop.id + busStop.name + busStop.lon + busStop.lat);

                foreach (string line in busStop.lines)
                {
                    Console.WriteLine(line);
                }

            }
            Console.Read();
        }
    }
}
