using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CakePromo.BusinessLogic
{
    public class Contact
    {
        public int ContactID { get; set; }

        public int Email
        {
            get;
            set;
        }

        public int Address
        {
            get;
            set;
        }

        public int TimeStamp
        {
            get;
            set;
        }
    }
}
