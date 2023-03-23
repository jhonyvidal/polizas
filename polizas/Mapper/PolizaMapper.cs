using Polizas.DAL;
using Polizas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polizas.Mapper
{
    public class PolizaMapper
    {
        public static PolizaResponse MapPolizaResponse(Poliza poliza)
        {
            var automotorResponse = new AutomotorResponse
            {
                Id = poliza.Cliente.Id,
                Modelo = poliza.Automotor.Modelo,
                Placa = poliza.Automotor.Placa,
                TieneInspeccion = poliza.Automotor.TieneInspeccion
            };
            var clienteResponse = new ClienteReponse
            {
                Id = poliza.Cliente.Id,
                Identificacion = poliza.Cliente.Identificacion,
                Ciudad = poliza.Cliente.Ciudad,
                Direccion = poliza.Cliente.Direccion,
                FechaDeNacimiento = poliza.Cliente.FechaDeNacimiento,
                Nombre = poliza.Cliente.Nombre
            };
            var PolizaResponse = new PolizaResponse
            {
                Id = poliza.Id,
                Nombre = poliza.Nombre,
                ValorCubierto = poliza.ValorCubierto,
                fechaInicio = poliza.fechaInicio,
                fechaFin = poliza.fechaFin,
                Cliente = clienteResponse,
                Automotor = automotorResponse
            };

            return PolizaResponse;
        }

    }
}
