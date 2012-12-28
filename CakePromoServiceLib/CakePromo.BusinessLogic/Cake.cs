using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CakePromo.BusinessLogic
{
    public class Cake
    {
        #region Public Properties
        public int CakeID { get; set; }

        public List<Ingredient> Ingredient { get; set; }

        public DateTime TimeStamp { get; set; }
        
        public string Recipie { get; set; }
        
        public List<Rate> Rate { get; set; }

        [Required]
        [Display]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and max {1} characters long.", MinimumLength = 1)]
        public string Name { get; set; }

        public User User { get; set; }

        public List<CakePhoto> CakePhoto { get; set; }
     
        #endregion

        #region Public Methods
        public void Merge(Cake content)
        {
            this.CakeID = content.CakeID;
        }
        #endregion

    }
}
