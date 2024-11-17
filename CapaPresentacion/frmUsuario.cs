
using CapaEntidad;
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
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            

            foreach (DataGridViewColumn columna in DGVdata.Columns)
            {
                if (columna.Visible == true)
                {
                   cbobusqueda.Items.Add(new opcioncombo() { Valor = columna.Name, Texto=columna.HeaderText });
                 
                }
                
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
           
            List<Usuario> lista = new CN_Usuario().listar();
            foreach (Usuario item in lista)
            {
                DGVdata.Rows.Add(new object[] {"",item.UsuarioID,item.NombreCompleto,item.Ficha,item.Extensión,
                                             item.Area,
                                             item.Cargo,item.Email});
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                UsuarioID = Convert.ToInt32(txtid.Text),
                NombreCompleto = txtNombreCompleto.Text,
                Ficha = txtficha.Text,
                Extensión = txtextencion.Text,
                Area = txtArea.Text,
                Cargo = txtcargo.Text,
                Email = txtCorreo.Text
            };

            if (objusuario.UsuarioID == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registro(objusuario, out Mensaje);

                if (idusuariogenerado != 0)
                {
                    DGVdata.Rows.Add(new object[] { "",idusuariogenerado ,txtNombreCompleto.Text, txtficha.Text, txtextencion.Text,
                    txtArea.Text, txtcargo.Text,txtCorreo.Text });//((OpcionDepartamento)cboArea.SelectedItem).Texto.ToString(),
                    limpiar();

                }

                else
                {
                    MessageBox.Show(Mensaje);

                }


            }
            else
            {
                bool resultado = new CN_Usuario().Editar(objusuario, out Mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DGVdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Ficha"].Value = txtficha.Text;
                    row.Cells["Extensión"].Value = txtextencion.Text;
                    row.Cells["Area"].Value = txtArea.Text;
                    row.Cells["Cargo"].Value = txtcargo.Text;
                    row.Cells["Email"].Value = txtCorreo.Text;

                    limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }



        }

        private void limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtNombreCompleto.Text = "";
            txtficha.Text = "";
            txtextencion.Text = "";
            txtArea.Text = "";
            txtCorreo.Text = "";
            txtcargo.Text = "";


        }

        private void DGVdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = DGVdata.Rows[indice].Cells["id"].Value.ToString();
                    txtNombreCompleto.Text = DGVdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtficha.Text = DGVdata.Rows[indice].Cells["Ficha"].Value.ToString();
                    txtextencion.Text = DGVdata.Rows[indice].Cells["Extensión"].Value.ToString();
                    txtArea.Text = DGVdata.Rows[indice].Cells["Area"].Value.ToString();
                    txtcargo.Text = DGVdata.Rows[indice].Cells["Cargo"].Value.ToString();
                    txtCorreo.Text = DGVdata.Rows[indice].Cells["Email"].Value.ToString();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        UsuarioID = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        DGVdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void DGVdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((opcioncombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (DGVdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVdata.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    
                        row.Visible = true;
                    
                    else
                         row.Visible = false; 

                }


            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
