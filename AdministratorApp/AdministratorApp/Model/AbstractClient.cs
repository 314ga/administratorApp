using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
    public class AbstractClient
    {
        public String clientId { get; set; }
        public Address address { get; set; }
        public string companyName { get; set; }
        public string email { get; set; }
        public string telephoneNumber { get; set; }
        public string clientType { get; set; }
        public string passwordHash { get; set; }
    }
}
