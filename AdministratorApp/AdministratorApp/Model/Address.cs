using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
    /// <summary>
    /// Model class for the address
    /// The class contains getters and setters for all variables which are neccessery for the address.
    /// </summary>
    /// <remarks>
    /// Can set all variables in the class
    /// Can get data from all variables in the class
    /// </remarks>
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string country { get; set; }

        public override string ToString()
        {
            return street + ", " + zipCode + " " + city + " " + country;
    }
    }

   
}
