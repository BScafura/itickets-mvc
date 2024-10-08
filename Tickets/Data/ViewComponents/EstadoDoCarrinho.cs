using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data.Cart;
namespace Tickets.Data.ViewComponents
{
    public class EstadoDoCarrinho: ViewComponent
    {
        private readonly Carrinho carrinhoLoja;

        private readonly ApplicationDbContext db;

        public EstadoDoCarrinho(Carrinho _carrinho, ApplicationDbContext context)
        {
            carrinhoLoja = _carrinho;
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            var items = db.Tcarrinho_items.Where(n => n.CarrinhoDeComprasId == carrinhoLoja.CarrinhoId).Include(n => n.Filme).ToList();
            ViewBag.Items = items;
            return View();

        }





    }

}
