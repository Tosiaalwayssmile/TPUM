using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using LogicLayer.DTOs;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using static LogicLayer.Interfaces.IWebSocketManager;
using DataLayer.Websockets;

namespace LogicLayer
{
    public class WebSocketManager : Interfaces.IWebSocketManager
    {
        private static WebSocketManager _Instance;
        public static WebSocketManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new WebSocketManager();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }

        public Books onBooksRecieve;
        public Users onUsersRecieve;
        public DiscountCodes onCodesRecieve;
        public SingleDiscountCode onSingleCodeRecieve;


        private WebSocketManager()
        {
            DataLayer.Model.WebSocketMessage.onMessageRecieved += RecieveMessage;
        }

        public void Connect()
        {
            DataLayer.Model.WebSocketMessage.Connect();
        }

        public void Disconnect()
        {
            DataLayer.Model.WebSocketMessage.Disconnect();
        }

        public void RecieveMessage(string data)
        {
            Trace.WriteLine("RECEIVED:");
            Trace.WriteLine(data);
            Message message = JsonConvert.DeserializeObject<Message>(data);
            Enum.TryParse(message.Action, out EndpointAction action);
            switch (action)
            {
                case EndpointAction.GET_BOOKS:
                    List<BookDTO> bookArray = JsonConvert.DeserializeObject<List<BookDTO>>(message.Body);
                    onBooksRecieve?.Invoke(new ObservableCollection<BookDTO>(bookArray));
                    break;
                case EndpointAction.GET_USERS:
                    List<UserDTO> userArray = JsonConvert.DeserializeObject<List<UserDTO>>(message.Body);
                    onUsersRecieve?.Invoke(new ObservableCollection<UserDTO>(userArray));
                    break;
                case EndpointAction.GET_DISCOUNT_CODES:
                    List<DiscountCodeDTO> discountArrays = JsonConvert.DeserializeObject<List<DiscountCodeDTO>>(message.Body);
                    onCodesRecieve?.Invoke(new ObservableCollection<DiscountCodeDTO>(discountArrays));
                    break;
                case EndpointAction.PUBLISH_DISCOUNT_CODE:
                    DiscountCodeDTO code = JsonConvert.DeserializeObject<DiscountCodeDTO>(message.Body);
                    onSingleCodeRecieve?.Invoke(code);
                    break;
            }
        }

        public void AddOnBooksRecieve(Books method) => onBooksRecieve += method;
        public void AddOnUsersRecieve(Users method) => onUsersRecieve += method;
        public void AddOnCodesRecieve(DiscountCodes method) => onCodesRecieve += method;
        public void AddOnSingleCodeRecieve(SingleDiscountCode method) => onSingleCodeRecieve += method;

        public void FetchUsers()
        {
            DataLayer.Model.WebSocketMessage.FetchUsers();
        }

        public void FetchBooks()
        {
            DataLayer.Model.WebSocketMessage.FetchBooks();
        }

        public void FetchCodes()
        {
            DataLayer.Model.WebSocketMessage.FetchCodes();
        }

        public void FetchSingleCode()
        {
            DataLayer.Model.WebSocketMessage.FetchSingleCode();
        }
    }
}
