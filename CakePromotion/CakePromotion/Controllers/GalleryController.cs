using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CakePromotion.CakePromoService;

namespace CakePromotion.Controllers
{
    public class GalleryController : Controller
    {
        //
        // GET: /Gallery/

        public ActionResult Index()
        {
            List<Cake> cakeList;
            using (MainClient service = new MainClient())
            {
                cakeList = service.GetAllCakes();
            }
            return View(cakeList);
        }

       // [HttpPost]
        public ActionResult CakeCart(int cakeID)
        {
            Cake cake;
            List<Ingredient> ingredientList;
            using(MainClient service = new MainClient())
            {
                cake = service.GetCakeByID(cakeID);
                ingredientList = service.GetIngredientsByCakeID(cakeID);

                cake.Ingredient = ingredientList;
            }
            return View(cake);
        }
    }
}
