using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if(lista.Count > 0)
            {
                iconButton1.Visible = true;
            }

            DGVdata.Rows.Clear();

            foreach (Reporte r in lista)
            {
                DGVdata.Rows.Add(new object[] {
                    "",
                    r.ReporteID,
                    r.UsuarioID,
                    r.NombreCompleto,
                    r.Ficha,
                    r.EquipoID,
                    r.TipoEquipo,
                    r.NumeroSerie,
                    r.Estado
                });
            }
        }

        private void DGVdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVdata.Columns[e.ColumnIndex].Name == "seleccionar")
            {
                int indice = e.RowIndex;
                textBox1.Text = DGVdata.Rows[indice].Cells[1].Value.ToString();
                label3.Visible = true;
                textBox1.Visible = true;
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
            DataTable dt = new DataTable();
            foreach(DataGridViewColumn column in DGVdata.Columns)
            {
                dt.Columns.Add(column.Name);
            }
            foreach(DataGridViewRow row in DGVdata.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = "Resources/Reports/ReportPemex2.rdlc";
            localReport.DataSources.Clear();
            localReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            byte[] renderedBytes = localReport.Render("PDF");

            using (SaveFileDialog sfd = new SaveFileDialog()) 
            {
                sfd.Filter = "PDF files|*.pdf"; 
                sfd.Title = "Guardar reporte";
                sfd.FileName = $"Reporte{DateTime.Now.ToString("ddMMyyyy")}.pdf";
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    using(FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        fs.Write(renderedBytes, 0, renderedBytes.Length);
                    }
                }
            } 
        }
    }
}
