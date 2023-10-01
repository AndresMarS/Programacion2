namespace EquipoApp.Vistas
{
    partial class FrmEditarJugadores
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
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.lblNroCamiseta = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNroCamiseta = new System.Windows.Forms.TextBox();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpNuevoJugador = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.grpNuevoJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.Location = new System.Drawing.Point(28, 24);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(117, 16);
            this.lblNombreJugador.TabIndex = 0;
            this.lblNombreJugador.Text = "Nombre Completo";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(151, 21);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(493, 22);
            this.txtNombreJugador.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(151, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(151, 113);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 22);
            this.dtpFecNac.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(115, 70);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 16);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(10, 116);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(135, 16);
            this.lblFecNac.TabIndex = 5;
            this.lblFecNac.Text = "Fecha de Nacimiento";
            // 
            // lblNroCamiseta
            // 
            this.lblNroCamiseta.AutoSize = true;
            this.lblNroCamiseta.Location = new System.Drawing.Point(11, 162);
            this.lblNroCamiseta.Name = "lblNroCamiseta";
            this.lblNroCamiseta.Size = new System.Drawing.Size(134, 16);
            this.lblNroCamiseta.TabIndex = 6;
            this.lblNroCamiseta.Text = "Número de Camiseta";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(86, 209);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(59, 16);
            this.lblPosicion.TabIndex = 7;
            this.lblPosicion.Text = "Posición";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(151, 67);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(176, 22);
            this.txtDni.TabIndex = 1;
            // 
            // txtNroCamiseta
            // 
            this.txtNroCamiseta.Location = new System.Drawing.Point(151, 159);
            this.txtNroCamiseta.Name = "txtNroCamiseta";
            this.txtNroCamiseta.Size = new System.Drawing.Size(100, 22);
            this.txtNroCamiseta.TabIndex = 3;
            this.txtNroCamiseta.TextChanged += new System.EventHandler(this.txtNroCamiseta_TextChanged);
            // 
            // cboPosicion
            // 
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Location = new System.Drawing.Point(151, 205);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(493, 24);
            this.cboPosicion.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(264, 668);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(452, 668);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColDNI,
            this.ColFecNac,
            this.ColPosicion,
            this.ColCamiseta,
            this.ColAcciones});
            this.dgvJugadores.Location = new System.Drawing.Point(12, 310);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.RowTemplate.Height = 24;
            this.dgvJugadores.Size = new System.Drawing.Size(776, 352);
            this.dgvJugadores.TabIndex = 1;
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellContentClick);
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
            this.ColNombre.Width = 165;
            // 
            // ColDNI
            // 
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.MinimumWidth = 6;
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.ReadOnly = true;
            this.ColDNI.Width = 70;
            // 
            // ColFecNac
            // 
            this.ColFecNac.HeaderText = "Fecha Nacimineto";
            this.ColFecNac.MinimumWidth = 6;
            this.ColFecNac.Name = "ColFecNac";
            this.ColFecNac.ReadOnly = true;
            this.ColFecNac.Width = 75;
            // 
            // ColPosicion
            // 
            this.ColPosicion.HeaderText = "Posicion";
            this.ColPosicion.MinimumWidth = 6;
            this.ColPosicion.Name = "ColPosicion";
            this.ColPosicion.ReadOnly = true;
            this.ColPosicion.Width = 85;
            // 
            // ColCamiseta
            // 
            this.ColCamiseta.HeaderText = "Camiseta";
            this.ColCamiseta.MinimumWidth = 6;
            this.ColCamiseta.Name = "ColCamiseta";
            this.ColCamiseta.ReadOnly = true;
            this.ColCamiseta.Width = 60;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Width = 70;
            // 
            // grpNuevoJugador
            // 
            this.grpNuevoJugador.Controls.Add(this.txtNombreJugador);
            this.grpNuevoJugador.Controls.Add(this.lblNombreJugador);
            this.grpNuevoJugador.Controls.Add(this.btnAgregar);
            this.grpNuevoJugador.Controls.Add(this.dtpFecNac);
            this.grpNuevoJugador.Controls.Add(this.cboPosicion);
            this.grpNuevoJugador.Controls.Add(this.lblDni);
            this.grpNuevoJugador.Controls.Add(this.txtNroCamiseta);
            this.grpNuevoJugador.Controls.Add(this.lblFecNac);
            this.grpNuevoJugador.Controls.Add(this.txtDni);
            this.grpNuevoJugador.Controls.Add(this.lblNroCamiseta);
            this.grpNuevoJugador.Controls.Add(this.lblPosicion);
            this.grpNuevoJugador.Location = new System.Drawing.Point(12, 12);
            this.grpNuevoJugador.Name = "grpNuevoJugador";
            this.grpNuevoJugador.Size = new System.Drawing.Size(776, 283);
            this.grpNuevoJugador.TabIndex = 1;
            this.grpNuevoJugador.TabStop = false;
            this.grpNuevoJugador.Text = "Nuevo Jugador";
            // 
            // FrmEditarJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.grpNuevoJugador);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmEditarJugadores";
            this.Text = "Editar Jugadores";
            this.Load += new System.EventHandler(this.FrmNuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.grpNuevoJugador.ResumeLayout(false);
            this.grpNuevoJugador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.Label lblNroCamiseta;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNroCamiseta;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCamiseta;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.GroupBox grpNuevoJugador;
    }
}