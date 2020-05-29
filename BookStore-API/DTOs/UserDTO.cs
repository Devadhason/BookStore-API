using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [StringLength(15,ErrorMessage ="Your Password is limited {2} to {1}", MinimumLength =6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
