using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCostingPlatform.Auth
{
    public class UserCompany
    {
        public Address ContactAddress { get; set; } = new Address();
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string  WebsiteUrl { get; set; }


    }
}
