using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Is required.")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Is requried.")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Is requried.")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped] //Makes sure that it doesn't get added to DB
        [Required(ErrorMessage = "Is requried.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}