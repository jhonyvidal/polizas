using polizas.Interfaces;
using polizas.Mapper;
using Polizas.DAL;
using Polizas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.BLO
{
    public class PolizaBlo : BaseController, IPolizaBLO
    {
        public PolizaResponse GetPolizas(int id = 0)
        {
            var result = Connection.Context.Poliza.FirstOrDefault(c => c.Id == id);
            var hoy = DateTime.Now;

            if (result != null && result.Automotor != null)
            {
                return PolizaMapper.MapPolizaResponse(result);
            }
            else
            {
                return null;
            }

        }

        public PolizaResponse GetPolizaPorPlaca(string id)
        {
            var result = Connection.Context.Poliza.FirstOrDefault(c => c.Automotor.Placa == id);
            var hoy = DateTime.Now;
            if(result != null)
            {
                return PolizaMapper.MapPolizaResponse(result);
            }
            else
            {
                return null;
            }
           

        }

        public GeneralReponse<string> Crear(PolizaRequest Model)
        {
            var response = new GeneralReponse<string>();
            var id = 0;
            var hoy = DateTime.Now;
            if (Model.fechaInicio < hoy)
            {
                response.success = false;
                response.message = "Error: debe ingresar una fecha superior a la fecha actual";
                return response;
            }
            try
            {
               
                var polizas = new Poliza()
                {
                    Nombre = Model.Nombre,
                    ValorCubierto = Model.ValorCubierto,
                    id_cliente = Model.id_cliente,
                    id_automotor = Model.id_automotor,
                    fechaInicio = Model.fechaInicio,
                    fechaFin = Model.fechaFin
                };


                var result = Connection.Context.Poliza.Add(polizas);
                Connection.Context.SaveChanges();
                id = result.Id;
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = "Error: " + ex;
                return response;
            }

            response.success = true;
            response.message = "Se creó el registro con exito";
            response.data = id.ToString();
            return response;
        }

    }
}
