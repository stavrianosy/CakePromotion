using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CakePromo.BusinessLogic
{
    public class Unit
    {
        public User User
        {
            get;
            set;
        }

        public DateTime TimeStamp { get; set; }

        public string Name
        {
            get;
            set;
        }

        public int UnitID
        {
            get;
            set;
        }

        public string ShortName
        {
            get;
            set;
        }
    }
}
