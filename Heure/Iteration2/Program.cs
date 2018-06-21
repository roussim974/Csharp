using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using Newtonsoft.Json;

namespace Iteration2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create("http://data.metromobilite.fr/api/linesNear/json?x=5.704708&y=45.205311&dist=600&details=false");
            
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

            List <json2csharp> donnees = JsonConvert.DeserializeObject<List<json2csharp>>(responseFromServer);


            foreach (json2csharp donnee in donnees)
            {
                Console.WriteLine(donnee.id);
                Console.WriteLine(donnee.name);
                Console.WriteLine(donnee.lon);
                Console.WriteLine(donnee.lat); 
                foreach (string line in donnee.lines)
                {
                    Console.WriteLine(line);
                }
                //Console.WriteLine(donnee.lines);
            }

            // Clean up the streams and the response. 
            Console.Read();
            reader.Close();
            response.Close();
        }
    }
}
