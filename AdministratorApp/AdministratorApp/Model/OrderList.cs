using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp
{

    /// <summary>
    /// Model class for the list of the orders
    /// The class contains getter and setter for List of the orders
    /// </summary>
    /// <remarks>
    /// Can set List variable
    /// Can get data from List variable
    /// </remarks>
    public class OrderList
    {
        public List<Order> orders { get; set; }
        
    }
}
