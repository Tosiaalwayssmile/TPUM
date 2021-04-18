using System.ComponentModel.DataAnnotations;
using System;

namespace DataLayer.Model
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public string AuthorFN { get; set; }

        public string AuthorLN { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int ISBN { get; set; }

        public int Pages { get; set; }


    }
}
