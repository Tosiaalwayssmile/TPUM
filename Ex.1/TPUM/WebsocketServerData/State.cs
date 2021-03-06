using System.Collections.Generic;
using WebsocketServerData.Model;

namespace WebsocketServerData
{
    public class State
    {
        public State(IList<Book> books, IList<User> users, IList<DiscountCode> discountCodes)
        {
            Books = books;
            Users = users;
            DiscountCodes = discountCodes;
        }

        public IList<Book> Books { get; private set; }
        public IList<User> Users { get; private set; }
        public IList<DiscountCode> DiscountCodes { get; private set; }
    }
}
