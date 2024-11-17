using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public class CD_Equipo
    {
        public List<Equipo> listar()
        {
            List<Equipo> lista = new List<Equipo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select EquipoID,TipoEquipo,Marca, Modelo, NumeroSerie, Estado from Equipo";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Equipo()
                            {
                                EquipoID = Convert.ToInt32(dr["EquipoID"]),
                                TipoEquipo = dr["TipoEquipo"].ToString(),
                                Marca = dr["Marca"].ToString(),
                                Modelo = dr["Modelo"].ToString(),
                                NumeroSerie = dr["NumeroSerie"].ToString(),
                                Estado = dr["Estado"].ToString(),

                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Equipo>();

                }

            }
            return lista;

        }


        public int Registro(Equipo obj, out string Mensaje)
        {
            int idEquipogenerado = 0;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("Sp_REGISTRAREQUIPO", oconexion);
                    cmd.Parameters.AddWithValue("TipoEquipo ", obj.TipoEquipo);
                    cmd.Parameters.AddWithValue("Marca ", obj.Marca);
                    cmd.Parameters.AddWithValue("Modelo ", obj.Modelo);
                    cmd.Parameters.AddWithValue("NumeroSerie ", obj.NumeroSerie);
                    cmd.Parameters.AddWithValue("Estado ", obj.Estado);
                    cmd.Parameters.Add("EquipoIDresultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idEquipogenerado = Convert.ToInt32(cmd.Parameters["EquipoIDresultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idEquipogenerado = 0;
                Mensaje = ex.Message;
            }

            return idEquipogenerado;





        }


        public bool Eliminar(Equipo obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("Sp_ELIMINAREQUIPO", oconexion);
                    cmd.Parameters.AddWithValue("EquipoID", obj.EquipoID);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
        public bool Editar(Equipo obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("Sp_EDITAREQUIPO", oconexion);
                    cmd.Parameters.AddWithValue("EquipoID", obj.EquipoID);
                    cmd.Parameters.AddWithValue("TipoEquipo ", obj.TipoEquipo);
                    cmd.Parameters.AddWithValue("Marca ", obj.Marca);
                    cmd.Parameters.AddWithValue("Modelo ", obj.Modelo);
                    cmd.Parameters.AddWithValue("NumeroSerie ", obj.NumeroSerie);
                    cmd.Parameters.AddWithValue("Estado ", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
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

