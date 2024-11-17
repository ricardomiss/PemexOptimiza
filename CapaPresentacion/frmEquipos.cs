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
using static System.Windows.Forms.MonthCalendar;
using System.Windows.Media.Media3D;

namespace CapaPresentacion
{
    public partial class frmEquipos : Form
    {
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVdata.Columns[e.ColumnIndex].Name == "seleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text= DGVdata.Rows[indice].Cells["id"].Value.ToString();
                    txtTipoEquipo.Text = DGVdata.Rows[indice].Cells["TipoEquipo"].Value.ToString();
                    txtmarca.Text = DGVdata.Rows[indice].Cells["Marca"].Value.ToString();
                    txtmodelo.Text = DGVdata.Rows[indice].Cells["Modelo"].Value.ToString();
                    txtserie.Text = DGVdata.Rows[indice].Cells["NumeroSerie"].Value.ToString();
                    txtestado.Text = DGVdata.Rows[indice].Cells["Estado"].Value.ToString();


                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Equipo obj = new Equipo()
            {
                EquipoID = Convert.ToInt32(txtid.Text),
                TipoEquipo = txtTipoEquipo.Text,
                Marca = txtmarca.Text,
                Modelo = txtmodelo.Text,
                NumeroSerie = txtserie.Text,
                Estado = txtestado.Text
            };
            if (obj.EquipoID == 0)
            {
                int idgenerado = new CN_Equipo().Registro(obj, out Mensaje);

                if (idgenerado != 0)
                {
                    DGVdata.Rows.Add(new object[] { "", idgenerado, txtTipoEquipo.Text, txtmarca.Text, txtmodelo.Text, txtserie.Text, txtestado.Text });
                    limpiar();

                }
                else
                {
                    MessageBox.Show(Mensaje);

                }
            }
            else
            {
                bool resultado = new CN_Equipo().Editar(obj, out Mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DGVdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["TipoEquipo"].Value = txtTipoEquipo.Text;
                    row.Cells["Marca"].Value = txtmarca.Text;
                    row.Cells["Modelo"].Value = txtmodelo.Text;
                    row.Cells["NumeroSerie"].Value = txtserie.Text;
                    row.Cells["Estado"].Value = txtestado.Text;


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
            txtTipoEquipo.Text = "";
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txtserie.Text = "";
            txtestado.Text = "";



        }















        private void frmEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaPxDataSet.Equipo' Puede moverla o quitarla según sea necesario.
            foreach (DataGridViewColumn columna in DGVdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cboBusqueda.Items.Add(new opcioncombo() { Valor = columna.Name, Texto = columna.HeaderText });

                }

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;



            List<Equipo> lista = new CN_Equipo().listar();
            foreach (Equipo item in lista)
            {
               DGVdata.Rows.Add(new object[] {"", 
                   item.EquipoID,
                   item.TipoEquipo,
                   item.Marca,
                   item.Modelo,
                   item.NumeroSerie,
                   item.Estado});
            }


        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((opcioncombo)cboBusqueda.SelectedItem).Valor.ToString();

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el equipo? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Equipo obj = new Equipo()
                    {
                        EquipoID = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Equipo().Eliminar(obj, out mensaje);

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

        private void DGVequipo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


    }
}
