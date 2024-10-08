using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tickets.Data.Enums;

namespace Tickets.Models
{
    public class AddVMFilme
    {

        public int Id { get; set; }

        [Display(Name = "Cartaz (url da imagem)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Cartazurl { get; set; }

        [Display(Name = "Titulo")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string? Titulo { get; set; } 
      
        [Display(Name = "Sinopse")]
        public string? Sinopse { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name ="Preço")]
        public double Preco { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Quando entrará em exibição? ")]
        public DateTime DataInicio { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Até quando ficará em exibição? ")]
        public DateTime DataFim { get; set; }
        
       
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Selecione uma categoria: ")]
        public MovieCategory? MovieCategory { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Selecione um ou mais atores: ")]
        public virtual List<int>? AtorIds { get; set;}
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Selecione um produtor:")]
        public int ProdutorId { get; set; }

        [Display(Name ="Selecione um cinema:")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int CinemaId { get; set; }

    }
}
