using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;

namespace Json_serial
{

    public class Serail_coll
    {
        static void Main(string[] args)
        {


            List<string> videogames = new List<string>
        {
            "Hello ",
            "Ankur",
            "New language"
        };

            string json = JsonConvert.SerializeObject(videogames);

            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
