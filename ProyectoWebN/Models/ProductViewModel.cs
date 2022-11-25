using ProyectoWebN.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWebN.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }

    }
}
