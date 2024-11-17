using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreCompleto { get; set; }
        public string Ficha { get; set; }
        public string Extensión { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }

        public string Contraseña { get; set; }
        public Equipo oEquipo {  get; set; }
        public string NumeroSerie { get; set; }



    }
}
