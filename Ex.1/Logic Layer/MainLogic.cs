using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataLayer.Model;
using DataLayer.Repositories.Books;
using DataLayer.Repositories.DiscountCodes;
using DataLayer.Repositories.Users;
using LogicLayer.DTOs;

namespace LogicLayer
{
    public class MainLogic : Interfaces.IMainLogic
    {
        private IBookRepository bookRepo;
        private IUserRepository userRepo;
        private IDiscountCodeRepository discountCodeRepo;

        private static MainLogic _Instance;
        public static MainLogic Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new MainLogic(new BookRepository(DataStore.Instance.State.Books), new UsersRepository(DataStore.Instance.State.Users), new DiscountCodeRepository(DataStore.Instance.State.DiscountCodes));
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }


        // METHODS

        // Constructor
        private MainLogic(IBookRepository bookRepository, IUserRepository userRepository, IDiscountCodeRepository discountCodeRepository)
        {
            bookRepo = bookRepository;
            userRepo = userRepository;
            discountCodeRepo = discountCodeRepository;
            Instance = this;
        }

        public static void Init(IBookRepository bookRepo, IUserRepository userRepo, IDiscountCodeRepository discRepo)
        {
            if (Instance == null)
                Instance = new MainLogic(bookRepo, userRepo, discRepo);
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            return userRepo.Items.Select(DTOMapper.User2DTO);
        }
        public IEnumerable<BookDTO> GetAllBooks()
        {
            return bookRepo.Items.Select(DTOMapper.Book2DTO);
        }
        public IEnumerable<DiscountCodeDTO> GetAllDiscountCodes()
        {
            return discountCodeRepo.Items.Select(DTOMapper.DiscountCode2DTO);
        }

        public BookDTO GetBook(Guid id)
        {
            Book book = bookRepo.Find(book => book.Id.Equals(id));
            if (book == null)
                return null;
            return DTOMapper.Book2DTO(book);
        }
        public UserDTO GetUser(Guid id)
        {
            User user = userRepo.Find(user => user.Id.Equals(id));
            if (user == null)
                return null;
            return DTOMapper.User2DTO(user);
        }
        public DiscountCodeDTO GetDiscountCode(Guid id)
        {
            DiscountCode code = discountCodeRepo.Find(code => code.Id.Equals(id));
            if (code == null)
                return null;
            return DTOMapper.DiscountCode2DTO(code);
        }

        public void AddBook(BookDTO dto)
        {
            Book book = DTOMapper.DTO2Book(dto);
            bookRepo.Create(book);
        }
        public void AddUser(UserDTO dto)
        {
            User user = DTOMapper.DTO2User(dto);
            userRepo.Create(user);
        }
        public void AddDiscountCode(DiscountCodeDTO dto)
        {
            DiscountCode code = DTOMapper.DTO2DiscountCode(dto);
            discountCodeRepo.Create(code);
        }

        public void DeleteBook(Guid id)
        {
            BookDTO book = GetBook(id);
            if (book == null)
                return;
            bookRepo.Delete(DTOMapper.DTO2Book(book));
        }
        public void DeleteUser(Guid id)
        {
            UserDTO user = GetUser(id);
            if (user == null)
                return;
            userRepo.Delete(DTOMapper.DTO2User(user));
        }
        public void DeleteDiscountCode(Guid id)
        {
            DiscountCodeDTO code = GetDiscountCode(id);
            if (code == null)
                return;
            discountCodeRepo.Delete(DTOMapper.DTO2DiscountCode(code));
        }

        public void UpdateBook(BookDTO updatedBookDTO)
        {
            Book updatedBook = DTOMapper.DTO2Book(updatedBookDTO);
            bookRepo.Update(updatedBook);
        }
        public void UpdateUser(UserDTO updatedUserDTO)
        {
            User updatedUser = DTOMapper.DTO2User(updatedUserDTO);
            userRepo.Update(updatedUser);
        }
        public void UpdateDiscountCode(DiscountCodeDTO updatedCodeDTO)
        {
            DiscountCode updatedCode = DTOMapper.DTO2DiscountCode(updatedCodeDTO);
            discountCodeRepo.Update(updatedCode);
        }
    }
}
