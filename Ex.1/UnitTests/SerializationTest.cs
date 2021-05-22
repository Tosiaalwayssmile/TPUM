using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using DataLayer.Model;
using LogicLayer.DTOs;
using Newtonsoft.Json;

namespace UnitTests
{
    [TestClass]
    public class SerializationTest
    {
        [TestMethod]
        public void UserSerialization()
        {
            User u = new User
            {
                FirstName = "Test1",
                LastName = "Test2"
            };

            Assert.AreEqual(u, JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(u)));
        }
        [TestMethod]
        public void BookSerialization()
        {
            Book b = new Book
            {
                Title = "tytul",
                AuthorLN = "nazwisko"
            };

            Assert.AreEqual(b, JsonConvert.DeserializeObject<Book>(JsonConvert.SerializeObject(b)));
        }
        [TestMethod]
        public void DiscountCodeSerialization()
        {
            DiscountCode dc = new DiscountCode
            {
                Code = "kod",
                Amount = 10
            };

            Assert.AreEqual(dc, JsonConvert.DeserializeObject<DiscountCode>(JsonConvert.SerializeObject(dc)));
        }
    }
}