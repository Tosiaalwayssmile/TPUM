using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface IWebSocketManager
    {
        public delegate void Books(IList<BookDTO> booksList);
        public delegate void Users(IList<UserDTO> usersList);
        public delegate void DicountCodes(IList<DiscountCodeDTO> codesList);
        public delegate void SingleDiscountCode(DiscountCodeDTO code);

        public void RecieveMessage(string message);
        public void Connect();
        public void Disconnect();

        public void AddOnBooksRecieve(Books method);
        public void AddOnUsersRecieve(Users method);
        public void AddOnCodesRecieve(DicountCodes method);
        public void AddOnSingleCodeRecieve(SingleDiscountCode method);

        public void FetchUsers();
        public void FetchBooks();
        public void FetchCodes();
        public void FetchSingleCode();
    }
}
