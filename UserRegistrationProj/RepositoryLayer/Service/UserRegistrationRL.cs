using ModelLayer.DTO;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL 
    {
        //List to store all users
        private static readonly List<UserDto> Users = new List<UserDto>();

        public bool IsUserExist(string email)
        {
            // Check if user already exists
            return Users.Any(u => u.email == email);
        }

        public bool AddUser(UserDto user)
        {
            try
            {
                Users.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<UserDto> GetAllUsers()
        {
            return Users;
        }
    }
}
