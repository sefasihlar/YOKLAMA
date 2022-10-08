using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllList()
        {
            OgreniManager ip = new OgreniManager(new EfOgrenciRepository());
            var values = ip.GetberaberList();
            return View(values);
        }
    }
}
