using System;
using System.ComponentModel.DataAnnotations;
using WebsocketServerData.Model;

namespace WebsocketServerLogic.DTOs
{
    public class UserDTO
    {
        public Guid? Guid { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public Cart Cart { get; set; }
    }
}
