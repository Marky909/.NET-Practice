namespace FirstAPI.Models
{
    public class Book
    {
        // Unique identifier for each book
        public int Id { get; set; }

        // Initialized as null! (or empty string) to suppress C# nullable warnings [5]
        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public int YearPublished { get; set; }
    }
}