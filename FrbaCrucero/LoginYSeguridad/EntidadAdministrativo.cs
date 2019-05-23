using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.LoginYSeguridad
{
    public class EntidadAdministrativo
    {
        public String username { get; set; }
        public String password { get; set; }
        public int intentos_fallidos { get; set; }
        public String nombre_rol { get; set; }
        public char estado_admin { get; set; }

    }
}
