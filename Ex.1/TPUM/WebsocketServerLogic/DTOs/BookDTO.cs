using System;
using System.ComponentModel.DataAnnotations;

namespace WebsocketServerLogic.DTOs
{
    public class BookDTO
    {
        public Guid? Guid { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFN { get; set; }

        public string AuthorLN { get; set; }

        public string Genre { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        public int ISBN { get; set; }

        [Required]
        public int Pages { get; set; }
    }
}
