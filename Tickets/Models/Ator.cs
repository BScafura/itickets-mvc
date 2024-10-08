using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Ator
    {
        
        public int Id { get; set; }

        [Display(Name = "Foto")]
        [Required(ErrorMessage ="Campo obrigatório!")]
        public string? FotoProfile { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo nome deve ter entre 3 e 50 caracteres")]
        public string? NomeAtor { get; set; }
       
        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Bio { get; set; }

        public virtual ICollection<Elenco>? Elencos { get; set; }

    }
}
