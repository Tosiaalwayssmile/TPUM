using System;
using System.Collections.Generic;
using System.Linq;
using WebsocketServerData;
using WebsocketServerData.Model;
using WebsocketServerData.Repositories.Users;
using WebsocketServerLogic.DTOs;

namespace WebsocketServerLogic.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UsersRepository(DataStore.Instance.State.Users);
        }

        public UserService(UsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO GetUserById(Guid id)
        {
            User user = _userRepository.Find(user => user.Id.Equals(id));
            return DTOMapper.User2DTO(user);
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            return _userRepository.Items.Select(DTOMapper.User2DTO);
        }

        public UserDTO AddUser(UserDTO dto)
        {
            User user = DTOMapper.DTO2User(dto);
            User created = _userRepository.Create(user);
            return DTOMapper.User2DTO(created);
        }

        public void DeleteUser(Guid user)
        {
            _userRepository.Delete(user);
        }

        public UserDTO UpdateUser(UserDTO dto)
        {
            User user = DTOMapper.DTO2User(dto);
            User updated = _userRepository.Update(user);
            return DTOMapper.User2DTO(updated);
        }

        public UserDTO Save(UserDTO userDTO)
        {
            User user = DTOMapper.DTO2User(userDTO);
            User updated = _userRepository.CreateOrUpdate(user);
            return DTOMapper.User2DTO(updated);
        }
    }
}