using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public ListaEU listarRelacion()
        {
            ListaEU lista = new ListaEU();
            var query = "SELECT * FROM Usuario WHERE IsDeleted = 0";
            var query2 = "SELECT * FROM Equipo WHERE IsDeleted = 0";
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    SqlCommand cmd2 = new SqlCommand(query2, oconexion);
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.UsuariosL.Add(new Usuario()
                            {
                                UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Ficha = dr["Ficha"].ToString(),
                                Extensión = dr["Extensión"].ToString(),
                                Area = dr["Area"].ToString(),
                                Cargo = dr["Cargo"].ToString(),
                                Email = dr["Email"].ToString()
                            });
                        }
                    }
                    using (SqlDataReader dr = cmd2.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.EquiposL.Add(new Equipo()
                            {
                                EquipoID = Convert.ToInt32(dr["EquipoID"]),
                                TipoEquipo = dr["TipoEquipo"].ToString(),
                                NumeroSerie = dr["NumeroSerie"].ToString(),
                                Estado = dr["Estado"].ToString()
                            });
                        }
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    lista = new ListaEU();
                    return lista;
                }
            }
        }

        public List<Reporte> reporte( int UsuarioID)
        {
            List<Reporte> lista = new List<Reporte>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand ("SP_REPORTE", oconexion);
                    cmd.Parameters.AddWithValue("UsuarioID", UsuarioID);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Reporte()
                            {
                                ReporteID = Convert.ToInt32(dr["ReporteID"]),
                                UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Ficha = Convert.ToInt32(dr["Ficha"]),
                                EquipoID = Convert.ToInt32(dr["EquipoID"]),
                                TipoEquipo = dr["TipoEquipo"].ToString(),
                                NumeroSerie = Convert.ToInt32(dr["NumeroSerie"]),
                                Estado = dr["Estado"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Reporte>();

                }

            }
            return lista;

        }

        public bool SetRelation(int selectedValue1, int selectedValue2, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RELACION", oconexion);
                    cmd.Parameters.AddWithValue("EquipoID", selectedValue1);
                    cmd.Parameters.AddWithValue("UsuarioID", selectedValue2);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                }
                return respuesta;
            }
        }
    }
}
