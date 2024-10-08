using Tickets.Data.Enums;
using Tickets.Models;

namespace Tickets.Data.ViewModels
{
    public class VMFilmeDropdowns
    {
        public VMFilmeDropdowns() { 
            Produtores = new List<Produtor>();
            Cinemas = new List<Cinema>();
            Atores = new List<Ator>();
           
        }
        
        
        public List<Produtor> Produtores { get; set; }

        public List<Cinema> Cinemas { get; set;}

        public List<Ator> Atores { get; set; }
    }
}
