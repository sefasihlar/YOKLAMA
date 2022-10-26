using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        //[HttpPost]
        //public IActionResult OgretmenAdd(TBL_IDARI_PERSONEL datas)
        //{

        //    ip.Add(datas);
        //    return RedirectToAction("AllList","Ogretmen");
        //}

        
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

        public IActionResult AjaxList()
        {
            var personel = ip.GetList();
            var jsonPersonel = JsonConvert.SerializeObject(personel);
            return Json(jsonPersonel);
        }

        public IActionResult AJaxGetId(int id)
        {
            var personel = ip.GetList().Where(x => x.IDARI_PERSONEL_ID == id).FirstOrDefault();
            var jsonPersonel = JsonConvert.SerializeObject(personel);

            return Json(jsonPersonel);
        }

        [HttpGet]
        public IActionResult AjaxPersonelAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AjaxPersonelAdd(TBL_IDARI_PERSONEL add)
        {
            ip.Add(add);
            var jsonpersonel = JsonConvert.SerializeObject(add);
            return Json(jsonpersonel);
        }

        [HttpGet]
        public IActionResult AjaxPersonelDelete()
        {
            return RedirectToAction("AllList", "Ogretmen");

        }

        [HttpPost]
        public IActionResult AjaxPersonelDelete(int id)
        {
            var ogretmen = ip.GetById(id);
            ip.Remove(ogretmen);
            return Json(ogretmen);

        }
        [HttpPost]
        public IActionResult AjaxPersonelUpdate(TBL_IDARI_PERSONEL update)
        {
            var personel = ip.GetById(update.IDARI_PERSONEL_ID);
            personel.ADI = update.ADI;
            personel.SOYADI = update.SOYADI;
            personel.UNVAN = update.UNVAN;
            personel.TELEFON = update.TELEFON;
            personel.MAIL = update.MAIL;
            personel.SIFRE = update.SIFRE;
            personel.OZEL_KOD = update.OZEL_KOD;
            personel.DURUM = update.DURUM;
            ip.Update(personel);
            var JsonPersonel = JsonConvert.SerializeObject(update);
            return Json(JsonPersonel);

        }

    }
}
