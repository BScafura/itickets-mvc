using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.Data.Cart
{
    public class Carrinho
    {
        public ApplicationDbContext db { get; set; }

        public string CarrinhoId { get; set; }

        public List<CarrinhoDeComprasItem> carrinhoDeComprasItems { get; set; }


        public Carrinho(ApplicationDbContext context) { 
            db = context;
        }

        public static Carrinho GetCarrinho(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var db = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new Carrinho(db) { CarrinhoId = cartId };


        }

        public async Task EsvaziarCarrinho()
        {
            var items = await db.Tcarrinho_items.Where(n => n.CarrinhoDeComprasId == CarrinhoId).ToListAsync();
            db.Tcarrinho_items.RemoveRange(items);
            await db.SaveChangesAsync();

        }


        public List<CarrinhoDeComprasItem> getItems()
        {
            var carrinhoDeComprasItems = db.Tcarrinho_items.Where(n => n.CarrinhoDeComprasId == CarrinhoId).Include(n => n.Filme).ToList();
            return carrinhoDeComprasItems;

        }

        public double getTotal()
        {
            var total = db.Tcarrinho_items.Where(n => n.CarrinhoDeComprasId == CarrinhoId).Select(n =>
            n.Filme.Preco * n.Quantidade).Sum();
            return total;

        }

        public void AddItem(Filme filme)
        {
            var carrinhoItem = db.Tcarrinho_items.FirstOrDefault(n => n.Filme.Id == filme.Id && n.CarrinhoDeComprasId == CarrinhoId);
            
            if (carrinhoItem == null)
            {
                carrinhoItem = new CarrinhoDeComprasItem()
                {
                    CarrinhoDeComprasId = CarrinhoId,
                    Filme = filme,
                    Quantidade = 1

                };

                db.Tcarrinho_items.Add(carrinhoItem);
                
            }
            else
            {
                carrinhoItem.Quantidade++;
            }

            db.SaveChanges();

        }

        public void RemoverItem(Filme filme)
        {
            var carrinhoItem = db.Tcarrinho_items.FirstOrDefault(n => n.Filme.Id == filme.Id && n.CarrinhoDeComprasId == CarrinhoId);

            if (carrinhoItem != null)
            {

                if (carrinhoItem.Quantidade > 1)
                {
                    carrinhoItem.Quantidade--;
                }
                

            }
            else
            {
                db.Tcarrinho_items.Remove(carrinhoItem);
            }

            db.SaveChanges();

        }


    }
}
