using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAI
{
    class Amenidad
    {
        public int idAmenidad { get; }
        public String tipo { get; }
        public String descripcion { get; set; }
        public String horarioInicio { get; set; }
        public String horarioFin { get; set; }
    }
}
