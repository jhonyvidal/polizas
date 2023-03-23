using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.DTO.Response
{
    public class GeneralReponse<T>
    {
        public int code { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
