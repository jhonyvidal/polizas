using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DAL
{
    public class BaseContext
    {
        private polizasEntities context;

        public polizasEntities Context
        {
            get
            {
                if (context == null)
                {
                    context = new polizasEntities();
                }
                return context;
            }
        }
    }
}
