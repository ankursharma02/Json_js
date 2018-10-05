using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_serial
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Jsontofile
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995,

            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"e:\movie.json", JsonConvert.SerializeObject(movie));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"e:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
            Console.ReadLine();
        }
       
    }
}
