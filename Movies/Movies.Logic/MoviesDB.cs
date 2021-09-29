using System;

namespace Movies.Logic
{
    public class MoviesDB
    {
        public Movie[] ShowMoview()
        {
            //create an array of movies to hold 5 items
            var list = new Movie[5];

            var movie1 = new Movie
            {
                MovieTimes = new string[] { "10:00 PM", "00:00 AM", "2:00 AM" },
                MovieTitle = "The Thing",
                Price = 8.17,
                Id = 1012,
                Rating = "PG-13"
            };
            var movie2 = new Movie
            {
                MovieTimes = new string[] { "10:00 PM", "00:00 AM", "2:00 AM" },
                MovieTitle = "Riddick",
                Price = 12.88,
                Id = 1013,
                Rating = "G"
            };
            var movie3 = new Movie
            {
                MovieTimes = new string[] { "10:00 PM", "00:00 AM", "2:00 AM" },
                MovieTitle = "Mission Impossible",
                Price = 10.54,
                Id = 1014,
                Rating = "PG"
            };
            var movie4 = new Movie
            {
                MovieTimes = new string[] { "10:00 PM", "00:00 AM", "2:00 AM" },
                MovieTitle = "Nightmare on Elm Street",
                Price = 15.09,
                Id = 1015,
                Rating = "NC-17"
            };
            var movie5 = new Movie
            {
                MovieTimes = new string[] { "10:00 PM", "00:00 AM", "2:00 AM" },
                MovieTitle = "Batman Returns",
                Price = 7.50,
                Id = 1016,
                Rating = "R"
            };

            //add movies to array slots
            list[0] = movie1;
            list[1] = movie2;
            list[2] = movie3;
            list[3] = movie4;
            list[4] = movie5;

            
            return list;
        }

        public static void DisplayMenu()
        {
            Console.Clear();
        }

        public MovieTicket ProcessTicket(Movie movie, string timeSelected, string firstName, string lastName, string phone)
        {
            //use the selected movie information to create a new movie ticket object
            MovieTicket t = new MovieTicket();
            t.SelectedMovieTitle = movie.MovieTitle;
            t.Rating = movie.Rating;
            t.MovieId = movie.Id;
            t.MoviePrice = movie.Price;
            t.MovieTime = timeSelected;
            t.CustomerFirstName = firstName;
            t.CustomerLastName = lastName;
            t.CustomerPhone = phone;
            //return movie ticket object;
            return t;
        }

        
    }
}
