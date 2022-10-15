using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllList()
        {
            IdariPersonelManager ip = new IdariPersonelManager(new EfIdariPersonelRepository());
            var values = ip.GetList();
            return View(values);
        }


    }
}
