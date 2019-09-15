using cascading2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cascading2.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Index1()
        {


            List<country> CountryList = db.countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "countryid", "countryname");
            return View();
        }

        public JsonResult GetStateList(int countryid)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<state> StateList = db.states.Where(X => X.Refcountryid == countryid).ToList();
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCityList(int stateid)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<city> CityList = db.cities.Where(X => X.Refstateid == stateid).ToList();
            return Json(CityList, JsonRequestBehavior.AllowGet);
        }

    }
}