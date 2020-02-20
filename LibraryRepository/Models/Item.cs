namespace LibraryRepository.Models
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int ReleseYear { get; set; }
        public string Genre { get; set; }
        public int NumberOfCopies { get; set; }

        public Item()
        {

        }

        public Item(string name, int releseYear, string genre, int numberOfCopies)
        {
            Name = name;
            ReleseYear = releseYear;
            Genre = genre;
            NumberOfCopies = numberOfCopies;
        }
    }
}