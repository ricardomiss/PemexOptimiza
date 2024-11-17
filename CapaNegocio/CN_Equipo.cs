using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CapaNegocio
{
    public class CN_Equipo
    {
        public CD_Equipo objcd_Equipo = new CD_Equipo();

        public List<Equipo> listar()
        {
            return objcd_Equipo.listar();

        }
        public int Registro(Equipo obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.TipoEquipo == "")
            {
                Mensaje += "Es necesario el tipo de Equipo \n";
            }

            if (obj.Marca == "")
            {
                Mensaje += "Es necesario la Marca del Equipo\n";
            }
            if (obj.Modelo == "")
            {
                Mensaje += "Es necesario el modelo del Equipo\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_Equipo.Registro(obj, out Mensaje);
            }
        }

        public bool Editar(Equipo obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.TipoEquipo == "")
            {
                Mensaje += "Es necesario el tipo de Equipo \n";
            }

            if (obj.Marca == "")
            {
                Mensaje += "Es necesario la Marca del Equipo\n";
            }
            if (obj.Modelo == "")
            {
                Mensaje += "Es necesario el modelo del Equipo\n";
            }

            if (obj.NumeroSerie == "")
            {
                Mensaje += "Es necesario el numero de serie del Equipo\n";
            }
            if (obj.Estado == "")
            {
                Mensaje += "Es necesario el estado del Equipo\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Equipo.Editar(obj, out Mensaje);
            }




        }

        public bool Eliminar(Equipo obj, out string Mensaje)
        {
            return objcd_Equipo.Eliminar(obj, out Mensaje);
        }





    }
}
