using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DTO.Response
{
    public class PolizaResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> ValorCubierto { get; set; }
        public Nullable<DateTime> fechaInicio { get; set; }
        public Nullable<DateTime> fechaFin { get; set; }
        public  ClienteReponse Cliente { get; set; }
        public AutomotorResponse Automotor { get; set; }
    }
}
