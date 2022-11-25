using ProyectoWebN.Data.Entidad;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWebN.Data.Entity
{
    public class City : IEntity
    {
        public int Id { set; get; } //autonumerico - Key Primary

        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public string Name { set; get; } = null!;

        [Display(Name = "Activo")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public bool IsActive { set; get; }

        public User User { set; get; }
    }
}