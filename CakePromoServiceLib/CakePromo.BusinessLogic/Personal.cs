using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CakePromo.BusinessLogic
{
    public class Personal
    {
        #region Public Properties

        public int PersonalID { get; set; }

        public int Birthdate{get;set;}

        [StringLength(100)]
        public int Name{get;set;}

        public int Surname{get;set;}

        public int TimeStamp { get; set; }
        #endregion
    }
}
