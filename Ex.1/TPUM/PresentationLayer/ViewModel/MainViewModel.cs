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
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace PresentationLayer.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IMainLogic logic = MainLogic.Instance;
        private IWebSocketManager webManager = WebSocketManager.Instance;

        private ObservableCollection<UserDTO> _users;
        private ObservableCollection<BookDTO> _books;
        private ObservableCollection<DiscountCodeDTO> _discountCodes;
        private MessagePublisher _messagePublisher;
        private DiscountCodeDTO _currentDiscountCode;

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

        public ICommand ConnectToWebsocketCommand => new Command(webManager.Connect);
        public ICommand DisconnectCommand => new Command(webManager.Disconnect);
        public ICommand FetchUsersCommand => new Command(webManager.FetchUsers);
        public ICommand FetchBooksCommand => new Command(webManager.FetchBooks);
        public ICommand FetchDiscountCodesCommand => new Command(webManager.FetchCodes);
        public ICommand FetchCurrentDiscountCodeCommand => new Command(webManager.FetchSingleCode);

        // METHODS

        // Constructor
        public MainViewModel()
        {
            _messagePublisher = new MessagePublisher(TimeSpan.FromSeconds(3));
            _messagePublisher.Start();

            webManager.AddOnBooksRecieve(GetBooks);
            webManager.AddOnUsersRecieve(GetUsers);
            webManager.AddOnCodesRecieve(GetCodes);
            webManager.AddOnSingleCodeRecieve(GetSingleCode);
        }

        private void GetBooks(IList<BookDTO> books)
        {
            Books = (ObservableCollection<BookDTO>)books;
        }
        public void GetUsers(IList<UserDTO> users)
        {
            Users = (ObservableCollection<UserDTO>)users;
        }
        public void GetCodes(IList<DiscountCodeDTO> codes)
        {
            DiscountCodes = (ObservableCollection<DiscountCodeDTO>)codes;
        }
        public void GetSingleCode(DiscountCodeDTO code)
        {
            CurrentDiscountCode = code;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}