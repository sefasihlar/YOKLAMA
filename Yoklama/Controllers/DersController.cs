using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class DersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllList()
        {
            DersManager ip = new DersManager(new EfDersRepository());
            var values = ip.DersList();
            return View(values);

        }
    }
}
