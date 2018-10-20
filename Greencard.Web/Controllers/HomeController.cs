using System.Web.Mvc;
using System.Linq;
using System;

namespace Greencard.Web.Controllers
{
    public class HomeController : Controller
    {
        Models.u7666632_SahibidenCloneEntities db = new Models.u7666632_SahibidenCloneEntities();

        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/hakkimizda")]
        public ActionResult About()
        {
            return View();
        }

        [Route("~/greencard-hakkinda")]
        public ActionResult AboutGreencard()
        {
            return View();
        }

        [Route("~/basvuru-formu")]
        public ActionResult ApplicationForm()
        {
            ViewBag.Country = db.GreenCountries.ToList();
            ViewBag.Education = db.GreenEducations.ToList();
            ViewBag.MaritalStatu = db.GreenMaritalStatus.ToList();
            return View();
        }

        [Route("~/basvuru-formu")]
        [HttpPost]
        public ActionResult ApplicationForm(Models.GreenUserDetail model)
        {
            if (model != null)
            {
                model.CreatedDate = DateTime.Now;
                db.GreenUserDetails.Add(model);
                db.SaveChanges();
            }
            return View();
        }

        [Route("~/paketler")]
        public ActionResult Pricing()
        {
            return View();
        }

        [Route("~/iletisim")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("~/basvuru-sartlari")]
        public ActionResult ApplicationTerms()
        {
            return View();
        }

        [Route("~/odeme")]
        public ActionResult Payment()
        {
            return View();
        }
    }
}