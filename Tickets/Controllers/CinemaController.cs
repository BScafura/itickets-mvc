using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class CinemaController : Controller
    {
        ApplicationDbContext db;

        public CinemaController(ApplicationDbContext context)
        {

            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var listaCinemas = await db.Tcinemas.ToListAsync(); 
            return View(listaCinemas);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Criar([Bind("Id,Nome,Logo,Descricao")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }

            await db.Tcinemas.AddAsync(cinema);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var maisInfos = await db.Tcinemas.FirstOrDefaultAsync(n => n.Id == id);
            if (maisInfos == null)
            {
                return NotFound();
            }
            return View(maisInfos);

        }
        public async Task<IActionResult> Editar(int id)
        {
            var editar = await db.Tcinemas.FirstOrDefaultAsync(n => n.Id == id);
            if (editar == null)
            {
                return NotFound();
            }
            return View(editar);

        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Logo,Nome,Descricao")] Cinema cinema)
        {
            if (id != cinema.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbCinema = await db.Tcinemas.FindAsync(id);
                    if (dbCinema == null)
                    {
                        return NotFound();
                    }

                    dbCinema.Nome = cinema.Nome;
                    dbCinema.Logo = cinema.Logo;
                    dbCinema.Descricao = cinema.Descricao;

                    db.Tcinemas.Update(dbCinema);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinemaExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(cinema);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinema = await db.Tcinemas.FirstOrDefaultAsync(n => n.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            return View(cinema);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> ConfirmarDelete(int id)
        {
            var cinema = await db.Tcinemas.FindAsync(id);
            if (cinema != null)
            {
                db.Tcinemas.Remove(cinema);
            }
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        private bool CinemaExists(int id)
        {
            return db.Tcinemas.Any(e => e.Id == id);
        }
    }
}
