using System.Collections.Generic;

namespace LibraryManagementSystem.Data
{
    public static class LibraryManagementSystemContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Book> Books { get; set; } = new List<Book>();
    }
}
