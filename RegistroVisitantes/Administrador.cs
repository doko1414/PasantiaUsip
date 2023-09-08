using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitantes
{
    internal class Administrador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Administrador(string nombre, string apellido, string celular, string nombreUsuario, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }
    }
}
