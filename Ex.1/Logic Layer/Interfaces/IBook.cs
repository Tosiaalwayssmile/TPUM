using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    interface IBook
    {
        public string GetTitle();
        public string GetAuthorFN();
        public string GetAuthorLN();
        public string GetGenre();
        public decimal GetPrice();
        public string GetPublisher();
        public DateTime GetReleaseDate();
        public int GetISBN();
        public int GetPages();

    }
}
