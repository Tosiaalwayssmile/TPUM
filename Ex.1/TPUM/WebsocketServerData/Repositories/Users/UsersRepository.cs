using System.Collections.Generic;
using WebsocketServerData.Model;

namespace WebsocketServerData.Repositories.Users
{
    public class UsersRepository : CrudRepository<User>, IUserRepository
    {
        public UsersRepository(IList<User> users) : base(users)
        {
        }
    }
}