using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Registo
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }


    }
}
