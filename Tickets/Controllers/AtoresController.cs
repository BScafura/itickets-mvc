using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class AtoresController : Controller
    {
        ApplicationDbContext db;

        public AtoresController(ApplicationDbContext context)
        {

            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var listaAtores = await db.Tatores.ToListAsync();
            return View(listaAtores);
        }

        public IActionResult Criar()
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Criar([Bind("Id,NomeAtor,FotoProfile,Bio")]Ator ator)
        {   
            if (!ModelState.IsValid)
            {
                return View(ator);
            }

            await db.Tatores.AddAsync(ator);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var maisInfos = await db.Tatores.FirstOrDefaultAsync(n=> n.Id == id);
            if (maisInfos == null)
            {
                return NotFound();
            }  
            return View(maisInfos);

        }
        public async Task<IActionResult> Editar(int id)
        {
            var editar = await db.Tatores.FirstOrDefaultAsync(n => n.Id == id);
            if (editar == null)
            {
                return NotFound();
            }
            return View(editar);

        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,FotoProfile,Bio")] Ator ator)
        {
            if (id != ator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbAtor = await db.Tatores.FindAsync(id);
                    if (dbAtor == null)
                    {
                        return NotFound();
                    }

                    dbAtor.NomeAtor = ator.NomeAtor;
                    dbAtor.FotoProfile = ator.FotoProfile;
                    dbAtor.Bio = ator.Bio;

                    db.Tatores.Update(dbAtor);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtorExists(id))
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

            return View(ator);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var ator = await db.Tatores.FirstOrDefaultAsync(n => n.Id == id);
            if (ator == null)
            {
                return NotFound();
            }
            return View(ator);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> ConfirmarDelete(int id)
        {
            var ator = await db.Tatores.FindAsync(id);
            if (ator != null)
            {
                db.Tatores.Remove(ator);
            }
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

       

        private bool AtorExists(int id)
        {
            return db.Tatores.Any(e => e.Id == id);
        }



    }
}

