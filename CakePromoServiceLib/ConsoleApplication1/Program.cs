using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CakePromo.DataAccess;
using CakePromo.BusinessLogic;
using System.Data.Entity;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDBWithSeedData());
            //Database.SetInitializer<EntityContext>(null);
            using (EntityContext context = new EntityContext())
            {

                //context.Cake.Add(new Cake() { CakeID = 1, TimeStamp = DateTime.Now, UserID = 1 });
                //context.Cake.Add(new Cake() { CakeID = 2, TimeStamp = DateTime.Now, UserID = 12 });
                //context.Cake.Add(new Ingredient() {   });
                //context.SaveChanges();
                var i = context.Cake.ToList();
            }

            //var a = GetAllCakesEager();
            //var t = GetAllCakesByCakeID(1);
            var a = GetIngredientsByCakeID(4);
        }

        public static Cake GetCakeByID(int cakeID)
        {
            Cake cake;

            try
            {

                using (EntityContext context = new EntityContext())
                {
                    var query = from c in context.Cake
                                    .Include(c => c.CakePhoto)
                                    .Include(c => c.Rate)
                                    .Include(c => c.Ingredient)
                                    .Include(c => c.Ingredient.Select(i => i.Unit))
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

        public static List<Ingredient> GetIngredientsByCakeID(int cakeID)
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

        public static Cake GetAllCakesByCakeID(int cakeID)
        {
            List<ICollection> list = new List<ICollection>();
            Cake cake;
            try
            {

                using (EntityContext context = new EntityContext())
                {
                    var query1 = from c in context.Cake.Include(c => c.CakePhoto) select c;
                    
                    var query = from c in context.Cake
                                //where c.CakeID == cakeID
                                select new 
                                {
                                    cake = c
                                    , 
                                    CakePhoto = c.CakePhoto
                                };

                    list.Add(query.Select(a => a.cake).ToList());
                    list.Add(query.Select(b => b.CakePhoto).ToList());

                    cake = query1.FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return cake;
        }

        public static List<ICollection> GetAllCakesEager()
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

        public static List<Cake> GetAllCakes()
        {
            try
            {

            
            using (EntityContext context = new EntityContext())
            {
                return (from i in context.Cake
                        select i).ToList();
                //context.SaveChanges();
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
