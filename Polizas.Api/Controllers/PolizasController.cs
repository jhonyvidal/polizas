using polizas.BLO;
using polizas.Interfaces;
using Polizas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace Polizas.Api.Controllers
{
    [Authorize]
    public class PolizasController : ApiController
    {
        private readonly IPolizaBLO _IPolizaBLO;

        public PolizasController()
        {
            _IPolizaBLO = new PolizaBlo();
        }
        // GET api/poliza/placa/abc
        [HttpGet]
        [Route("api/Polizas/Placa/{id}")]
        public GeneralReponse<PolizaResponse> GetPorPlaca(string id)
        {
            var response = new GeneralReponse<PolizaResponse>();
            try
            {
                var polizasResponse = _IPolizaBLO.GetPolizaPorPlaca(id);

                if (polizasResponse != null)
                {
                    response.code = 0;
                    response.message = "Success";
                    response.success = true;
                    response.data = polizasResponse;
                }
                else
                {
                    response.code = 1;
                    response.message = "No records found";
                    response.success = false;
                }
            }
            catch (Exception ex)
            {
                response.code = 1;
                response.message = ex.Message;
                response.success = false;
                return response;
            }
            return response;
        }

        // GET api/polizas/5
        [HttpGet]
        public GeneralReponse<PolizaResponse> Get(int id)
        {
            var response = new GeneralReponse<PolizaResponse>();
            try
            {
                var polizasResponse = _IPolizaBLO.GetPolizas(id);

                if (polizasResponse != null)
                {
                    response.code = 0;
                    response.message = "Success";
                    response.success = true;
                    response.data = polizasResponse;
                }
                else
                {
                    response.code = 1;
                    response.message = "No records found";
                    response.success = false;
                }
            }
            catch (Exception ex)
            {
                response.code = 1;
                response.message = ex.Message;
                response.success = false;
                return response;
            }
            return response;
        }

        // POST api/Polizas
        [HttpPost]
        public GeneralReponse<string> Post([FromBody] PolizaRequest Model)
        {
            var response = new GeneralReponse<string>();
            if (!ModelState.IsValid)
            {
                string totalError = "";
                var error = ModelState.Values.Select(c => c.Errors).ToList();

                for (var i = 0; i < error[0].Count; i++)
                {
                    totalError = totalError + " " + error[0][i].Exception.Message;
                }
                response.success = false;
                response.message = ("Error:" + totalError);
                return response;
            }
            try
            {
                var crear = _IPolizaBLO.Crear(Model);
                return crear;
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = ("Error:" + ex);
                return response;
            }

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
