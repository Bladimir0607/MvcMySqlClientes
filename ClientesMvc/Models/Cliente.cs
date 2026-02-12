using System.ComponentModel.DataAnnotations;

namespace ClientesMvc.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }
    }
}