using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogicLayer.DTOs
{
    public class CartDTO
    {
        public Guid? Guid { get; set; }

        [Required]
        public User User { get; set; }

        public IList<Book> Books { get; set; }
    }
}
