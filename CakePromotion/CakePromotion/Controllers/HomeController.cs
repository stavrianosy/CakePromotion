using CakePromo.BusinessLogic;
using CakePromotion.CakePromoService;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CakePromotion.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default/

        //public ActionResult Index()
        //{
        //    var t = new test();
            
        //    return View();
        //}

        public ActionResult Index(object model)
        {
            using (CakePromoService.MainClient s = new CakePromoService.MainClient())
            {
                //The return type is a List of ICollections and it needs the KnownType attribute on the Interface
                //var t2 = s.GetAllCakesEager();

                //Eager loading on single type in the List work fine without KnownType attribute on the Interface
                var t3 = s.GetCakeByID(1);

                var t4 = s.GetIngredientsByCakeID(3);
                
                ViewBag.Test = t3.Name;

                return View();
            }
            
        }

    }
}
