using System;
using System.Linq;
using DataLayer;
using DataLayer.Model;
using DataLayer.Repositories.Books;
using DataLayer.Repositories.DiscountCodes;
using DataLayer.Repositories.Users;
using LogicLayer.DTOs;

namespace LogicLayer.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IDiscountCodeRepository _dicountCodeRepository;

        public CartService()
        {
            _userRepository = new UsersRepository(DataStore.Instance.State.Users);
            _bookRepository = new BookRepository(DataStore.Instance.State.Books);
            _dicountCodeRepository = new DiscountCodeRepository(DataStore.Instance.State.DiscountCodes);
        }

        public CartService(IBookRepository bookRepository, IUserRepository userRepository, IDiscountCodeRepository discountCodeRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _dicountCodeRepository = discountCodeRepository;
        }

        public CartDTO AddBookToCart(Guid bookId, Guid userId)
        {
            User user = _userRepository.Find(u => u.Id.Equals(userId));
            Book book = _bookRepository.Find(b => b.Id.Equals(bookId));
            user.Cart.Books.Add(book);
            return DTOMapper.Cart2DTO(user.Cart);
        }

        public CartDTO RemoveBookFromCart(Guid bookId, Guid userId)
        {
            User user = _userRepository.Find(u => u.Id.Equals(userId));
            Book book = _bookRepository.Find(b => b.Id.Equals(bookId));
            user.Cart.Books.Remove(book);
            return DTOMapper.Cart2DTO(user.Cart);
        }

        public decimal CalculateTotalPrice(Guid userId, string code)
        {
            User user = _userRepository.Find(u => u.Id.Equals(userId));
            decimal rawPrice = user.Cart.Books.Sum(book => book.Price);
            if (code != null)
            {
                DiscountCode discountCode = _dicountCodeRepository.Find(dc => dc.Code.Equals(code));
                if (discountCode != null)
                {
                    return rawPrice * (100 - discountCode.Amount) / 100;
                }
            }

            return rawPrice;

        }

        public CartDTO GetCart(Guid userId)
        {
            User user = _userRepository.Find(u => u.Id.Equals(userId));
            return DTOMapper.Cart2DTO(user.Cart);
        }
    }
}