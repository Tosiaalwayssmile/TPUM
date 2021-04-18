using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataLayer;

namespace LogicLayer
{
    public class MainLogic : Interfaces.IMainLogic
    {
        private DataStore data = DataStore.Instance;

        private static MainLogic _instance;
        private static readonly object Padlock = new object();
        public static MainLogic Instance
        {
            get
            {
                lock (Padlock)
                {
                    _instance ??= new MainLogic();
                    return _instance;
                }
            }
        }

        private MainLogic() { }
        


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
