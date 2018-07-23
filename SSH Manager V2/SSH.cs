using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH_Manager_V2
{
   public class SSH
    {

        public string Ip { set; get; }
        public string User { set; get;}

        public string Pass { set; get; }

        public string Country { get; set; }

        public string CountryName { get; set; }
        public string Serialize()
        {
            return String.Format("{0}|{1}|{2}", Ip, User, Pass);
        }
        public string SeriaIP()
        {
            return String.Format("{0}", Ip);
        }
    }
}
