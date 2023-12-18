using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbmAlumnos
{
    public partial class frmAlumnos : Form
    {
        bool esNuevo;
        AlumnoServicio oServicio;
        List<Alumno> lAlumnos;

        public frmAlumnos()
        {
            InitializeComponent();
            oServicio = new AlumnoServicio();
            lAlumnos = new List<Alumno>();
            this.FormClosing += new FormClosingEventHandler(frmAlumnos_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Habilitar(false);
            CargarCombo(cboTipoDoc, "tipos_documentos");
            CargarCombo(cboCarrera, "carreras");
            CargarLista();
        }

        private void Habilitar(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Enabled = x;
                if (c is ComboBox)
                    c.Enabled = x;
                if (c is RadioButton)
                    c.Enabled = x;
                if (c is CheckBox)
                    c.Enabled = x;
                if (c is DateTimePicker)
                    c.Enabled = x;
            }
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = x;
            btnBorrar.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            lstAlumnos.Enabled = !x;
        }

        private void CargarCombo(ComboBox combo, string nomTabla)
        {
            DataTable dt = oServicio.TraerTablaAux(nomTabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void CargarLista()
        {
            lAlumnos = oServicio.TraerAlumnos();
            lstAlumnos.DataSource = lAlumnos;
            lstAlumnos.SelectedIndex = lstAlumnos.Items.Count - 1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Habilitar(true);
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            txtCantidad.Enabled = false;
            lstAlumnos.Enabled = false;
            lstAlumnos.SelectedIndex = -1;
            LimpiarCampos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                if (ValidarDatos())
                {
                    Alumno a = new Alumno();
                    a.Apellido = txtApellido.Text;
                    a.Nombre = txtNombre.Text;
                    a.FechaNac = dtpFechaNac.Value;
                    if (rbtM.Checked)
                        a.Sexo = 1;
                    else
                        a.Sexo = 2;
                    a.TipoDocumento = Convert.ToInt32(cboTipoDoc.SelectedValue);
                    a.NroDocumento = Convert.ToInt32(txtDoc.Text);
                    a.Calle = txtCalle.Text;
                    a.NroCalle = Convert.ToInt32(txtNro.Text);
                    a.Actividad = cbxActividad.Checked;
                    a.Casado = cbxCasado.Checked;
                    a.Hijos = cbxHijos.Checked;
                    if (cbxHijos.Checked)
                        a.CantidadHijos = Convert.ToInt32(txtCantidad.Text);
                    a.Carrera = Convert.ToInt32(cboCarrera.SelectedValue);

                    if (oServicio.Grabar(a, esNuevo) > 0)
                    {
                        MessageBox.Show("Se ha grabó el Alumno correctamente.");
                        CargarLista();
                        Habilitar(false);
                        lstAlumnos.Focus();
                        lstAlumnos.SelectedIndex = lstAlumnos.Items.Count - 1;
                    }
                    else
                        MessageBox.Show("No se púdo grabar el Alumno!");
                    btnGrabar.Enabled = false;
                }
            }
            else
            {
                if (ValidarDatos())
                {
                    Alumno a = new Alumno();
                    a.Apellido = txtApellido.Text;
                    a.Nombre = txtNombre.Text;
                    a.FechaNac = dtpFechaNac.Value;
                    if (rbtM.Checked)
                        a.Sexo = 1;
                    else
                        a.Sexo = 2;
                    a.TipoDocumento = Convert.ToInt32(cboTipoDoc.SelectedValue);
                    a.NroDocumento = Convert.ToInt32(txtDoc.Text);
                    a.Calle = txtCalle.Text;
                    a.NroCalle = Convert.ToInt32(txtNro.Text);
                    a.Actividad = cbxActividad.Checked;
                    a.Casado = cbxCasado.Checked;
                    a.Hijos = cbxHijos.Checked;
                    if (cbxHijos.Checked)
                        a.CantidadHijos = Convert.ToInt32(txtCantidad.Text);
                    a.Carrera = Convert.ToInt32(cboCarrera.SelectedValue);

                    if (oServicio.Grabar(a, esNuevo) > 0)
                    {
                        MessageBox.Show("Se ha editó el Alumno correctamente.");
                        CargarLista();
                        Habilitar(false);
                        lstAlumnos.Focus();
                        lstAlumnos.SelectedIndex = lstAlumnos.Items.Count - 1;
                    }
                    else
                        MessageBox.Show("No se púdo editar el Alumno!");
                    btnGrabar.Enabled = false;
                }
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un Apellido...");
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre...");
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDoc.Text))
            {
                MessageBox.Show("Debe ingresar un Número de Documento...");
                txtDoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Debe ingresar una Calle...");
                txtCalle.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNro.Text))
            {
                MessageBox.Show("Debe ingresar un Número de Calle...");
                txtNro.Focus();
                return false;
            }
            if (cbxHijos.Checked)
            {
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe ingresar una Cantidad de Hijos...");
                    txtCantidad.Focus();
                    return false;
                }
            }
            if (!rbtM.Checked && !rbtF.Checked)
            {
                MessageBox.Show("Debe seleccionar un Sexo...");
                rbtM.Focus();
                return false;
            }
            if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Documento...");
                cboTipoDoc.Focus();
                return false;
            }
            if (cboCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Carrera...");
                cboCarrera.Focus();
                return false;
            }
            return true;
        }

        private void cbxHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHijos.Checked)
                txtCantidad.Enabled = true;
            else
            {
                txtCantidad.Text = string.Empty;
                txtCantidad.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            LimpiarCampos();
            lstAlumnos.Focus();
        }

        private void LimpiarCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Today;
            }
        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstAlumnos.SelectedIndex;
            if (index >= 0)
            {
                CargarCampos(lAlumnos[index]);
                Habilitar(false);
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }


        private void CargarCampos(Alumno a)
        {
            txtApellido.Text = a.Apellido;
            txtNombre.Text = a.Nombre;
            dtpFechaNac.Value = a.FechaNac;
            if (a.Sexo == 1)
                rbtM.Checked = true;
            if (a.Sexo == 2)
                rbtF.Checked = true;
            cboTipoDoc.SelectedValue = a.TipoDocumento;
            txtDoc.Text = a.NroDocumento.ToString();
            txtCalle.Text = a.Calle;
            txtNro.Text = a.NroCalle.ToString();
            cbxActividad.Checked = a.Actividad;
            cbxCasado.Checked = a.Casado;
            cbxHijos.Checked = a.Hijos;
            txtCantidad.Text = a.CantidadHijos.ToString();
            cboCarrera.SelectedValue = a.Carrera;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Habilitar(true);
            btnNuevo.Enabled = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            txtDoc.Enabled = false;
            cboTipoDoc.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedIndex >= 0)
            {
                string mensaje = "Seguro que desea eliminar al alumno: " + lAlumnos[lstAlumnos.SelectedIndex].ToString() + "?";
                if (MessageBox.Show(mensaje, "Eliminar"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning
                    , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (oServicio.BorrarRegistro(lAlumnos[lstAlumnos.SelectedIndex].NroDocumento) > 0)
                    {
                        MessageBox.Show("Se Eliminó correctamente el alumno.", "Eliminado");
                        CargarLista();
                        btnNuevo.Focus();
                    }
                    else
                        MessageBox.Show("No se pudo Eliminar el Alumno.", "Error");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de abandonar la aplicación?"
                , "Salir"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
