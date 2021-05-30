using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebsocketServerData.Model;

namespace WebsocketServerLogic.DTOs
{
    public class CartDTO
    {
        public Guid? Guid { get; set; }

        [Required]
        public User User { get; set; }

        public IList<Book> Books { get; set; }
    }
}
