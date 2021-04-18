using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    [TestClass]
    public class FillInStateTest
    {
        [TestMethod]
        public void StateCreationIsNotNull()
        {
            DataLayer.State stateTest = new DataLayer.State(
                users: new List<DataLayer.Model.User>
                {
                    new DataLayer.Model.User
                    {
                        FirstName = "TestName", LastName = "TestSurname", Email = "test@test.com", Phone = "321654978"
                    }
                },
                books: new List<DataLayer.Model.Book>
                {
                    new DataLayer.Model.Book
                    {
                        AuthorFN = "Stephen", AuthorLN = "King", Title = "It" , Genre = "Horror", Price = 23.5m,  Publisher = "Uninversal Records", Pages = 276, ReleaseDate = new DateTime(2009, 05, 12), ISBN = 61804036
                    }
                },
                discountCodes: new List<DataLayer.Model.DiscountCode>
                {
                    new DataLayer.Model.DiscountCode
                    {
                         Code = "PromoCode", Amount = 30
                    }
                });

            Assert.IsNotNull(stateTest);
        }
    }
}