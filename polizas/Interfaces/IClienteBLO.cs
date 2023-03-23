using Polizas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.Interfaces
{
    public interface IClienteBLO
    {
        Task<IEnumerable<ClienteReponse>> GetClientes(int id);
    }
}
