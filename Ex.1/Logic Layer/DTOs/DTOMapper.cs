using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.DTOs
{
    public class DTOMapper
    {
        public static Book DTO2Book(BookDTO dto)
        {
            return new Book
            {
                Id = dto.Guid,
                AuthorFN = dto.AuthorFN,
                AuthorLN = dto.AuthorLN,
                Title = dto.Title,
                Genre = dto.Genre,
                Price = dto.Price,
                Publisher = dto.Publisher,
                ReleaseDate = dto.ReleaseDate,
                ISBN = dto.ISBN,
                Pages = dto.Pages
            };
        }
        public static BookDTO Book2DTO(Book book)
        {
            return new BookDTO
            {
                Guid = book.Id,
                AuthorFN = book.AuthorFN,
                AuthorLN = book.AuthorLN,
                Title = book.Title,
                Genre = book.Genre,
                Price = book.Price,
                Publisher = book.Publisher,
                ReleaseDate = book.ReleaseDate,
                ISBN = book.ISBN,
                Pages = book.Pages
            };
        }

        public static Cart DTO2Cart(CartDTO dto)
        {
            return new Cart
            {
                Id = dto.Guid,
                User = dto.User,
                Books = dto.Books
            };
        }
        public static CartDTO Cart2DTO(Cart cart)
        {
            return new CartDTO
            {
                Guid = cart.Id,
                User = cart.User,
                Books = cart.Books
            };
        }

        public static DiscountCode DTO2DiscountCode(DiscountCodeDTO dto)
        {
            return new DiscountCode
            {
                Id = dto.Guid,
                Code = dto.Code,
                Amount = dto.Amount
            };
        }
        public static DiscountCodeDTO DiscountCode2DTO(DiscountCode dc)
        {
            return new DiscountCodeDTO
            {
                Guid = dc.Id,
                Code = dc.Code,
                Amount = dc.Amount
            };
        }

        public static User DTO2User(UserDTO dto)
        {
            return new User
            {
                Id = dto.Guid,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Phone = dto.Phone,
                Cart = dto.Cart
            };
        }
        public static UserDTO User2DTO(User user)
        {
            return new UserDTO
            {
                Guid = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                Cart = user.Cart
            };
        }

    }
}
