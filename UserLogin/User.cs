using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public DateTime created { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fac_no { get; set; }
        public int role { get; set; }
        public DateTime validUntil { get; set; }


    }
}
