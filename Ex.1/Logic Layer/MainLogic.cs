using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LogicLayer
{
    class MainLogic : Interfaces.IMainLogic
    {
        public void FetchBooksCommand()
        {
            MessageBox.Show("Hallo Books");
        }

        public void FetchDiscountCodesCommand()
        {
            MessageBox.Show("Hallo Codes");
        }

        public void FetchUsersCommand()
        {
            MessageBox.Show("Hallo Users");
        }
    }
}
