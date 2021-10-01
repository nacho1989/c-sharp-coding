using MongoDB.Driver;
using System;

namespace Movies.Logic
{
    public class MoviesDB
    {
        private MongoClient _mongoClient;

        public MoviesDB()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
        }

        public Movie[] ShowMoview()
        {
            var database = _mongoClient.GetDatabase("moviesdb");
            var collection = database.GetCollection<Movie>("movies");
            var list = collection.Find(x => true);
            return list.ToList().ToArray();
        }

        public MovieTicket ProcessTicket(Movie movie, string timeSelected, string firstName, string lastName, string customerEmail, long customerPhone)
        {
            MovieTicket t = new MovieTicket
            {
                SelectedMovieTitle = movie.MovieTitle,
                MoviePrice = movie.Price,
                MovieTime = timeSelected,
                MovieId = movie.MovieId,
                MovieRating = movie.Rating,
                MovieDirector = movie.MovieDirector,
                MovieStarring = movie.MovieStarring,
                CustomerFirstName = firstName,
                CustomerLastName = lastName,
                CustomerEmail = customerEmail,
                CustomerPhone = customerPhone,
                
            };

            var database = _mongoClient.GetDatabase("moviesdb");
            var collection = database.GetCollection<MovieTicket>("movies_ticket");

            //check if ticket that matches all params exist
            var existingTicket = collection.Find(x => x.CustomerFirstName == t.CustomerFirstName
            && x.CustomerLastName == t.CustomerLastName
            && x.SelectedMovieTitle == t.SelectedMovieTitle
            && x.MovieTime == t.MovieTime).FirstOrDefault();

            //throw exception if exists
            if (existingTicket != null)
                throw new Exception("A ticket already exists");

            collection.InsertOne(t);

            //return movie ticket object;
            return t;
        }
    }
}
