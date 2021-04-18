using System.Windows;
using System.Windows.Input;
using PresentationLayer.Commands;
using LogicLayer;
using System.Collections.ObjectModel;
using LogicLayer.DTOs;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using LogicLayer.Interfaces;

namespace PresentationLayer.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IMainLogic logic = MainLogic.Instance;

        private ObservableCollection<UserDTO> _users;
        private ObservableCollection<BookDTO> _books;
        private ObservableCollection<DiscountCodeDTO> _discountCodes;

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

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand FetchUsersCommand => new Command(FetchUsers);
        public ICommand FetchBooksCommand => new Command(FetchBooks);
        public ICommand FetchDiscountCodesCommand => new Command(FetchDiscountCodes);

        // METHODS

        // Constructor
        public MainViewModel() { }

        private void FetchUsers()
        {
            Users = new ObservableCollection<UserDTO>(logic.GetAllUsers());
        }       
        private void FetchBooks()
        {
            Books = new ObservableCollection<BookDTO>(logic.GetAllBooks());
        }        
        private void FetchDiscountCodes()
        {
            DiscountCodes = new ObservableCollection<DiscountCodeDTO>(logic.GetAllDiscountCodes());
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}