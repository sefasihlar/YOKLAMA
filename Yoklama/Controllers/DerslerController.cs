using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllList()
        {
            DerslerManager _derslerManager = new DerslerManager(new EfDerslerRepsitory());
            var values = _derslerManager.GetList();
            return View(values);
        }
    }
}
