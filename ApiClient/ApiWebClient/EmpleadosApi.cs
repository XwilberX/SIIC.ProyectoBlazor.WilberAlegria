using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases;

namespace SIIC.ProyectoBlazor.WilberAlegria.ApiClient.ApiWebClient
{
    public class EmpleadosApi : HttpClient
    {
        public EmpleadosApi(string urlServer)
        {
            urlServer += (urlServer.EndsWith('/')) ? "api/empleados/" : "/api/empleados/";
            BaseAddress = new Uri(urlServer);
        }

        public async Task<List<Empleados>>GetEmpleadosAsync()
        {
            try
            {
                var res =  await this.GetFromJsonAsync<List<Empleados>>("ObtenerEmpleados");
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Empleados>();
                throw;
            }
        }

        public async Task<bool> AgregarEmpleadoAsync(Empleados empleados)
        {
            try
            {
                var response = await this.PostAsJsonAsync("GuardarEmpleado", empleados);

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
        
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

        public async Task<bool> EliminarEmpleadoAsync(Guid id)
        {
            try
            {
                var response = await this.PostAsJsonAsync("EliminarEmpleado", id);
                if (response.StatusCode == HttpStatusCode.OK)
                    return true; 
                    
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

        public async Task<bool> ActualizarEmpleadosAsync(Empleados empleados)
        {
            try
            {
                var response = await this.PostAsJsonAsync("ActualizarEmpleado", empleados);
                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                    
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }
    }
}