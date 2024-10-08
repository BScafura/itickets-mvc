using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Data.Cart;
using Tickets.Data.ViewModels;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class OrdemsController : Controller
    {
        ApplicationDbContext db;

        Carrinho carrinhoLoja;

        public OrdemsController(ApplicationDbContext context, Carrinho _carrinho)
        {
            db = context;
            carrinhoLoja = _carrinho;
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var ordems = await GetOrderByUser(userId);
            return View(ordems);

        }
        
        public IActionResult Ordems()
        {
            var items = carrinhoLoja.getItems();
            carrinhoLoja.carrinhoDeComprasItems = items;

            var cart = new CarrinhoComprasVM()
            {
                Carrinho = carrinhoLoja,
                CarrinhoTotal = carrinhoLoja.getTotal()

            };

            return View(cart);
        }

        public async Task<RedirectToActionResult> AdicionarAoCarrinho(int id)
        {
            var item = await db.Tfilmes.FindAsync(id);

            if (item != null)
            {
                carrinhoLoja.AddItem(item);
            }


            return RedirectToAction(nameof(Ordems));
        }

        public async Task<RedirectToActionResult> RemoverDoCarrinho(int id)
        {
            var item = await db.Tfilmes.FindAsync(id);

            if (item != null)
            {
                carrinhoLoja.RemoverItem(item);
            }


            return RedirectToAction(nameof(Ordems));
        }



        public async Task<List<Ordem>> GetOrderByUser(string userId)
        {
            var ordems = await db.Tordens.Include(n => n.OrdemItems).ThenInclude(n => n.Filme).Where(n => n.UserId == userId).ToListAsync();
            return ordems;


        }

        public async Task GuardarOrdem(List<CarrinhoDeComprasItem> items, string userId, string userEnderecoEmail)
        {
            var ordem = new Ordem()
            {
                UserId = userId,
                Email = userEnderecoEmail

            };

            await db.Tordens.AddAsync(ordem);
            await db.SaveChangesAsync();

            foreach (var item in items)
            {
                var itemOrdem = new OrdemItem()
                {
                    Quantidade = item.Quantidade,
                    FilmeId = item.Filme.Id,
                    OrdemId = ordem.Id,
                    Preco = item.Filme.Preco

                };
                await db.Tordem_items.AddAsync(itemOrdem);
            }
             await db.SaveChangesAsync();   
        }

        public IActionResult CompletarOrdem()
        {
            var items = carrinhoLoja.getItems();
            string userId = "";
            string userEnderecoEmail = "";
            GuardarOrdem(items, userId, userEnderecoEmail);
            carrinhoLoja.EsvaziarCarrinho();
            return View("FinalizarOrdem");
        }

        public async Task<IActionResult> EstadoDoCarrinho()
        {
            var items = db.Tcarrinho_items.Where(n => n.CarrinhoDeComprasId == carrinhoLoja.CarrinhoId).Include(n => n.Filme).ToList();
            ViewBag.Items = items;
            return View("_Layout");

        }

    }

   
}