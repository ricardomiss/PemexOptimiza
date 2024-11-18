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


    }
}
