using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;

namespace WebUILayer.Controllers
{
    public class DersController : Controller
    {
        DersManager ip = new DersManager(new EfDersRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllList()
        {
          
            var values = ip.DersList();
            return View(values);

        }

        public IActionResult DersDetail(int id)
        {
            var values = ip.GetWithDersId(id);
            return View(values);
        }

        public IActionResult AjaxList()
        {
            var ders = ip.DersList();
            var jsonDers = JsonConvert.SerializeObject(ders);
            return Json(jsonDers);
        }

        [HttpGet]
        public IActionResult AjaxPersonelAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AjaxPersonelAdd(TBL_DERS add)
        {
            ip.DersAdd(add);
            var jsonpersonel = JsonConvert.SerializeObject(add);
            return Json(jsonpersonel);
        }

        [HttpGet]
        public IActionResult AjaxDersDelete()
        {
            return RedirectToAction("AllList", "Ders");

        }

        [HttpPost]
        public IActionResult AjaxDersDelete(int id)
        {
            var ders = ip.GetById(id);
            ip.DersRemove(ders);
            return Json(ders);

        }
        [HttpPost]
        public IActionResult AjaxDersUpdate(TBL_DERS update)
        {
            var ders = ip.GetById(update.DERS_ID);
            ders.ADI = update.ADI;
            ders.DURUM = update.DURUM;
            ders.OZEL_KOD = update.OZEL_KOD;
            ip.DersUpdate(ders);
            var JsonDers = JsonConvert.SerializeObject(update);
            return Json(JsonDers);

        }
    }
}
