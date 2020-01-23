using MongoDB.Bson;

namespace LibraryRepository.Models
{
    public class Book : Item
    {
        public ObjectId Id;
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string name, string type, int releseYear, string genre, int numberOfCopies, string author, int pages) : base(name, type, releseYear, genre, numberOfCopies)
        {
            Author = author;
            Pages = pages;
        }
    }
}