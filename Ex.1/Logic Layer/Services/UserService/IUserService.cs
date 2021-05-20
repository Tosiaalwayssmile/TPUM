using System;
using System.Collections.Generic;
using DataLayer.Model;
using LogicLayer.DTOs;

namespace LogicLayer.Services.UserService
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
