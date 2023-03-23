using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DTO.Response
{
    public class UsuarioRequest
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        public string password { get; set; }
    }
}
