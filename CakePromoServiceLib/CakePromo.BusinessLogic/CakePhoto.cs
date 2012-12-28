using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CakePromo.BusinessLogic
{
    public class CakePhoto
    {
        public User User
        {
            get;
            set;
        }

        public DateTime TimeStamp { get; set; }

        public int CakePhotoID
        {
            get;
            set;
        }

        public string PhotoURL_Large
        {
            get;
            set;
        }

        public string PhotoURL_Small
        {
            get;
            set;
        }
    }
}
