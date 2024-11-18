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
    public partial class frmRelacion : Form
    {
        public frmRelacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmboxEquipo.SelectedValue == null && cmboxUsuario.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un equipo y un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool result = new CN_Relacion().SetRelation((int)cmboxEquipo.SelectedValue, (int)cmboxUsuario.SelectedValue, out string mensaje);

            if (result)
            {
                label3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = mensaje;
            }
            else
            {
                MessageBox.Show($"Error al establecer la relación: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRelacion_Load(object sender, EventArgs e)
        {
            ListaEU data = new CN_Relacion().listar();

            cmboxEquipo.DataSource = data.EquiposL;
            cmboxEquipo.DisplayMember = "TipoEquipo";
            cmboxEquipo.ValueMember = "EquipoID";

            cmboxUsuario.DataSource = data.UsuariosL;
            cmboxUsuario.DisplayMember = "NombreCompleto";
            cmboxUsuario.ValueMember = "UsuarioID";

            if(cmboxEquipo.Items.Count > 0 && cmboxUsuario.Items.Count > 0)
            {
                btnBuscar.Enabled = true;
            }
        }
    }
}
