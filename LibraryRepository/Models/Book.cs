using MongoDB.Bson;

namespace LibraryRepository.Models
{
    public class Book : Item
    {
        public ObjectId Id;
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book()
        {

        }

        public Book(string name, int releseYear, string genre, int numberOfCopies, string author, int pages) : base(name, releseYear, genre, numberOfCopies)
        {
            Author = author;
            Pages = pages;
        }
        
    }
}