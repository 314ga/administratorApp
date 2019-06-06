using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
    /// <summary>
    /// Model class for the list of the clients
    /// The class contains getter and setter for List of the clients
    /// </summary>
    /// <remarks>
    /// Can set List variable
    /// Can get data from List variable
    /// </remarks>
    public class ClientList
    {
        public List<AbstractClient> clients { get; set; }
    }
}
