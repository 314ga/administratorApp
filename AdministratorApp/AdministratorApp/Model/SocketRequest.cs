using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
    /// <summary>
    /// The class is responsible for creating request which is later send to the java
    /// The class contains enum ACTION for all possible actions and object which will be later send to java
    /// </summary>
    /// <remarks>
    /// Can set ACTION
    /// Can get ACTION
    /// Can set object variable
    /// Can get object variable
    /// </remarks>
    [Serializable]
    public class SocketRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ACTION action;
        public object obj;

        public enum ACTION
        {
            GET_ORDERS,

            GET_ASSIGNED_ORDERS,
            GET_ORDERS_GROUPBY_DEADLINE,
            GET_ORDERS_GROUPBY_STATUS,
            GET_UNASSIGNED_ORDERS,
            GET_ORDER_BY_ID,
            UPDATE_ORDER,
            DELETE_ORDER,
            GET_CUSTOMERS,
            GET_CLIENTS,
            GET_CONTRACTORS,
            GET_CLIENT_BY_ID,
            UPDATE_CLIENT,
            DELETE_CLIENT,
            ADD_CLIENT
        }

        public ACTION getAction()
        {
            return action;
        }

        public void setAction(ACTION action)
        {
            this.action = action;
        }

        public Object getObject()
        {
            return obj;
        }

        public void setObject(Object obj)
        {
            this.obj = obj;
        }
    }
}
