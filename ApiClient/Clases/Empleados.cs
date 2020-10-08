using System.Collections;
using System;
using System.Linq;

namespace SIIC.ProyectoBlazor.WilberAlegria.ApiClient.Clases
{
    public class Empleados
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public Object activo { get; set; } = true;
    }
}