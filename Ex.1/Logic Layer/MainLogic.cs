using System.Collections.Generic;
using System.Linq;
using DataLayer;
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

        private static MainLogic _instance;
        private static readonly object Padlock = new object();
        public static MainLogic Instance
        {
            get
            {
                lock (Padlock)
                {
                    _instance ??= new MainLogic();
                    return _instance;
                }
            }
        }


        // METHODS

        // Constructor
        private MainLogic()
        {
            bookRepo = new BookRepository(DataStore.Instance.State.Books);
            userRepo = new UsersRepository(DataStore.Instance.State.Users);
            discountCodeRepo = new DiscountCodeRepository(DataStore.Instance.State.DiscountCodes);
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
    }
}
