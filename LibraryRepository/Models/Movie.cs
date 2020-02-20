using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Models
{
    public class Movie : Item
    {
        public ObjectId Id;
        public int Duration { get; set; }
        public int AgeLimit { get; set; }
        public Movie(string name, int releseYear, string genre, int numberOfCopies, int duration, int ageLimit) : base(name, releseYear, genre, numberOfCopies)
        {
            Duration = duration;
            AgeLimit = ageLimit;
        }
        
    }
}
