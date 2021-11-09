using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Ticket
    {
        public Movie movie { get; set; }
        public Date date { get; set; }
        public string price { get; set; }



    }
    class Date
    {
        public string date { get; set; }
        public string time { get; set; }
        public string sellDate { get; set; }
    }
    class Movie
    {
        public string name { get; set; }
        public string genre { get; set; }

        public Poster poster { get; set; }
        public Duration duration { get; set; }

    }

    class Duration
    {
        public int hour { get; set; }
        public int minute { get; set; }

        public int sec { get; set; }
    }

    class Poster
    {
        public string name { get; set; }
        public int size { get; set; }
        public string photo { get; set; }



    }
}
