using System.ComponentModel.DataAnnotations;
using System.Data;

namespace JustPoteito.Models
{
    public class User
    {

        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surnames are required")]
        public string Surnames { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Formato de email incorrecto")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(70, ErrorMessage = "Must be between 5 and 70 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required]
        public bool Enabled { get; set; }

        //[Required]
        public List<Role> Roles { get; set; }

        public User()
        {
        }

        public User(int id, string name, string surnames, string userName, string email, string password, bool enabled, List<Role> roles)
        {
            Id = id;
            Name = name;
            Surnames = surnames;
            UserName = userName;
            Email = email;
            Password = password;
            Enabled = enabled;
            Roles = roles;
        }

        //[Required(ErrorMessage = "Role is required")]
        //public List<Role>? Roles { get; set; }




    }
}