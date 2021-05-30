using System;
using System.Collections.Generic;
using WebsocketServerLogic.DTOs;

namespace WebsocketServerLogic.Services.BookService
{
    public interface IBookService
    {
        BookDTO GetBookById(Guid id);
        IEnumerable<BookDTO> GetAllBooks();
        BookDTO AddBook(BookDTO book);
        void DeleteBook(Guid book);
        BookDTO UpdateBook(BookDTO book);
        BookDTO Save(BookDTO book);
    }
}