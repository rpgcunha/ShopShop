using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopShop.Data;
using ShopShop.Migrations;
using ShopShop.Models;

namespace ShopShop.Controllers
{
    public class NovaCompraController : Controller
    {
        private readonly ApplicationDbContext dbpointer;

        public NovaCompraController(ApplicationDbContext context)
        {
            dbpointer = context;
        }
        public IActionResult Index(string categoria, string preco, string quantidade)
        {
            ViewBag.CATEGORIAS = new SelectList(dbpointer.Categorias, "Id", "Nome");

            List<CategoriaProdutos> listaProdutos = new List<CategoriaProdutos>();

            

            if (categoria != null)
            {
                foreach (var item in dbpointer.Produtos)
                {
                    CategoriaProdutos produtoFiltrado = new CategoriaProdutos();
                    if (Convert.ToInt32(categoria) == item.CategoriaId)
                    {
                        produtoFiltrado.Id = item.Id;
                        produtoFiltrado.Nome = item.Nome;
                        produtoFiltrado.PrecoCont = item.PrecoCont;
                        produtoFiltrado.PrecoPD = item.PrecoPD;
                        produtoFiltrado.PrecoMerc = item.PrecoMerc;
                        listaProdutos.Add(produtoFiltrado);
                    }                
                }
                if (preco != null && quantidade != null)
                {
                    string[] precoParts = preco.Split('|');
                    string id = precoParts[0];
                    string local = precoParts[1];
                    //foreach (var item in dbpointer.Produtos)
                    //{
                    //    if (id == item.Id.ToString())
                    //    {
                    //        switch (local)
                    //        {
                    //            case "continente":
                    //                break;
                    //            case "pingoDoce":
                    //                break;
                    //            case "mercadona":
                    //                break;
                    //        }
                    //    }
                    //}
                    ViewBag.ID = id;
                    ViewBag.LOCAL = local;
                    ViewBag.QUANTIDADE = quantidade;
                }
                else
                {
                    ViewBag.NOME = "";
                    ViewBag.LOCAL = "";
                    ViewBag.QUANTIDADE = "";
                }
                return View(listaProdutos.ToList());
            }           

            return View(listaProdutos.ToList());
        }
    }
}
