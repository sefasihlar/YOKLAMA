using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class OgrenciController : Controller
    {
        OgreniManager ip = new OgreniManager(new EfOgrenciRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllList()
        {
            
            var values = ip.GetberaberList();
            return View(values);
        }

        public IActionResult OgrenciDetail(int id)
        {
            var values = ip.GetWithOgrenciId(id);
            return View(values);
        }
    }
}
