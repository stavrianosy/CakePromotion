using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakePromo.BusinessLogic
{
    public class Ingredient
    {
        #region Public Properties
        public int IngredientID { get; set; }

        public List<Cake> Cake { get; set; }

        public DateTime TimeStamp { get; set; }

        public User User {get;set;}

        public string Name { get; set; }

        public double Quantity { get; set; }

        public Unit Unit { get; set; }
#endregion        
    }
}
