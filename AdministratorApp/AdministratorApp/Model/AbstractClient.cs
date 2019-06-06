using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
    /// <summary>
    /// Model class for the clients
    /// The class contains getters and setters for all variables which are neccessery for the client.
    /// </summary>
    /// <remarks>
    /// Can set all variables in the class
    /// Can get data from all variables in the class
    /// </remarks>
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
