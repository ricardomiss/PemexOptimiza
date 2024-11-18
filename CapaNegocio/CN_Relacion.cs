using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Relacion
    {
        public CD_Reporte objcd_relacion = new CD_Reporte();
        public ListaEU listar()
        {
            return objcd_relacion.listarRelacion();
        }

        public bool SetRelation(int selectedValue1, int selectedValue2,out string Mensaje)
        {
            return objcd_relacion.SetRelation(selectedValue1, selectedValue2, out Mensaje);
        }
    }
}
