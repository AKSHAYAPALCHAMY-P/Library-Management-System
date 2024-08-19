using System;
using LibraryManagementSystem.Common;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.Logic
{
    internal class AuthenticationBL
    {
        internal bool Authenticate(UserDto dtoUser)
        {
            throw new NotImplementedException();
        }

        internal bool Register(UserDto dtoUser)
        {
            if(!dtoUser.Password.Equals(dtoUser.ConfirmPassword))
            {
                return false;
            }

            User user = new User(dtoUser);

            LibraryManagementSystemContext.Users.Add(user);

            return true;
        }
    }
}
