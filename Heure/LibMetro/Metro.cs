using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibMetro
{
    public class Metro
    {
        
        public static List<BusStop> BusStopProximity()
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create("http://data.metromobilite.fr/api/linesNear/json?x=5.704708&y=45.205311&dist=1600&details=false");

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            //Console.WriteLine(responseFromServer);

            List<BusStop> donnees = JsonConvert.DeserializeObject<List<BusStop>>(responseFromServer);

            List<BusStop> noDoublon = donnees.GroupBy(u => u.name).Select(grp => grp.First()).ToList();


            // Clean up the streams and the response. 
            
            reader.Close();
            response.Close();


            return noDoublon;
        } 
        

    }
}
