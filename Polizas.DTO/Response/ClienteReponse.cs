using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DTO.Response
{
    public class ClienteReponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public Nullable<System.DateTime> FechaDeNacimiento { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
    }
}
