using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWebN.Data.Entity
{
    public class User : IdentityUser
    {
        [Display(Name = "Nombres")]
        [MaxLength(150, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        public string FirstName { set; get; }

        [Display(Name = "Apellidos")]
        [MaxLength(150, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        public string LastName { set; get; }


    }
}
