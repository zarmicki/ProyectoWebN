using System.ComponentModel.DataAnnotations;

namespace ProyectoWebN.Models
{
    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apelidos")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Nombre de usuario")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Clave")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}
