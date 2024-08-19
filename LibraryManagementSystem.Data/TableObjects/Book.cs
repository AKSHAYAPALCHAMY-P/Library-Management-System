using LibraryManagementSystem.Common;

namespace LibraryManagementSystem.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string BookNo { get; set; }
        public string NameOfTheBook { get; set; }
        public string AuthorName { get; set; }
        public string PublishedYear { get; set; }

        public Book(BookDto book)
        {
            Id = LibraryManagementSystemContext.Books.Count + 1;
            BookNo = book.BookNo;
            NameOfTheBook = book.NameOfTheBook;
            AuthorName = book.AuthorName;
            PublishedYear = book.PublishedYear;
        }
    }
}
