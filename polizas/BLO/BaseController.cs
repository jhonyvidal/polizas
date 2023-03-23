using Polizas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.BLO
{
    public class BaseController
    {
        private BaseContext conn;
        protected BaseContext Connection
        {
            get
            {
                if (conn == null)
                {
                    conn = new BaseContext();
                }
                return conn;
            }
        }
    }
}
