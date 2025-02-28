using BusinessLayer;
using ModelLayer.DTO;
using RepositoryLayer.Service;
using System.Collections.Generic;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _userRegistrationRL;
        ResponseModel<string> response;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public ResponseModel<string> RegisterUser(UserDto userdto)
        {
            var response = new ResponseModel<string>();

            // Check if user already exists
            if (_userRegistrationRL.IsUserExist(userdto.email!))
            {
                response.Success = false;
                response.Message = "User already exists with the given email.";
                response.Data = userdto.ToString();
                return response;

            }

            // Add new user
            bool isAdded = _userRegistrationRL.AddUser(userdto);
            if (isAdded)
            {
                response.Success = true;
                response.Message = "User registered successfully.";
                response.Data = userdto.ToString();
            }
            else
            {
                response.Success = false;
                response.Message = "Failed to register user.";
               
            }

            return response;
        }

        public List<UserDto> GetAllUsers()
        {
            return _userRegistrationRL.GetAllUsers();
        }
    }
}
