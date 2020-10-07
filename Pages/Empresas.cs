using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases;
using SIIC.ProyectoBlazor.WilberAlegria.BL;

namespace SIIC.ProyectoBlazor.WilberAlegria.Pages
{
    public partial class Empresas
    {
        protected override async Task OnInitializedAsync()
        {
            await ObtenerEmpresas();
        }
        public string hola = "hola";
        [Parameter]
        public List<ApiClient.Clases.Empresas> ListEmpresas { get; set; } = new List<ApiClient.Clases.Empresas>();
        
        [Parameter]
        public ApiClient.Clases.Empresas Empresa { get; set; } = new ApiClient.Clases.Empresas();

        [Inject]
        private EmpresasBL EmpresasBL { get; set; }

        public async Task ObtenerEmpresas()
        {
            ListEmpresas = await EmpresasBL.GetEmpresasAsync();
        }

        private void NewEmpresa()
        {
            Empresa = new ApiClient.Clases.Empresas();
        }
        private async Task GuardarEmpresa()
        {
            bool resultado = await EmpresasBL.AgregarEmpresaAsync(Empresa);
            await ObtenerEmpresas();
        }

        private async Task EliminarEmpresa(ApiClient.Clases.Empresas emp)
        {
            bool resultado = await EmpresasBL.BorrarEmpresaAsync(emp.id);
            await ObtenerEmpresas();
        }
    }
}