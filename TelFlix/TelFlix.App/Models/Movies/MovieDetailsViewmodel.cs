using System;
using System.Collections.Generic;
using TelFlix.Data.Models;

namespace TelFlix.App.Models.Movies
{
    public class MovieDetailsViewmodel
    {
        public int ApiMovieId { get; set; }

        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? DurationInMinutes { get; set; }

        public ICollection<Actor> Actors { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public ICollection<Director> Directors { get; set; }
        
        public ICollection<Review> Reviews { get; set; }

        public float? Rating { get; set; }

        public string Description { get; set; }

        public string SmallImageUrl { get; set; }

        public string MediumImageUrl { get; set; }

        public string TrailerUrl { get; set; }
    }
}
