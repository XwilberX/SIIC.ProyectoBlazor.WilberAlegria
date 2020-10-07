using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.ApiWebClient;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases;

namespace SIIC.ProyectoBlazor.WilberAlegria.BL
{
    
    public class EmpleadosBL
    {
        EmpleadosApi empleadosApi;
        public EmpleadosBL(EmpleadosApi _empleadosApi)
        {
            this.empleadosApi = _empleadosApi;
        }

        public async Task<List<Empleados>>GetEmpleadosAsync()
        {
            var empleados = await empleadosApi.GetEmpleadosAsync();
            return empleados;
        }
        
    }
}