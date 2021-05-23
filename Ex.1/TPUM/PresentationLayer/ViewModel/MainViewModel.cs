using System.Windows;
using System.Windows.Input;
using PresentationLayer.Commands;
using LogicLayer;
using System.Collections.ObjectModel;
using LogicLayer.DTOs;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using LogicLayer.Interfaces;
using System;
using System.Reactive;
using System.Reactive.Linq;
using PresentationLayer.Websockets;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace PresentationLayer.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IMainLogic logic = MainLogic.Instance;

        private ObservableCollection<UserDTO> _users;
        private ObservableCollection<BookDTO> _books;
        private ObservableCollection<DiscountCodeDTO> _discountCodes;
        private MessagePublisher _messagePublisher;
        private DiscountCodeDTO _currentDiscountCode;
        private SocketConnection _connection;
        private WebsocketClient _websocketClient = new WebsocketClient("ws://localhost:9000/api");


        public ObservableCollection<UserDTO> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<BookDTO> Books
        {
            get => _books;
            set
            {
                _books = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<DiscountCodeDTO> DiscountCodes
        {
            get => _discountCodes;
            set
            {
                _discountCodes = value;
                OnPropertyChanged();
            }
        }
        public DiscountCodeDTO CurrentDiscountCode
        {
            get => _currentDiscountCode;
            set
            {
                _currentDiscountCode = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ConnectToWebsocketCommand => new Command(CreateConnection);
        public ICommand DisconnectCommand => new Command(Disconnect);
        public ICommand FetchUsersCommand => new Command(FetchUsers);
        public ICommand FetchBooksCommand => new Command(FetchBooks);
        public ICommand FetchDiscountCodesCommand => new Command(FetchDiscountCodes);
        public ICommand FetchCurrentDiscountCodeCommand => new Command(FetchCurrentDiscountCommand);

        // METHODS

        // Constructor
        public MainViewModel()
        {
            _messagePublisher = new MessagePublisher(TimeSpan.FromSeconds(3));
            _messagePublisher.Start();
        }

        private async void CreateConnection()
        {
            _connection = await _websocketClient.Connect(OnMessageReceived);
        }
        private async void Disconnect()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.DISCONNECT.GetString(), Type = WebSocketMessageType.Close.ToString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }
        private async void FetchUsers()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_USERS.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }
        private async void FetchBooks()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_BOOKS.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }
        private async void FetchDiscountCodes()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }
        private async void FetchCurrentDiscountCommand()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnMessageReceived(string data)
        {
            Trace.WriteLine("RECEIVED:");
            Trace.WriteLine(data);
            Message message = JsonConvert.DeserializeObject<Message>(data);
            Enum.TryParse(message.Action, out EndpointAction action);
            switch (action)
            {
                case EndpointAction.GET_BOOKS:
                    List<BookDTO> bookArray = JsonConvert.DeserializeObject<List<BookDTO>>(message.Body);
                    Books = new ObservableCollection<BookDTO>(bookArray);
                    break;
                case EndpointAction.GET_USERS:
                    List<UserDTO> userArray = JsonConvert.DeserializeObject<List<UserDTO>>(message.Body);
                    Users = new ObservableCollection<UserDTO>(userArray);
                    break;
                case EndpointAction.GET_DISCOUNT_CODES:
                    List<DiscountCodeDTO> discountArrays = JsonConvert.DeserializeObject<List<DiscountCodeDTO>>(message.Body);
                    DiscountCodes = new ObservableCollection<DiscountCodeDTO>(discountArrays);
                    break;
                case EndpointAction.PUBLISH_DISCOUNT_CODE:
                    DiscountCodeDTO code = JsonConvert.DeserializeObject<DiscountCodeDTO>(message.Body);
                    CurrentDiscountCode = code;
                    break;
            }
        }
    }
}