using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CakePromo.BusinessLogic
{
    public class Rate
    {
        #region Public Properties

        public int RateID{get;set;}

        public int Design { get; set; }

        public int Facilitate { get; set; }

        public int Taste { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        public DateTime TimeStamp { get; set; }

        public User User { get; set; }

#endregion

    }
}
