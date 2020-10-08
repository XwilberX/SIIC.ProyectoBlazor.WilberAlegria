using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases;
using SIIC.ProyectoBlazor.WilberAlegria.BL;

namespace SIIC.ProyectoBlazor.WilberAlegria.Pages
{
    public partial class Empleados
    {
        protected override async Task OnInitializedAsync()
        {
            await ObtenerEmpleados();
        }
        [Parameter]
        public List<ApiClient.Clases.Empleados> ListEmpleados { get; set; } = new List<ApiClient.Clases.Empleados>();
        
        [Parameter]
        public ApiClient.Clases.Empleados Empleado { get; set; } = new ApiClient.Clases.Empleados();

        [Inject]
        private EmpleadosBL EmpleadosBL { get; set; }

        public async Task ObtenerEmpleados()
        {
            ListEmpleados = await EmpleadosBL.GetEmpleadosAsync();
        }
        private void NewEmpleado()
        {
            Empleado = new ApiClient.Clases.Empleados();
        }

        private async Task GuardarEmpleado()
        {
            bool resultado = await EmpleadosBL.AgregarEmpleadoAsync(Empleado);
            await ObtenerEmpleados();
        }
        private async Task EliminarEmpleado(ApiClient.Clases.Empleados empl)
        {
            bool resultado = await EmpleadosBL.BorrarEmpleadoAsync(empl.id);
            await ObtenerEmpleados();
        }
    }
}