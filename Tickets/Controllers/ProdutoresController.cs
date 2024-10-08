using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class ProdutoresController : Controller
    {
        ApplicationDbContext db;

        public ProdutoresController(ApplicationDbContext context)
        {

            db = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Models.Produtor> listaProdutores = await db.Tprodutores.ToListAsync();
            return View(listaProdutores);
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Criar([Bind("Id,Nome,FotoProfile,Bio")] Produtor produtor)
        {
            if (!ModelState.IsValid)
            {
                return View(produtor);
            }

            await db.Tprodutores.AddAsync(produtor);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var maisInfos = await db.Tprodutores.FirstOrDefaultAsync(n => n.Id == id);
            if (maisInfos == null)
            {
                return NotFound();
            }
            return View(maisInfos);

        }
        public async Task<IActionResult> Editar(int id)
        {
            var editar = await db.Tprodutores.FirstOrDefaultAsync(n => n.Id == id);
            if (editar == null)
            {
                return NotFound();
            }
            return View(editar);

        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,FotoProfile,Bio")] Produtor produtor)
        {
            if (id != produtor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbAtor = await db.Tprodutores.FindAsync(id);
                    if (dbAtor == null)
                    {
                        return NotFound();
                    }

                    dbAtor.Nome = produtor.Nome;
                    dbAtor.FotoProfile = produtor.FotoProfile;
                    dbAtor.Bio = produtor.Bio;

                    db.Tprodutores.Update(dbAtor);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutorExists(id))
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

            return View(produtor);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtor = await db.Tprodutores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtor == null)
            {
                return NotFound();
            }

            return View(produtor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> ConfirmarDelete(int id)
        {
            var produtor = await db.Tprodutores.FindAsync(id);
            if (produtor != null)
            {
                db.Tprodutores.Remove(produtor);
            }

            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

   




        private bool ProdutorExists(int id)
        {
            return db.Tprodutores.Any(e => e.Id == id);
        }


    }
}
