//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CakePromoDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cake
    {
        public Cake()
        {
            this.Ingredients = new HashSet<Ingredients>();
        }
    
        public int CakeId { get; set; }
        public string Comments { get; set; }
        public string TimeStamp { get; set; }
        public string UserId { get; set; }
    
        public virtual ICollection<Ingredients> Ingredients { get; set; }
    }
}
