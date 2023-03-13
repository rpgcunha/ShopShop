using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopShop.Data;

namespace ShopShop.Controllers
{
    public class NovaCompraController : Controller
    {
        private readonly ApplicationDbContext dbpointer;

        public NovaCompraController(ApplicationDbContext context)
        {
            dbpointer = context;
        }
        public IActionResult Index(string categoria)
        {
            ViewBag.CATEGORIAS = new SelectList(dbpointer.Categorias, "Id", "Nome");
            return View();
        }
    }
}
