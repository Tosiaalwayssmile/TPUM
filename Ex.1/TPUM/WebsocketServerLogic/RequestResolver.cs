using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LogicLayer.DTOs;
using LogicLayer.Services.BookService;
using LogicLayer.Services.UserService;
using LogicLayer.Services.DiscountCodeService;

namespace WebsocketServerLogic
{
    class RequestResolver
    {
        private readonly IUserService _userService;
        private readonly IBookService _booksService;
        private readonly IDiscountCodeService _discountCodeService;

        public RequestResolver()
        {
            _userService = new UserService();
            _booksService = new BookService();
            _discountCodeService = new DiscountCodeService();
        }

        public string Resolve(string message)
        {
            MessageDTO msgObj = JsonConvert.DeserializeObject<MessageDTO>(message);
            EndpointAction action;
            Enum.TryParse(msgObj.Action, out action);
            MessageDTO response;

            switch (action)
            {
                case EndpointAction.GET_BOOKS:
                    IEnumerable<BookDTO> books = _booksService.GetAllBooks();
                    response = new MessageDTO() { Action = EndpointAction.GET_BOOKS.GetString(), Body = JsonConvert.SerializeObject(books), Type = "Array:Book" };
                    break;

                case EndpointAction.GET_USERS:
                    IEnumerable<UserDTO> users = _userService.GetAllUsers();
                    response = new MessageDTO() { Action = EndpointAction.GET_USERS.GetString(), Body = JsonConvert.SerializeObject(users), Type = "Array:User" };
                    break;

                case EndpointAction.GET_DISCOUNT_CODES:
                    IEnumerable<DiscountCodeDTO> discountCodes = _discountCodeService.GetAllDiscountCodes();
                    response = new MessageDTO() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString(), Body = JsonConvert.SerializeObject(discountCodes), Type = "Array:DiscountCode" };
                    break;

                case EndpointAction.DISCONNECT:
                    WebsocketServer.Instance.Dispose();
                    response = new MessageDTO() { Action = EndpointAction.DISCONNECT.GetString(), Body = null, Type = "null" };
                    break;
                default:
                    throw new NotSupportedException("Requested action is not supported");
            }
            return JsonConvert.SerializeObject(response);
        }
    }
}
