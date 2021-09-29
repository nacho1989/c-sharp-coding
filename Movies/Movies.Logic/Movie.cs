using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Logic
{
    public class Movie
    {
        //create an int id property
        public int Id { get; set; }

        //create a int price property
        public double Price { get; set; } 

        //create string title property
        public string MovieTitle { get; set; }

        public string Rating { get; set; }

        //create an  string array of movie times
        public string[] MovieTimes { get; set; } = new string[] { "10:00 PM", "00:00 AM", "2:00 AM" };
    }
}
