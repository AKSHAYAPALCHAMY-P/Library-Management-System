using LibraryManagementSystem.Common;

namespace LibraryManagementSystem.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(UserDto user)
        {
            Id = LibraryManagementSystemContext.Users.Count + 1;
            Name = user.Name;
            Email = user.Email;
            Password = user.Password;
        }
    }
}
