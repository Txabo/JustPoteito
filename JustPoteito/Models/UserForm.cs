using System.ComponentModel.DataAnnotations;

namespace JustPoteito.Models
{
    public class UserForm {

        [Required(ErrorMessage = "Mail cannot be empty")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email{get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(70, ErrorMessage = "Must be between 5 and 70 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password{get; set; }

        public UserForm() { }

        public UserForm(string mail, string password)
        {
            email = mail;
            this.password = password;
        }
    }
}
