using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataLayer.Model;
using DataLayer.Repositories.Books;
using LogicLayer.DTOs;

namespace LogicLayer.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly DTOMapper _modelMapper;

        public BookService()
        {
            _bookRepository = new BookRepository(DataStore.Instance.State.Books);
            _modelMapper = new DTOMapper();
        }

        public BookService(BookRepository bookRepository, DTOMapper modelMapper)
        {
            _bookRepository = bookRepository;
            _modelMapper = modelMapper;
        }

        public BookDTO GetBookById(Guid id)
        {
            Book book = _bookRepository.Find(book => book.Id.Equals(id));
            return DTOMapper.Book2DTO(book);
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            return _bookRepository.Items.Select(DTOMapper.Book2DTO);
        }

        public BookDTO AddBook(BookDTO dto)
        {
            Book book = DTOMapper.DTO2Book(dto);
            Book created =  _bookRepository.Create(book);
            return DTOMapper.Book2DTO(created);
        }

        public void DeleteBook(Guid book)
        {
            _bookRepository.Delete(book);
        }

        public BookDTO UpdateBook(BookDTO dto)
        {
            Book book = DTOMapper.DTO2Book(dto);
            Book updated = _bookRepository.Update(book);
            return DTOMapper.Book2DTO(updated);
        }

        public BookDTO Save(BookDTO bookDTO)
        {
            Book book = DTOMapper.DTO2Book(bookDTO);
            Book updated = _bookRepository.CreateOrUpdate(book);
            return DTOMapper.Book2DTO(updated);
        }

    }
}