using polizas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.BLO
{

    //Clase contexto que utiliza los algoritmos
    public class Contexto
    {
        private IValidadorBLO _algoritmo;

        public Contexto(IValidadorBLO algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string EjecutarAlgoritmo(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _algoritmo.RealizarValidacion(fechaInicial, fechaFinal);
        }
    }
    public class ValidacionFechaBlo: IValidadorBLO
    {
        public string RealizarValidacion(DateTime fechaInicial, DateTime fechaFinal)
        {
            if(fechaInicial > fechaFinal)
            {
                return "Error: debe ingresar una fecha final superior a la fecha inicial";
            }
            return "Ok";
        }

    }
    public class ValidacionFechaHoyBlo : IValidadorBLO
    {
        public string RealizarValidacion(DateTime fechaInicial, DateTime fechaFinal)
        {
            var hoy = DateTime.Now;
            if (fechaInicial < hoy)
            {
                return "Error: debe ingresar una fecha superior a la fecha actual";
            }
            return "Ok";
        }

    }

    public class ValidacionMesesFechaBlo : IValidadorBLO
    {
        public string RealizarValidacion(DateTime fechaInicial, DateTime fechaFinal)
        {
            var hoy = DateTime.Now;
            TimeSpan diferencia = fechaFinal - fechaInicial;
            if (diferencia < TimeSpan.FromDays(180))
            {
                return "Error: la vigencia de la poliza no debe ser inferior a seis meses";
            }
            return "Ok";
        }

    }
}
