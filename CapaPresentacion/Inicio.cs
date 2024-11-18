using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
                   
        private static IconMenuItem MenuActivo = null;  
        private static Form FormularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }
               
        

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
          
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)//, Inicio inicio)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.LightGreen;
            MenuActivo = menu;
            if (FormularioActivo!= null)

             {
                FormularioActivo.Close();
             }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkGray;
            contenedor.Controls.Add(formulario);
            formulario.Show();
            
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario());
           
        }

        /*private void AbrirFormulario(IconMenuItem sender, frmUsuario frmUsuario)
        {
            throw new NotImplementedException();
        }*/

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmEquipos());
        }

        private void MenuReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new frmReporte());
        }

        private void MenuRelacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmRelacion());
        }
    }
}
