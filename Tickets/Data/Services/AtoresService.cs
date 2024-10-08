using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class AtoresService : IAtoresService
    {
        ApplicationDbContext db;

        public AtoresService(ApplicationDbContext context)
        {

            db = context;
        }

        public void Add(Ator ator)
        {
            throw new NotImplementedException();
        }

        public Ator delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ator GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ator>> listarTodos()
        {
            return await db.Tatores.ToListAsync();
            
        }

        public Ator update(int id, Ator newAtor)
        {
            throw new NotImplementedException();
        }
    }
}
