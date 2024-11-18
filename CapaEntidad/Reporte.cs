using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reporte
    {
        public int ReporteID { get; set; }
        public int UsuarioID { get; set; }
        public string NombreCompleto { get; set; }
        public int Ficha { get; set; }
        public int EquipoID { get; set; }
        public string TipoEquipo { get; set; }
        public int NumeroSerie { get; set; }
        public string Estado { get; set; }
    }
    public class ListaEU
    {
        public List<Equipo> EquiposL { get; set; }
        public List<Usuario> UsuariosL { get; set; }
        public ListaEU()
        {
            UsuariosL = new List<Usuario>();
            EquiposL = new List<Equipo>();
        }
    }
}
