using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using Tickets.Data;
using Tickets.Data.Enums;
using Tickets.Data.ViewModels;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class FilmeController : Controller
    {
        ApplicationDbContext db;

        public FilmeController(ApplicationDbContext context)
        {

            db = context;
        }
        public IActionResult Index()
        {

            var listaFilmes = db.Tfilmes
             .Join(db.Tcinemas,
                 filme => filme.CinemaId,
                 cinema => cinema.Id,
                 (filme, cinema) => new { Filme = filme, Cinema = cinema.Nome })
             .Select(m => new {
                 m.Filme.Id,
                 m.Filme.Cartazurl,
                 m.Filme.Titulo,
                 m.Filme.Sinopse,
                 m.Filme.Preco,
                 m.Filme.DataInicio,
                 m.Filme.DataFim,
                 m.Filme.MovieCategory,
                 m.Filme.ProdutorId,
                 m.Filme.CinemaId,
                 Nome = m.Cinema
             })
             .ToList();
            ViewBag.ListaFilmes = listaFilmes;
            return View();
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var detalhesFilme = db.Tfilmes
               .Join(db.Tcinemas,
                   filme => filme.CinemaId,
                   cinema => cinema.Id,
                   (filme, cinema) => new { Filme = filme, Cinema = cinema.Nome })
               .Where(m => m.Filme.Id == id)
               .Select(m => new {
                   m.Filme.Id,
                   m.Filme.Cartazurl,
                   m.Filme.Titulo,
                   m.Filme.Sinopse,
                   m.Filme.Preco,
                   m.Filme.DataInicio,
                   m.Filme.DataFim,
                   m.Filme.MovieCategory,
                   m.Filme.ProdutorId,
                   m.Filme.CinemaId,
                   Nome = m.Cinema
               })
               .ToList();
            ViewBag.DetalhesF = detalhesFilme;

            var detalhesProdutor = db.Tfilmes
               .Join(db.Tprodutores,
                   filme => filme.ProdutorId,
                   produtor => produtor.Id,
                   (filme, produtor) => new { Filme = filme, Produtor = produtor.Nome })
               .Where(m => m.Filme.Id == id)
               .Select(m => new {
                   m.Filme.Id,
                   m.Filme.Cartazurl,
                   m.Filme.Titulo,
                   m.Filme.Sinopse,
                   m.Filme.Preco,
                   m.Filme.DataInicio,
                   m.Filme.DataFim,
                   m.Filme.MovieCategory,
                   m.Filme.ProdutorId,
                   m.Filme.CinemaId,
                   Nome = m.Produtor
               })
               .ToList();
            ViewBag.DetalhesP = detalhesProdutor;

            var detalhesElenco = db.Tfilmes
                .Where(filme => filme.Id == id)
                .Select(filme => new
                {
                    filme.Id,
                    filme.Cartazurl,
                    filme.Titulo,
                    filme.Sinopse,
                    filme.Preco,
                    filme.DataInicio,
                    filme.DataFim,
                    filme.MovieCategory,
                    filme.ProdutorId,
                    filme.CinemaId,
                    Elenco = db.Telencos
                        .Where(elenco => elenco.FilmeId == filme.Id)
                        .Join(db.Tatores,
                        elenco => elenco.AtorId,
                        ator => ator.Id,
                        (elenco, ator) => new { ElencoAtorId = elenco.AtorId, NomeAtor = ator.NomeAtor, FotoProfile = ator.FotoProfile })
                        .ToList()
                });

            ViewBag.DetalhesE = detalhesElenco;
            return View();

        }
        public async Task<IActionResult> Criar()
        {
            var dropdownlist = new VMFilmeDropdowns();
            dropdownlist.Atores = await db.Tatores.OrderBy(n => n.NomeAtor).ToListAsync();
            dropdownlist.Cinemas = await db.Tcinemas.OrderBy(n => n.Nome).ToListAsync();
            dropdownlist.Produtores = await db.Tprodutores.OrderBy(n => n.Nome).ToListAsync();


            ViewBag.CinemaId = new SelectList(dropdownlist.Cinemas, "Id", "Nome");
            ViewBag.AtorId = new SelectList(dropdownlist.Atores, "Id", "NomeAtor");
            ViewBag.ProdutorId = new SelectList(dropdownlist.Produtores, "Id", "Nome");
            ViewBag.MovieCategory = new SelectList(Enum.GetValues(typeof(MovieCategory)));

            var dados = new AddVMFilme();
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(AddVMFilme dados, Filme filme)
        {


            if (!ModelState.IsValid)
            {
                AddVMFilme modelo = new AddVMFilme()
                {

                    Titulo = dados.Titulo,
                    ProdutorId = dados.ProdutorId,
                    CinemaId = dados.CinemaId,
                    Sinopse = dados.Sinopse,
                    Preco = dados.Preco,
                    DataFim = dados.DataFim,
                    DataInicio = dados.DataInicio,
                    MovieCategory = dados.MovieCategory,
                    Cartazurl = dados.Cartazurl,
                };


                return View(modelo);
            }


            Filme novoFilme = new Filme()
            {

                Titulo = dados.Titulo,
                ProdutorId = dados.ProdutorId,
                CinemaId = dados.CinemaId,
                Sinopse = dados.Sinopse,
                Preco = dados.Preco,
                DataFim = dados.DataFim,
                DataInicio = dados.DataInicio,
                MovieCategory = dados.MovieCategory,
                Cartazurl = dados.Cartazurl,
            };

            filme = novoFilme;

            await db.Tfilmes.AddAsync(filme);
            await db.SaveChangesAsync();

            foreach (var atorId in dados.AtorIds) {

                var novoElenco = new Elenco()
                {
                    FilmeId = novoFilme.Id,
                    AtorId = atorId
                };
                await db.Telencos.AddAsync(novoElenco);
                await db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Editar(int id)
        {

            var detalhesFilme = await db.Tfilmes.FirstOrDefaultAsync(x => x.Id == id);
            if (detalhesFilme == null) { return NotFound(); }

            AddVMFilme dados = new AddVMFilme()
            {
                Id = detalhesFilme.Id,
                Titulo = detalhesFilme.Titulo,
                ProdutorId = detalhesFilme.ProdutorId,
                CinemaId = detalhesFilme.CinemaId,
                Sinopse = detalhesFilme.Sinopse,
                Preco = detalhesFilme.Preco,
                DataFim = detalhesFilme.DataFim,
                DataInicio = detalhesFilme.DataInicio,
                MovieCategory = detalhesFilme.MovieCategory,
                Cartazurl = detalhesFilme.Cartazurl,
            };

            var dropdownlist = new VMFilmeDropdowns();
            dropdownlist.Atores = await db.Tatores.OrderBy(n => n.NomeAtor).ToListAsync();
            dropdownlist.Cinemas = await db.Tcinemas.OrderBy(n => n.Nome).ToListAsync();
            dropdownlist.Produtores = await db.Tprodutores.OrderBy(n => n.Nome).ToListAsync();


            ViewBag.CinemaId = new SelectList(dropdownlist.Cinemas, "Id", "Nome");
            ViewBag.AtorId = new SelectList(dropdownlist.Atores, "Id", "NomeAtor");
            ViewBag.ProdutorId = new SelectList(dropdownlist.Produtores, "Id", "Nome");
            ViewBag.MovieCategory = new SelectList(Enum.GetValues(typeof(MovieCategory)));


            return View(dados);

        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, AddVMFilme dados)
        {
            if (id != dados.Id) { return NotFound(); }

            var filmeEditado = await db.Tfilmes.FirstOrDefaultAsync(n => n.Id == id);
            if (filmeEditado != null) {

                filmeEditado.Titulo = dados.Titulo;
                filmeEditado.ProdutorId = dados.ProdutorId;
                filmeEditado.CinemaId = dados.CinemaId;
                filmeEditado.Sinopse = dados.Sinopse;
                filmeEditado.Preco = dados.Preco;
                filmeEditado.DataFim = dados.DataFim;
                filmeEditado.DataInicio = dados.DataInicio;
                filmeEditado.MovieCategory = dados.MovieCategory;
                filmeEditado.Cartazurl = dados.Cartazurl;
                await db.SaveChangesAsync();

            }

            var elenco = db.Telencos.Where(n => n.FilmeId == dados.Id).ToList();
            db.Telencos.RemoveRange(elenco);
            await db.SaveChangesAsync();

            foreach (var atorId in dados.AtorIds)
            {

                var novoElenco = new Elenco()
                {
                    FilmeId = dados.Id,
                    AtorId = atorId
                };
                await db.Telencos.AddAsync(novoElenco);

            }
            await db.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }




        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filme = await db.Tfilmes.FirstOrDefaultAsync(n => n.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            return View(filme);

        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {

            return View();
        }

        public async Task<IActionResult> Buscar(String buscarString)
        {
            var listaFilmes = db.Tfilmes
            .Join(db.Tcinemas,
                filme => filme.CinemaId,
                cinema => cinema.Id,
                (filme, cinema) => new { Filme = filme, Cinema = cinema.Nome })
            .Select(m => new {
                m.Filme.Id,
                m.Filme.Cartazurl,
                m.Filme.Titulo,
                m.Filme.Sinopse,
                m.Filme.Preco,
                m.Filme.DataInicio,
                m.Filme.DataFim,
                m.Filme.MovieCategory,
                m.Filme.ProdutorId,
                m.Filme.CinemaId,
                Nome = m.Cinema
            })
            .ToList();


            if (!string.IsNullOrEmpty(buscarString)){
                var buscarFilmes = listaFilmes.Where(n => n.Titulo.Contains(buscarString) || n.Sinopse.Contains(buscarString)).ToList();
                ViewBag.ListaFilmes = buscarFilmes;
                return View("Index");
            }

            ViewBag.ListaFilmes = listaFilmes;
            return View("Index");


    }   }

   
}
