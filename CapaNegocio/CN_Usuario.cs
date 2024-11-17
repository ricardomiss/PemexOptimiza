using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Usuario
    {

        public CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> listar()
        {
            return objcd_usuario.listar();

        }
        public int Registro(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (obj.Ficha == "")
            {
                Mensaje += "Es necesario la ficha del usuario\n";
            }
            if (obj.Extensión == "")
            {
                Mensaje += "Es necesario la Extensión del usuario\n";
            }

            if (obj.Area == "")
            {
                Mensaje += "Es necesario la Area del usuario\n";
            }
            if (obj.Cargo == "")
            {
                Mensaje += "Es necesario el Cargo del usuario\n";
            }
            if (obj.Email == "")
            {
                Mensaje += "Es necesario el email del usuario\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_usuario.Registro(obj, out Mensaje);
            }
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (obj.Ficha == "")
            {
                Mensaje += "Es necesario la ficha del usuario\n";
            }
            if (obj.Extensión == "")
            {
                Mensaje += "Es necesario la Extensión del usuario\n";
            }

            if (obj.Area == "")
            {
                Mensaje += "Es necesario la Area del usuario\n";
            }
            if (obj.Cargo == "")
            {
                Mensaje += "Es necesario el Cargo del usuario\n";
            }
            if (obj.Email == "")
            {
                Mensaje += "Es necesario el email del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }



                    
        }

        public bool Eliminar (Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }





















    
    }
}


