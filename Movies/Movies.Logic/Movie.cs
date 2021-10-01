using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Movies.Logic
{
    [BsonIgnoreExtraElements]
    public class Movie
    {
        //create an int id property
        [BsonElement("movie_id")]
        public int MovieId { get; set; }

        //create a int price property
        [BsonElement("movie_price")]
        public int Price { get; set; }

        //create string title property
        [BsonElement("movie_title")]
        public string MovieTitle { get; set; }

        [BsonElement("movie_rating")]
        public string Rating { get; set; }

        [BsonElement("movie_director")]
        public string MovieDirector { get; set; }

        [BsonElement("movie_starring")]
        public string[] MovieStarring { get; set; }

        //create an  string array of movie times
        [BsonElement("movie_times")]
        public string[] MovieTimes { get; set; } = new string[] { "08:00 PM", "10:00 PM", "00:00 AM" };
    }
}
