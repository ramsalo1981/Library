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
        public Movie(string name, string type, int releseYear, string genre, int numberOfThisItem, int duration, int ageLimit) : base(name, type, releseYear, genre, numberOfThisItem)
        {
            Duration = duration;
            AgeLimit = ageLimit;
        }
        
    }
}
