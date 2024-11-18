namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuEquipos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuRelacion = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReporte = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInfo = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Perpetua", 12F);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuEquipos,
            this.MenuRelacion,
            this.MenuReporte,
            this.MenuInfo});
            this.menu.Location = new System.Drawing.Point(0, 54);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(154, 528);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 80;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(150, 100);
            this.MenuUsuario.Text = "Usuarios";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // MenuEquipos
            // 
            this.MenuEquipos.AutoSize = false;
            this.MenuEquipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuEquipos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.MenuEquipos.IconColor = System.Drawing.Color.Black;
            this.MenuEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuEquipos.IconSize = 85;
            this.MenuEquipos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuEquipos.Name = "MenuEquipos";
            this.MenuEquipos.Size = new System.Drawing.Size(150, 100);
            this.MenuEquipos.Text = "Equipos";
            this.MenuEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuEquipos.Click += new System.EventHandler(this.MenuEquipos_Click);
            // 
            // MenuRelacion
            // 
            this.MenuRelacion.AutoSize = false;
            this.MenuRelacion.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.MenuRelacion.IconColor = System.Drawing.Color.Black;
            this.MenuRelacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuRelacion.IconSize = 80;
            this.MenuRelacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuRelacion.Name = "MenuRelacion";
            this.MenuRelacion.Size = new System.Drawing.Size(150, 100);
            this.MenuRelacion.Text = "Relaciones";
            this.MenuRelacion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuRelacion.Click += new System.EventHandler(this.MenuRelacion_Click);
            // 
            // MenuReporte
            // 
            this.MenuReporte.AutoSize = false;
            this.MenuReporte.Font = new System.Drawing.Font("Perpetua", 12F);
            this.MenuReporte.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.MenuReporte.IconColor = System.Drawing.Color.Black;
            this.MenuReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReporte.IconSize = 80;
            this.MenuReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReporte.Name = "MenuReporte";
            this.MenuReporte.Size = new System.Drawing.Size(150, 100);
            this.MenuReporte.Text = "Reportes";
            this.MenuReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuReporte.Click += new System.EventHandler(this.MenuReporte_Click);
            // 
            // MenuInfo
            // 
            this.MenuInfo.AutoSize = false;
            this.MenuInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuInfo.IconColor = System.Drawing.Color.Black;
            this.MenuInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInfo.IconSize = 80;
            this.MenuInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(150, 100);
            this.MenuInfo.Text = "Info.";
            this.MenuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1028, 54);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "PemexOptimiza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Green;
            this.contenedor.Location = new System.Drawing.Point(119, 54);
            this.contenedor.Margin = new System.Windows.Forms.Padding(2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(915, 518);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 582);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuInfo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuEquipos;
        private FontAwesome.Sharp.IconMenuItem MenuReporte;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem MenuRelacion;
    }
}

