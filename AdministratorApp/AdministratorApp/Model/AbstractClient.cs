using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
   public abstract class AbstractClient
    {
        public String clientId { get; set; }
        public Address address { get; set; }
        public String companyName { get; set; }
        public String email { get; set; }
        public String telephoneNumber { get; set; }
        public String clientType { get; set; }
        public String passwordHash { get; set; }
    }
}
