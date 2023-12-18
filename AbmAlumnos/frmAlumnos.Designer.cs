namespace AbmAlumnos
{
    partial class frmAlumnos
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
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbxActividad = new System.Windows.Forms.CheckBox();
            this.cbxHijos = new System.Windows.Forms.CheckBox();
            this.cbxCasado = new System.Windows.Forms.CheckBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(110, 238);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 16);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(235, 351);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(96, 391);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 16);
            this.lblCarrera.TabIndex = 2;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(430, 238);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(32, 16);
            this.lblNro.TabIndex = 3;
            this.lblNro.Text = "Nro.";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(362, 198);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(35, 16);
            this.lblDoc.TabIndex = 4;
            this.lblDoc.Text = "Doc.";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(41, 198);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(107, 16);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(110, 158);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 16);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(32, 118);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(116, 16);
            this.lblFechaNac.TabIndex = 7;
            this.lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(92, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(91, 38);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(414, 22);
            this.txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(414, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(154, 235);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(270, 22);
            this.txtCalle.TabIndex = 7;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(403, 195);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(165, 22);
            this.txtDoc.TabIndex = 6;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(468, 235);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 22);
            this.txtNro.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(302, 348);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 12;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(154, 194);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(202, 24);
            this.cboTipoDoc.TabIndex = 5;
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(154, 387);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(414, 24);
            this.cboCarrera.TabIndex = 13;
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Location = new System.Drawing.Point(154, 156);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(39, 20);
            this.rbtM.TabIndex = 3;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "M";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.Location = new System.Drawing.Point(199, 156);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(36, 20);
            this.rbtF.TabIndex = 4;
            this.rbtF.TabStop = true;
            this.rbtF.Text = "F";
            this.rbtF.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(154, 115);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(142, 22);
            this.dtpFechaNac.TabIndex = 2;
            // 
            // cbxActividad
            // 
            this.cbxActividad.AutoSize = true;
            this.cbxActividad.Location = new System.Drawing.Point(154, 278);
            this.cbxActividad.Name = "cbxActividad";
            this.cbxActividad.Size = new System.Drawing.Size(85, 20);
            this.cbxActividad.TabIndex = 9;
            this.cbxActividad.Text = "Actividad";
            this.cbxActividad.UseVisualStyleBackColor = true;
            // 
            // cbxHijos
            // 
            this.cbxHijos.AutoSize = true;
            this.cbxHijos.Location = new System.Drawing.Point(154, 350);
            this.cbxHijos.Name = "cbxHijos";
            this.cbxHijos.Size = new System.Drawing.Size(60, 20);
            this.cbxHijos.TabIndex = 11;
            this.cbxHijos.Text = "Hijos";
            this.cbxHijos.UseVisualStyleBackColor = true;
            this.cbxHijos.CheckedChanged += new System.EventHandler(this.cbxHijos_CheckedChanged);
            // 
            // cbxCasado
            // 
            this.cbxCasado.AutoSize = true;
            this.cbxCasado.Location = new System.Drawing.Point(154, 314);
            this.cbxCasado.Name = "cbxCasado";
            this.cbxCasado.Size = new System.Drawing.Size(77, 20);
            this.cbxCasado.TabIndex = 10;
            this.cbxCasado.Text = "Casado";
            this.cbxCasado.UseVisualStyleBackColor = true;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 16;
            this.lstAlumnos.Location = new System.Drawing.Point(604, 38);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(226, 372);
            this.lstAlumnos.TabIndex = 20;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(755, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(521, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(409, 435);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 17;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(297, 435);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(185, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(73, 435);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.cbxCasado);
            this.Controls.Add(this.cbxHijos);
            this.Controls.Add(this.cbxActividad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.rbtF);
            this.Controls.Add(this.rbtM);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCalle);
            this.Name = "frmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.CheckBox cbxActividad;
        private System.Windows.Forms.CheckBox cbxHijos;
        private System.Windows.Forms.CheckBox cbxCasado;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
    }
}

