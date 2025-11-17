using System.Web.Mvc;
using CapgeminiTest.Models;
using CapgeminiTest.DAL;

namespace CapgeminiTest.Controllers
{
    public class HomeController : Controller {
        OccupationRepository repo = new OccupationRepository();
        public ActionResult Index() {
            ViewBag.Occupations = repo.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Member m) {
            var factor = m.Occupation=="Doctor"?1.5m:
                         m.Occupation=="Author"?2.25m:
                         m.Occupation=="Cleaner"||m.Occupation=="Florist"?11.50m:31.75m;
            m.MonthlyPremium = (m.DeathSumInsured * factor * m.AgeNextBirthday)/1000*12;
            ViewBag.Occupations = repo.GetAll();
            return View(m);
        }
    }
}