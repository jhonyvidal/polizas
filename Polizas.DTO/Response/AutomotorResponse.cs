using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DTO.Response
{
    public class AutomotorResponse
    {
        public int Id { get; set; }
        public Nullable<int> Id_cliente { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public Nullable<bool> TieneInspeccion { get; set; }
    }
}
