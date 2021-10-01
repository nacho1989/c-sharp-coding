using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Movies.Logic
{
    [BsonIgnoreExtraElements]
    public class MovieTicket
    {
        [BsonElement("selected_movie_title")]
        public string SelectedMovieTitle { get; set; }
        [BsonElement("movie_price")]
        public int MoviePrice { get; set; }
        [BsonElement("movie_time")]
        public string MovieTime { get; set; }
        [BsonElement("movie_id")]
        public int MovieId { get; set; }
        [BsonElement("customer_firstname")]
        public string CustomerFirstName { get; set; }
        [BsonElement("customer_lastname")]
        public string CustomerLastName { get; set; }
        [BsonElement("movie_rating")]
        public string MovieRating { get; set; }
        [BsonElement("movie_director")]
        public string MovieDirector { get; set; }
        [BsonElement("starring")]
        public string[] MovieStarring { get; set; }
        [BsonElement("customer_email")]
        public string CustomerEmail { get; set; }
        [BsonElement("customer_phone")]
        public long CustomerPhone { get; set; }
        [BsonElement("date")]
        public string Date { get; set; }

        
    }
}
