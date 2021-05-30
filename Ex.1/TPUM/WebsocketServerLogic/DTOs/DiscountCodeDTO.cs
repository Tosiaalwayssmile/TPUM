using System;
using System.ComponentModel.DataAnnotations;

namespace WebsocketServerLogic.DTOs
{
    public class DiscountCodeDTO
    {
        public Guid? Guid { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
