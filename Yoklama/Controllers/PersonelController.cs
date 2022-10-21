using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class PersonelController : Controller
    {
    
        IdariPersonelManager ip = new IdariPersonelManager(new EfIdariPersonelRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllList()
        {

            var values = ip.GetList();
            return View(values);
        }
    }
}
