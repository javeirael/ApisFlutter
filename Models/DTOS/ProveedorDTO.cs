using System.ComponentModel.DataAnnotations;

namespace ApisFlutter.Models.DTOS
{
    public class ProveedorDTO
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Contacto { get; set; }
    }
}
