using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DTO.Response
{
    public class PolizaRequest
    {
        public string Nombre { get; set; }
        public decimal ValorCubierto { get; set; }
        public int id_cliente { get; set; }
        public int id_automotor { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
    }
}
