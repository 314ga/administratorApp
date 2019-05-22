using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Model
{
    class SocketRequest
    {
        private ACTION action;
        private object obj;

    public SocketRequest(ACTION action, Object obj)
        {
            this.action = action;
            this.obj = obj;
        }

        public enum ACTION
        {
            GET_ORDERS,
            GET_ORDER_BY_ID,
            UPDATE_ORDER,
            DELETE_ORDER,
            ADD_ORDER,
            GET_CLIENTS,
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
