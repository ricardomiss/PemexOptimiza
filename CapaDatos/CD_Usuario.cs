using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using CapaEntidad;
namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select UsuarioID, NombreCompleto, Ficha, Extensión,Area,Cargo,Email,Contraseña from Usuario ";
                    //query.AppendLine("select u.UsuarioID, u.NombreCompleto, u.Ficha, u.Extensión,u.Area,u.Cargo,u.Email,r.EquipoID, r.NumeroSerie from Usuario u ");
                    //query.AppendLine("inner join Equipo r on r.EquipoID = u.UsuarioID     ");
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {


                            lista.Add(new Usuario()
                            {
                                UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Ficha = dr["Ficha"].ToString(),
                                Extensión = dr["Extensión"].ToString(),
                                Area = dr["Area"].ToString(),
                                Cargo = dr["Cargo"].ToString(),
                                Email = dr["Email"].ToString(),
                                Contraseña = dr["Contraseña"].ToString(),
                                //oEquipo = new Equipo() { EquipoID = Convert.ToInt32(dr["EquipoID"]), NumeroSerie = dr["NumeroSerie"].ToString() }


                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();

                }

            }
            return lista;

        }



        public int Registro(Usuario obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("Sp_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("NombreCompleto ", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Ficha ", obj.Ficha);
                    cmd.Parameters.AddWithValue("Extensión ", obj.Extensión);
                    cmd.Parameters.AddWithValue("Area ", obj.Area);
                    cmd.Parameters.AddWithValue("Cargo ", obj.Cargo);
                    cmd.Parameters.AddWithValue("Email ", obj.Email);
                    //cmd.Parameters.AddWithValue("IDEquipo ", obj.oEquipo.EquipoID);

                    cmd.Parameters.Add("@UsuarioIDresultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["UsuarioIDresultado "].Value);
                    Mensaje = cmd.Parameters["Mensaje "].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }

            return idusuariogenerado;





        }


        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("Sp_ELIMINAUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("UsuarioID", obj.UsuarioID);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta "].Value);
                    Mensaje = cmd.Parameters["Mensaje "].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("UsuarioID", obj.UsuarioID);
                    cmd.Parameters.AddWithValue("NombreCompleto ", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Ficha ", obj.Ficha);
                    cmd.Parameters.AddWithValue("Extensión ", obj.Extensión);
                    cmd.Parameters.AddWithValue("Area ", obj.Area);
                    cmd.Parameters.AddWithValue("Cargo ", obj.Cargo);
                    cmd.Parameters.AddWithValue("Email ", obj.Email);
                    //cmd.Parameters.AddWithValue("IDEquipo ", obj.oEquipo.EquipoID);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta "].Value);
                    Mensaje = cmd.Parameters["Mensaje "].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

       


   



    }
}












