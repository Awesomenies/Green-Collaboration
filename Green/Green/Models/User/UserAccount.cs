using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Green.Models.User
{
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Indtast venligst dit navn")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Indtast venligst dit efternavn")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Indtast venligst din E-mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Indtast venligst din fødselsdag")]
        public DateTime Birthday { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Indtast venligst et password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Venligst bekræft password")]
        public string ConformPassword { get; set; }

    }
}