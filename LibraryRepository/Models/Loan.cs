using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Models
{
    public class Loan
    {
        public ObjectId Id { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime StartDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime EndDate { get; set; }

        public Member Member { get; set; }
        public Book BookArticle { get; set; }
        public Movie MovieArticle { get; set; }

        public Loan(DateTime startDate, DateTime endDate, Member member)
        {
            StartDate = startDate;
            EndDate = endDate;
            Member = member;
        }
    }
}
