using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Drawing.Text;
using FontAwesome.Sharp;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            List<Usuario> Text = new CN_Usuario().listar();

            Usuario ousuario = new CN_Usuario().listar().Where(u => u.Ficha == txtFicha.Text && u.Contraseña == txtContraseña.Text).FirstOrDefault();
            
            if (ousuario != null) {
            
            Inicio form = new Inicio();

            form.Show();
            this.Hide();
            }
            else { MessageBox.Show("No se encontro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }

        private void btnNuevoregistro_Click(object sender, EventArgs e)

        {
            frmRegistro form = new frmRegistro();

            form.Show();
            this.Hide();

            


        }

        private void frm_closing (object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

