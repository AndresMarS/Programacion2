namespace EquipoApp.Vistas
{
    partial class FrmNuevoEquipo
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
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblJugadores = new System.Windows.Forms.Label();
            this.lblListaEquipos = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.cboJugadores = new System.Windows.Forms.ComboBox();
            this.dgvListaJugadores = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblJugadoresDelEquipo = new System.Windows.Forms.Label();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Location = new System.Drawing.Point(57, 15);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(124, 16);
            this.lblNombreEquipo.TabIndex = 0;
            this.lblNombreEquipo.Text = "Nombre del Equipo";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(75, 61);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(106, 16);
            this.lblTecnico.TabIndex = 1;
            this.lblTecnico.Text = "Director Técnico";
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Location = new System.Drawing.Point(17, 108);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(164, 16);
            this.lblJugadores.TabIndex = 2;
            this.lblJugadores.Text = "Seleccione los Jugadores";
            // 
            // lblListaEquipos
            // 
            this.lblListaEquipos.AutoSize = true;
            this.lblListaEquipos.Location = new System.Drawing.Point(37, 148);
            this.lblListaEquipos.Name = "lblListaEquipos";
            this.lblListaEquipos.Size = new System.Drawing.Size(110, 16);
            this.lblListaEquipos.TabIndex = 3;
            this.lblListaEquipos.Text = "Lista de Equipos:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(187, 12);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(350, 22);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(187, 58);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(350, 22);
            this.txtTecnico.TabIndex = 4;
            // 
            // cboJugadores
            // 
            this.cboJugadores.FormattingEnabled = true;
            this.cboJugadores.Location = new System.Drawing.Point(187, 104);
            this.cboJugadores.Name = "cboJugadores";
            this.cboJugadores.Size = new System.Drawing.Size(482, 24);
            this.cboJugadores.TabIndex = 5;
            // 
            // dgvListaJugadores
            // 
            this.dgvListaJugadores.AllowUserToAddRows = false;
            this.dgvListaJugadores.AllowUserToDeleteRows = false;
            this.dgvListaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColDT,
            this.ColAcciones});
            this.dgvListaJugadores.Location = new System.Drawing.Point(40, 183);
            this.dgvListaJugadores.Name = "dgvListaJugadores";
            this.dgvListaJugadores.ReadOnly = true;
            this.dgvListaJugadores.RowHeadersWidth = 51;
            this.dgvListaJugadores.RowTemplate.Height = 24;
            this.dgvListaJugadores.Size = new System.Drawing.Size(396, 308);
            this.dgvListaJugadores.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(543, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(675, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(442, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 308);
            this.listBox1.TabIndex = 9;
            // 
            // lblJugadoresDelEquipo
            // 
            this.lblJugadoresDelEquipo.AutoSize = true;
            this.lblJugadoresDelEquipo.Location = new System.Drawing.Point(439, 148);
            this.lblJugadoresDelEquipo.Name = "lblJugadoresDelEquipo";
            this.lblJugadoresDelEquipo.Size = new System.Drawing.Size(140, 16);
            this.lblJugadoresDelEquipo.TabIndex = 10;
            this.lblJugadoresDelEquipo.Text = "Jugadores del Equipo";
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 125;
            // 
            // ColDT
            // 
            this.ColDT.HeaderText = "Director Técnico";
            this.ColDT.MinimumWidth = 6;
            this.ColDT.Name = "ColDT";
            this.ColDT.ReadOnly = true;
            this.ColDT.Width = 125;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Jugadores";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Width = 80;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(675, 105);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmNuevoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblJugadoresDelEquipo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvListaJugadores);
            this.Controls.Add(this.cboJugadores);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblListaEquipos);
            this.Controls.Add(this.lblJugadores);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblNombreEquipo);
            this.Name = "FrmNuevoEquipo";
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.FrmNuevoEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.Label lblListaEquipos;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.ComboBox cboJugadores;
        private System.Windows.Forms.DataGridView dgvListaJugadores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblJugadoresDelEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDT;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.Button btnAgregar;
    }
}