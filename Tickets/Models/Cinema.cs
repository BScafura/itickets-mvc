using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name ="Logo do Cinema")]
        public string? Logo { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve ter entre 3 e 50 caracteres")]
        [Display(Name = "Nome do Cinema")]
        public string? Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Descrição do Cinema")]
        public string? Descricao { get; set; }

        public virtual ICollection<Filme>? Filmes { get; set; }

    }
}
