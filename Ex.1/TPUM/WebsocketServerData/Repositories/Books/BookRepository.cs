using System.Collections.Generic;
using WebsocketServerData.Model;

namespace WebsocketServerData.Repositories.Books
{
    public class BookRepository : CrudRepository<Book>, IBookRepository
    {
        public BookRepository(IList<Book> books) : base(books)
        {
        }
    }
}