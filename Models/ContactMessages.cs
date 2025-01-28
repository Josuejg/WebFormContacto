using System.ComponentModel.DataAnnotations;

namespace WebFormContacto.Models
{
    public class ContactMessages
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El corre electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(75, ErrorMessage = "El correo no puede exceder los 75 caracteres")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(150, ErrorMessage = "El correo no puede exceder los 150 caracteres")]
        public string Mensaje { get; set; }

    }
}
