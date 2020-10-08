using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.ApiWebClient;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases;

namespace SIIC.ProyectoBlazor.WilberAlegria.BL
{
    public class EmpresasBL
    {
        EmpresasApi empresasApi;
        public EmpresasBL(EmpresasApi _empresasApi)
        {
            this.empresasApi = _empresasApi;
        }

        public async Task<List<Empresas>>GetEmpresasAsync()
        {
            var empresas = await empresasApi.GetEmpresasAsync();
            return empresas;
        }

        public async Task<bool> AgregarEmpresaAsync(Empresas empresas)
        {
            var guardo = await empresasApi.AgregarEmpresaAsync(empresas);
            return guardo;
        }

        public async Task<bool> BorrarEmpresaAsync(Guid id)
        {
            var guardo = await empresasApi.EliminarEmpresaAsync(id);
            return guardo;
        }

        public async Task<bool> ActualizarEmpresasAsync(Empresas empresas)
        {
            var guardo = await empresasApi.ActualizarEmpresasAsync(empresas);
            return guardo;
        }
    }
}