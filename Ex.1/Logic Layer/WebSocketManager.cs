using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using LogicLayer.Websockets;
using LogicLayer.DTOs;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using static LogicLayer.Interfaces.IWebSocketManager;

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
        public DicountCodes onCodesRecieve;
        public SingleDiscountCode onSingleCodeRecieve;

        private SocketConnection _connection;
        private WebsocketClient _websocketClient = new WebsocketClient("ws://localhost:9000/api");



        private WebSocketManager()
        {
            DataLayer.Model.WebSocketMessage.onMessageRecieved += RecieveMessage;
        }

        public async void Connect()
        {
            _connection = await _websocketClient.Connect(DataLayer.Model.WebSocketMessage.OnMessageRecieved);
        }

        public async void Disconnect()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.DISCONNECT.GetString(), Type = WebSocketMessageType.Close.ToString() };
                await _connection.SendAsync(messageSent.ToString());
                DataLayer.Model.WebSocketMessage.onMessageRecieved -= RecieveMessage;
            }
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
        public void AddOnCodesRecieve(DicountCodes method) => onCodesRecieve += method;
        public void AddOnSingleCodeRecieve(SingleDiscountCode method) => onSingleCodeRecieve += method;

        public async void FetchUsers()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_USERS.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public async void FetchBooks()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_BOOKS.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public async void FetchCodes()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public async void FetchSingleCode()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }
    }
}
