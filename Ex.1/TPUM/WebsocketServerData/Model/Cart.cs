using System.Collections.Generic;

namespace WebsocketServerData.Model
{
    public class Cart : BaseEntity
    {
        public User User { get; set; }

        public IList<Book> Books { get; set; }
    }
}