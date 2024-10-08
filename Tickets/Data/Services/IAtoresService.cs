using System.Collections;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public interface IAtoresService
    {
        Task <IEnumerable<Ator>> listarTodos();
        Ator GetById(int id);

        void Add(Ator ator);

        Ator update(int id, Ator newAtor);

        Ator delete(int id);    
    }
}
