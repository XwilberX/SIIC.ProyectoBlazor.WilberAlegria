using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases;
using SIIC.ProyectoBlazor.WilberAlegria.BL;
using Microsoft.JSInterop;

namespace SIIC.ProyectoBlazor.WilberAlegria.Pages
{
    public partial class Empresas
    {
        protected override async Task OnInitializedAsync()
        {
            await ObtenerEmpresas();
        }
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
            bool confirmed = await JSRuntime.InvokeAsync<bool>("confirm", $"Estas seguro de eliminar '{emp.nombreComercial}'");
            if (confirmed)
            {
                bool resultado = await EmpresasBL.BorrarEmpresaAsync(emp.id);
                await ObtenerEmpresas();
            }
        }

        private void EditarEmpresa(ApiClient.Clases.Empresas emp)
        {
            Empresa = emp;
        }
        private async Task ActualizarEmpresa()
        {
            bool resultado = await EmpresasBL.ActualizarEmpresasAsync(Empresa);
            await ObtenerEmpresas();
        }
    }
}