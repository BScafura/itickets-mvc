using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tickets.Data.Enums;

namespace Tickets.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        public int ProdutorId { get; set; }
        public int CinemaId { get; set; }

        [Display(Name = "Cartaz")]
        public string? Cartazurl { get; set; }

        [Display(Name = "Titulo")]
        public string? Titulo { get; set; } 
      
        [Display(Name = "Sinopse")]
        public string? Sinopse { get; set; }
        [DisplayFormat(DataFormatString = "{0:n} €")]
        public double Preco { get; set; }
       
        public DateTime DataInicio { get; set; }
        
        public DateTime DataFim { get; set; }
        
        [Required]
        public MovieCategory? MovieCategory { get; set; }

        public virtual ICollection<Elenco>? Elencos { get; set;}
        public virtual Produtor? Produtor { get; set; }        
        public virtual Cinema? Cinema { get; set; }
    }
}
