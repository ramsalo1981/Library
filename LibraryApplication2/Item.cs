namespace LibraryApplication2
{
    abstract class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int ReleseYear { get; set; }
        public string Genre { get; set; }
        public int NumberOfCopies { get; set; }

        public Item(string name, string type, int releseYear, string genre, int numberOfCopies)
        {
            Name = name;
            Type = type;
            ReleseYear = releseYear;
            Genre = genre;
            NumberOfCopies = numberOfCopies;
        }
    }
}