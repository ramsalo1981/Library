using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class Movie : Item
    {
        public ObjectId Id;
        public int Duration { get; set; }
        public int AgeLimit { get; set; }
        public Movie(string name, string type, int releseYear, string genre, int numberOfThisItem, int duration, int ageLimit) : base(name, type, releseYear, genre, numberOfThisItem)
        {
            Duration = duration;
            AgeLimit = ageLimit;
        }
        //TimeSpan t = TimeSpan.FromMinutes(80);

        //string answer = string.Format("{0:D2}h:{1:D2}m",
        //                t.Hours,
        //                t.Minutes
        //                );
    }
}
