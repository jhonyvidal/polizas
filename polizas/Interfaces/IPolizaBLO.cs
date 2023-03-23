using Polizas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.Interfaces
{
    public interface IPolizaBLO
    {
        PolizaResponse GetPolizas(int id);

        PolizaResponse GetPolizaPorPlaca(string id);

        GeneralReponse<string> Crear(PolizaRequest Model);
    }
}
