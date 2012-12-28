using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections;

using CakePromo.DataAccess;
using CakePromo.BusinessLogic;

namespace CakePromoServiceLib
{
    [Serializable] 
    public class Main:IMain
    {
        
        public List<Cake> GetAllCakes()
        {
            try
            {
                using (EntityContext context = new EntityContext())
                {
                    var query = (from c in context.Cake
                                     .Include(c=>c.CakePhoto)
                                     .Include(c=>c.Rate)
                                 select c).ToList();

                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Cake GetCakeByID(int cakeID)
        {
            Cake cake;

            try
            {

                using (EntityContext context = new EntityContext())
                {
                    var query = from c in context.Cake
                                    .Include(c => c.CakePhoto)
                                    .Include(c => c.Rate)
                                    //.Include(c => c.Ingredient)
                                //.Include(c=>c.Ingredient.Select(i=>i.Unit))
                                where c.CakeID == cakeID
                                select c;

                    cake = query.FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return cake;
        }

        public List<Ingredient> GetIngredientsByCakeID(int cakeID)
        {
            List<Ingredient> ingredientList;

            try
            {
                using (EntityContext context = new EntityContext())
                {
                    var query = from i in context.Ingredient
                                    .Include(i => i.Unit)
                                where i.Cake.Contains(context.Cake.Where(c => c.CakeID == cakeID).FirstOrDefault())
                                select i;

                    ingredientList = query.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ingredientList;
        }

        public List<ICollection> GetAllCakesEager()
        {
            try
            {
                List<ICollection> list = new List<ICollection>();

                using (EntityContext context = new EntityContext())
                {
                    var cakeList = (from i in context.Cake
                                    select i).ToList();
                    list.Add(cakeList);

                    var rateList = (from i in context.Rate
                                    select i).ToList();
                    list.Add(rateList);

                    var cakePhotoList = (from i in context.CakePhoto
                                         select i).ToList();
                    list.Add(cakePhotoList);

                    return list;
                    //context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
