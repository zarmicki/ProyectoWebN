using ProyectoWebN.Data.Entidad;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWebN.Data.Entity
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Producto")]
        [MaxLength(150, ErrorMessage = "El campo {0} su maximo de caracteres es de {1}")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public string Name { get; set; } = null!;

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; } = null!;

        public DateTime? LastPurchase { get; set; }

        public DateTime? LastSale { get; set; }

        [Display(Name = "Activo")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        public bool IsActive { set; get; }

        [Display(Name = "Stock en almacenes")]
        [Required(ErrorMessage = "El campo {0} es requerido...")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { set; get; }
    }
}
