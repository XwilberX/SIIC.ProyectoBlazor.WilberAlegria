using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases
{
    public class Empresas
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string idSucursal { get; set; }
        public string rfc { get; set; }
        public string razonSocial { get; set; }
        public string nombreComercial { get; set; }
        public string direccion { get; set; } 
        public string telefono { get; set; }
        public string correo { get; set; }
    }
} 