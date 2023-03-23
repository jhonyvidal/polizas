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
    public class UsuariosController : ApiController
    {
        private readonly IPolizaBLO _IPolizaBLO;

        public UsuariosController()
        {
            _IPolizaBLO = new PolizaBlo();
        }

        // POST api/Usuarios
        [HttpPost]
        public IHttpActionResult Post([FromBody] UsuarioRequest Model)
        {
            if (!ModelState.IsValid)
                 return BadRequest(ModelState);

            if(Model.password != "123456")
                return BadRequest("Usuario o Contraseña Incorrecta");
            
            try
            {
                var token = TokenGenerator.GenerateTokenJwt(Model.UserName);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
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
