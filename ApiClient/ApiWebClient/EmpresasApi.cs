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
    //  Clase con herencia de HttpClient
    public class EmpresasApi : HttpClient
    {
        public EmpresasApi(string urlServer)
        {
            urlServer += (urlServer.EndsWith('/')) ? "api/Empresas/" : "/api/Empresas/";
            BaseAddress = new Uri(urlServer);
        }

        public async Task<List<Empresas>>GetEmpresasAsync()
        {
            try
            {
                var res =  await this.GetFromJsonAsync<List<Empresas>>("ObtenerEmpresas");
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Empresas>();
                throw;
            }
        }

        public async Task<bool> AgregarEmpresaAsync(Empresas empresas)
        {
            try
            {
                var response = await this.PostAsJsonAsync("GuardarEmpresa", empresas);
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

        public async Task<bool> EliminarEmpresaAsync(Guid id)
        {
            try
            {
                var response = await this.PostAsJsonAsync("EliminarEmpresa", id);
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

        public async Task<bool> ActualizarEmpresasAsync(Empresas empresas)
        {
            try
            {
                var response = await this.PostAsJsonAsync("ActualizarEmpresa", empresas);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("llego");
                    return true;
                }
                    
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