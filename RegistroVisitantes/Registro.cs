using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitantes
{
    public class Registro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contacto { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
