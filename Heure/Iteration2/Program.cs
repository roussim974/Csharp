using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Linq;
using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using Newtonsoft.Json;
using LibMetro;

namespace Iteration2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<BusStop> busStops = Metro.BusStopProximity();
            foreach (BusStop busStop in busStops)
            {
                Console.Write(busStop.id + busStop.name + busStop.lon + busStop.lat);
 /*               Console.WriteLine(donnee.name);
                Console.WriteLine(donnee.lon);
                Console.WriteLine(donnee.lat); */
                foreach (string line in busStop.lines)
                {
                    Console.WriteLine(line);
                }
                //Console.WriteLine(donnee.lines);
            }
            Console.Read();
        }
    }
}
