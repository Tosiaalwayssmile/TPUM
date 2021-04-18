using DataLayer.Model;
using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface IMainLogic
    {
        public IEnumerable<UserDTO> GetAllUsers();
        public IEnumerable<BookDTO> GetAllBooks();
        public IEnumerable<DiscountCodeDTO> GetAllDiscountCodes();
    }
}
