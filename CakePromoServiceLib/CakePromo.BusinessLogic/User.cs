using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CakePromo.BusinessLogic
{
    public class User
    {
        #region Public Properties
        public int UserID
        {get;set;}

        public DateTime TimeStamp
        {get;set;}

        [StringLength(20)]
        public string Username
        {get;set; }

        public ICollection<Contact> Contact{get;set;}

        public Personal Personal{get;set;}
        #endregion
    }
}
