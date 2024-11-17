using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reporte
    {
        private string UsuarioID { get; set; }
        public string NombreCompleto { get; set; }
        public string Ficha { get; set; }


        private string EquipoID { get; set; }
        public string TipoEquipo { get; set; }
        public string NumeroSerie { get; set; }
        public string Estado { get; set; }



    }
}
