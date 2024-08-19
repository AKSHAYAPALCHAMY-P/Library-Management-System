using LibraryManagementSystem.Common;

namespace LibraryManagementSystem.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Author { get; set; }
        public string PublishedYear { get; set; }

        public Book(BookDto book)
        {
            Id = LibraryManagementSystemContext.Books.Count + 1;
            Name= book.Name;
            Author = book.Author;
            PublishedYear = book.PublishedYear;
        }
    }
}
