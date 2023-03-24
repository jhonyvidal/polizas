using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.Interfaces
{
    public  interface IValidadorBLO
    {
        string RealizarValidacion(DateTime fechaInicial, DateTime fechaFinal);
    }
}
