using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUILayer.Controllers
{
    public class OgretmenController : Controller
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

        [HttpGet]
        public IActionResult OgretmenAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgretmenAdd(TBL_IDARI_PERSONEL datas)
        {

            ip.Add(datas);
            return RedirectToAction("AllList","Ogretmen");
        }

        
        public IActionResult PersonelDelete(int  id)
        {
            var ogretmen = ip.GetById(id);
            ip.Remove(ogretmen);
            return RedirectToAction("AllList","Ogretmen");
        }

        public IActionResult PersonelDetail(int id)
        {
            var values = ip.GetWithPersonelId(id);
            return View(values);
        }

    }
}
