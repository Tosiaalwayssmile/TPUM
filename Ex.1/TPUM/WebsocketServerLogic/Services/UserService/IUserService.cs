using System;
using System.Collections.Generic;
using WebsocketServerLogic.DTOs;

namespace WebsocketServerLogic.Services.UserService
{
    public interface IUserService
    {
        UserDTO GetUserById(Guid id);
        IEnumerable<UserDTO> GetAllUsers();
        UserDTO AddUser(UserDTO dto);
        void DeleteUser(Guid user);
        UserDTO UpdateUser(UserDTO dto);
        UserDTO Save(UserDTO user);
    }
}
