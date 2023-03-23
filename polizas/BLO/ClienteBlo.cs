using polizas.Interfaces;
using Polizas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.BLO
{
    public class ClienteBlo : BaseController, IClienteBLO
    {
        public async Task<IEnumerable<ClienteReponse>> GetClientes(int id = 0)
        {
            var result = Connection.Context.Cliente.ToList();
            var hoy = DateTime.Now;

            return result.Select(c => new ClienteReponse
            {
                Id = c.Id,
            });

        }

    }
}
