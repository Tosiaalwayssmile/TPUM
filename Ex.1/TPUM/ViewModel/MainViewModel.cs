using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ViewLayer.Commands;

namespace ViewLayer.ViewModel
{
    public class MainViewModel
    {
        public ICommand FetchUsersCommand => new Command(FetchUsers);
        public ICommand FetchBooksCommand => new Command(FetchBooks);
        public ICommand FetchDiscountCodesCommand => new Command(FetchDiscountCodes);
       
        private void FetchUsers()
        {
            MessageBox.Show("1");
        }       
        private void FetchBooks()
        {
            MessageBox.Show("2");
        }        
        private void FetchDiscountCodes()
        {
            MessageBox.Show("3");
        }
    }
}