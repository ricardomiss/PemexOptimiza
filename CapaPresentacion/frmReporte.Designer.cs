namespace CapaPresentacion
{
    partial class frmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVdata = new System.Windows.Forms.DataGridView();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReporteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ficha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(221, 79);
            this.txtUsuarioID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(139, 20);
            this.txtUsuarioID.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(140, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "UsuarioID:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(84, 82);
            this.txtindice.Margin = new System.Windows.Forms.Padding(2);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(20, 20);
            this.txtindice.TabIndex = 53;
            this.txtindice.Text = "0";
            this.txtindice.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Indice:";
            this.label11.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(908, 99);
            this.label2.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 69);
            this.label1.TabIndex = 56;
            this.label1.Text = "Reporte";
            // 
            // DGVdata
            // 
            this.DGVdata.AllowUserToAddRows = false;
            this.DGVdata.BackgroundColor = System.Drawing.Color.LightGreen;
            this.DGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionar,
            this.ReporteID,
            this.UsuarioID,
            this.NombreCompleto,
            this.Ficha,
            this.EquipoID,
            this.TipoEquipo,
            this.NumeroSerie,
            this.Estado});
            this.DGVdata.Location = new System.Drawing.Point(9, 105);
            this.DGVdata.Margin = new System.Windows.Forms.Padding(2);
            this.DGVdata.Name = "DGVdata";
            this.DGVdata.ReadOnly = true;
            this.DGVdata.RowHeadersVisible = false;
            this.DGVdata.RowHeadersWidth = 51;
            this.DGVdata.RowTemplate.Height = 24;
            this.DGVdata.Size = new System.Drawing.Size(887, 324);
            this.DGVdata.TabIndex = 57;
            this.DGVdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdata_CellContentClick);
            this.DGVdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVdata_CellPainting);
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "";
            this.seleccionar.MinimumWidth = 6;
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            this.seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seleccionar.Width = 30;
            // 
            // ReporteID
            // 
            this.ReporteID.HeaderText = "Id";
            this.ReporteID.Name = "ReporteID";
            this.ReporteID.ReadOnly = true;
            this.ReporteID.Visible = false;
            // 
            // UsuarioID
            // 
            this.UsuarioID.HeaderText = "UsuarioID";
            this.UsuarioID.MinimumWidth = 10;
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.ReadOnly = true;
            this.UsuarioID.Visible = false;
            this.UsuarioID.Width = 180;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 280;
            // 
            // Ficha
            // 
            this.Ficha.HeaderText = "Ficha";
            this.Ficha.MinimumWidth = 6;
            this.Ficha.Name = "Ficha";
            this.Ficha.ReadOnly = true;
            this.Ficha.Width = 118;
            // 
            // EquipoID
            // 
            this.EquipoID.HeaderText = "EquipoID";
            this.EquipoID.MinimumWidth = 6;
            this.EquipoID.Name = "EquipoID";
            this.EquipoID.ReadOnly = true;
            this.EquipoID.Visible = false;
            this.EquipoID.Width = 200;
            // 
            // TipoEquipo
            // 
            this.TipoEquipo.HeaderText = "Tipo de equipo";
            this.TipoEquipo.MinimumWidth = 6;
            this.TipoEquipo.Name = "TipoEquipo";
            this.TipoEquipo.ReadOnly = true;
            this.TipoEquipo.Width = 200;
            // 
            // NumeroSerie
            // 
            this.NumeroSerie.HeaderText = "Numero de serie";
            this.NumeroSerie.MinimumWidth = 6;
            this.NumeroSerie.Name = "NumeroSerie";
            this.NumeroSerie.ReadOnly = true;
            this.NumeroSerie.Width = 148;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 110;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(380, 76);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 26);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 91;
            this.iconPictureBox1.Location = new System.Drawing.Point(776, 8);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(91, 91);
            this.iconPictureBox1.TabIndex = 59;
            this.iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Reporte Seleccionado";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(612, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(36, 24);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(447, 70);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(115, 31);
            this.iconButton1.TabIndex = 63;
            this.iconButton1.Text = "Generar PDF";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Visible = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 446);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.DGVdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuarioID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVdata;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReporteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ficha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}