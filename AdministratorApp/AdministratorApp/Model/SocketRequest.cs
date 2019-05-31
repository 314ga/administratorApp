using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
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
            GET_UNASSIGNED_ORDERS,
            GET_ORDER_BY_ID,
            UPDATE_ORDER,
            DELETE_ORDER,
            GET_CUSTOMERS,
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
