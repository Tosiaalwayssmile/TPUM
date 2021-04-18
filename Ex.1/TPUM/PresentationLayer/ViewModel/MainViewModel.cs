using System.Windows;
using System.Windows.Input;
using PresentationLayer.Commands;
using LogicLayer;

namespace PresentationLayer.ViewModel
{
    public class MainViewModel
    {
        private MainLogic logic = MainLogic.Instance;

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