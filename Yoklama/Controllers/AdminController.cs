using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OkulDurumlari()
        {
            SchoolDurumlariManager sm = new SchoolDurumlariManager(new EfSchoolDurumlarıRepository());
            var values = sm.GetList();
            return View(values);
        }
    }
}
