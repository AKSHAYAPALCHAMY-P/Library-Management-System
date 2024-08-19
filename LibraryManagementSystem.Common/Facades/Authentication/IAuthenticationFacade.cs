namespace LibraryManagementSystem.Common
{
    public interface IAuthenticationFacade
    {
        bool Register(UserDto user);
        bool Authenticate(UserDto user);
    }
}
