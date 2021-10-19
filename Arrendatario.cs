using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAI
{
    class Arrendatario
    {
        public String idArrendatario { get; }
        public String nombre { get; }
        public Int64 telefono { get; set; }
        public String correo { get; set; }
        public char genero { get; set; }
        public int calificaciones { get; set; }
    }
}
