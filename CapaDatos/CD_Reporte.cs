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
                    //string query = "select NombreCompleto,Ficha, Modelo, NumeroSerie, Estado from Reporte";
                    //SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Reporte()
                            {
                                //UsuarioID = dr["UsuarioID"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Ficha = dr["Ficha"].ToString(),
                                //EquipoID = dr["EquipoID"].ToString(),
                                TipoEquipo = dr["Modelo"].ToString(),
                                NumeroSerie = dr["NumeroSerie"].ToString(),
                                Estado = dr["Estado"].ToString(),

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


    }
}
