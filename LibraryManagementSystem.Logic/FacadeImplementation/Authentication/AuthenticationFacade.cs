using LibraryManagementSystem.Common;

namespace LibraryManagementSystem.Logic
{
    public class AuthenticationFacade : IAuthenticationFacade
    {
        private readonly AuthenticationBL _blAuthentication;

        public AuthenticationFacade()
        {
            _blAuthentication = new AuthenticationBL();
        }

        public bool Authenticate(UserDto user)
        {
            return _blAuthentication.Authenticate(user);
        }

        public bool Register(UserDto user)
        {
            return _blAuthentication.Register(user);
        }
    }
}
