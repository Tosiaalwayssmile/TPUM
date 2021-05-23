using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using DataLayer.Model;
using LogicLayer.DTOs;
using DataLayer.Repositories.Books;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class LogicTest
    {
        class Repo : IBookRepository
        {
            private IList<Book> _Items = new List<Book>();
            public IList<Book> Items => _Items;

            public Book Create(Book item)
            {
                Items.Add(item);
                return item;
            }
            public Book CreateOrUpdate(Book item)
            {
                Book found = null;
                foreach (var b in from Book b in Items
                                  where item.Id.Equals(b.Id)
                                  select b)
                {
                    found = b;
                    break;
                }

                if (found != null)
                    Items.Remove(found);
                Items.Add(item);

                return item;
            }
            public void Delete(Book item)
            {
                Items.Remove(item);
            }
            public void Delete(Guid id)
            {
                foreach (var b in from Book b in Items
                                  where id.Equals(b.Id)
                                  select b)
                {
                    Items.Remove(b);
                    return;
                }
            }
            public Book Find(Func<Book, bool> predicate)
            {
                return Items.FirstOrDefault(predicate);
            }
            public Book Update(Book item)
            {
                CreateOrUpdate(item);
                return item;
            }
        }

        [TestMethod]
        public void Test_Repo()
        {
            IBookRepository repo = new Repo();
            Book b = new Book
            {
                Title = "title",
                AuthorFN = "FN",
                AuthorLN = "LN",
                Id = new Guid()
            };

            Assert.AreEqual(repo.Create(b), b);
            Assert.AreEqual(repo.Find(book => book.Id.Equals(b.Id)), b);
            repo.Delete(b);
            Assert.AreEqual(repo.Find(book => book.Id.Equals(b.Id)), null);
        }
        [TestMethod]
        public void Test_Logic()
        {
            IBookRepository repo = new Repo();
            LogicLayer.MainLogic.Init(repo, null, null);

            BookDTO b = new BookDTO()
            {
                Guid = new Guid()
            };
            LogicLayer.MainLogic.Instance.AddBook(b);
            BookDTO b2 = LogicLayer.MainLogic.Instance.GetBook((Guid)b.Guid);
            Assert.AreEqual(b.Guid, b2.Guid);
        }
    }
}