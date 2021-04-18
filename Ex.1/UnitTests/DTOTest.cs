using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using DataLayer.Model;
using LogicLayer.DTOs;

namespace UnitTests
{
    [TestClass]
    public class DTOTest
    {
        static User u1 = new User
        {
            Id = new Guid(),
            FirstName = "Test1",
            LastName = "Test2",
            Email = "email@test.com",
            Phone = "123456789",
            Cart = new Cart()
        };
        static Book b1 = new Book
        {
            Id = new Guid(),
            AuthorFN = "Author1",
            AuthorLN = "Author2",
            Genre = "genre",
            ISBN = 12345,
            Pages = 123,
            Price = 10,
            Publisher = "publisher",
            ReleaseDate = new DateTime(),
            Title = "title"
        };
        static DiscountCode c1 = new DiscountCode()
        {
            Id = new Guid(),
            Code = "abc",
            Amount = 10
        };

        static UserDTO u1dto = DTOMapper.User2DTO(u1);
        static BookDTO b1dto = DTOMapper.Book2DTO(b1);
        static DiscountCodeDTO c1dto = DTOMapper.DiscountCode2DTO(c1);

        static User u2 = DTOMapper.DTO2User(u1dto);
        static Book b2 = DTOMapper.DTO2Book(b1dto);
        static DiscountCode c2 = DTOMapper.DTO2DiscountCode(c1dto);

        [TestMethod]
        public void User_DTO()
        {
            Assert.AreEqual(u1.Id, u1dto.Guid);
            Assert.AreEqual(u1.FirstName, u1dto.FirstName);
            Assert.AreEqual(u1.LastName, u1dto.LastName);
            Assert.AreEqual(u1.Email, u1dto.Email);
            Assert.AreEqual(u1.Phone, u1dto.Phone);
            Assert.AreEqual(u1.Cart, u1dto.Cart);
        }
        [TestMethod]
        public void Book_DTO()
        {
            Assert.AreEqual(b1.Id, b1dto.Guid);
            Assert.AreEqual(b1.AuthorFN, b1dto.AuthorFN);
            Assert.AreEqual(b1.AuthorLN, b1dto.AuthorLN);
            Assert.AreEqual(b1.Genre, b1dto.Genre);
            Assert.AreEqual(b1.ISBN, b1dto.ISBN);
            Assert.AreEqual(b1.Pages, b1dto.Pages);
            Assert.AreEqual(b1.Price, b1dto.Price);
            Assert.AreEqual(b1.Publisher, b1dto.Publisher);
            Assert.AreEqual(b1.ReleaseDate, b1dto.ReleaseDate);
            Assert.AreEqual(b1.Title, b1dto.Title);
        }
        [TestMethod]
        public void Code_DTO()
        {
            Assert.AreEqual(c1.Id, c1dto.Guid);
            Assert.AreEqual(c1.Code, c1dto.Code);
            Assert.AreEqual(c1.Amount, c1dto.Amount);
        }

        [TestMethod]
        public void DTO_User()
        {
            Assert.AreEqual(u2.Id, u1dto.Guid);
            Assert.AreEqual(u2.FirstName, u1dto.FirstName);
            Assert.AreEqual(u2.LastName, u1dto.LastName);
            Assert.AreEqual(u2.Email, u1dto.Email);
            Assert.AreEqual(u2.Phone, u1dto.Phone);
            Assert.AreEqual(u2.Cart, u1dto.Cart);
        }
        [TestMethod]
        public void DTO_Book()
        {
            Assert.AreEqual(b2.Id, b1dto.Guid);
            Assert.AreEqual(b2.AuthorFN, b1dto.AuthorFN);
            Assert.AreEqual(b2.AuthorLN, b1dto.AuthorLN);
            Assert.AreEqual(b2.Genre, b1dto.Genre);
            Assert.AreEqual(b2.ISBN, b1dto.ISBN);
            Assert.AreEqual(b2.Pages, b1dto.Pages);
            Assert.AreEqual(b2.Price, b1dto.Price);
            Assert.AreEqual(b2.Publisher, b1dto.Publisher);
            Assert.AreEqual(b2.ReleaseDate, b1dto.ReleaseDate);
            Assert.AreEqual(b2.Title, b1dto.Title);
        }
        [TestMethod]
        public void DTO_Code()
        {
            Assert.AreEqual(c2.Id, c1dto.Guid);
            Assert.AreEqual(c2.Code, c1dto.Code);
            Assert.AreEqual(c2.Amount, c1dto.Amount);
        }
    }
}