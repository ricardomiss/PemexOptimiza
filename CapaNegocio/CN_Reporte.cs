using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        public CD_Reporte objcd_reporte = new CD_Reporte();

        public List<Reporte> reporte(int UsuarioID)
        {
            return objcd_reporte.reporte(UsuarioID);
        }


    }
}
