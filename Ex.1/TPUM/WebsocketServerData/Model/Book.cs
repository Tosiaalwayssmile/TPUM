using System.ComponentModel.DataAnnotations;
using System;

namespace WebsocketServerData.Model
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

        public override bool Equals(object obj)
        {
            Book other = (Book)obj;

            return (
                string.Equals(Title, other.Title) &&
                string.Equals(AuthorFN, other.AuthorFN) &&
                string.Equals(AuthorLN, other.AuthorLN) &&
                string.Equals(Genre, other.Genre) &&
                string.Equals(Publisher, other.Publisher) &&
                DateTime.Equals(ReleaseDate, other.ReleaseDate) &&
                ISBN == other.ISBN &&
                Pages == other.Pages);
        }
    }
}
