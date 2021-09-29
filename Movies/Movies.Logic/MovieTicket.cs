using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Logic
{
    public class MovieTicket
    {
        public string SelectedMovieTitle { get; set; }
        public string Rating { get; set; }
        public int  MovieId { get; set; }
        public double MoviePrice { get; set; }
        public string MovieTime { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get;set; }
       
    }
}
