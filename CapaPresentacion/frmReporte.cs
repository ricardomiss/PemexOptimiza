using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           int UsuarioID = (Convert.ToInt32(txtUsuarioID.Text));

            List<Reporte> lista = new List<Reporte>();
            lista = new CN_Reporte().reporte(
                UsuarioID);


            DGVdata.Rows.Clear();

            foreach (Reporte r in lista)
            {
                DGVdata.Rows.Add(new object[] {
                    //r.UsuarioID,
                    r.NombreCompleto,
                    r.Ficha,
                    //r.EquipoID,
                    r.TipoEquipo,
                    r.NumeroSerie,
                    r.Estado

                });
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
