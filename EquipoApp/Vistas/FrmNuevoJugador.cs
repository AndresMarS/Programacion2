using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipoApp.Datos;
using EquipoApp.Dominio;

namespace EquipoApp.Vistas
{
    public partial class FrmEditarJugadores : Form
    {
        HelperDB gestor;
        Jugador nuevoJ;
        public FrmEditarJugadores()
        {
            InitializeComponent();
            gestor = new HelperDB();
            nuevoJ = new Jugador();
        }

        private void FrmNuevoJugador_Load(object sender, EventArgs e)
        {
            CargarPosicion();
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            dgvJugadores.Rows.Clear();
            DataTable dt = gestor.ConsultarTabla("SP_CONSULTAR_JUGADORES");

            foreach (DataRow r in dt.Rows)
            {
                dgvJugadores.Rows.Add(new object[]
                {
                    r["id_jugador"],
                    r["nombre_completo"].ToString(),
                    r["dni"].ToString(),
                    Convert.ToDateTime(r["fecha_nac"]).ToString("dd/MM/yyyy"),
                    r["posicion"].ToString(),
                    r["camiseta"].ToString(),
                    "Eliminar"
                });
            }
        }

        private void CargarPosicion()
        {
            DataTable dt = gestor.ConsultarTabla("SP_CONSULTAR_POSICIONES");
            cboPosicion.DataSource = dt;
            cboPosicion.ValueMember = dt.Columns[0].ColumnName;
            cboPosicion.DisplayMember = dt.Columns[1].ColumnName;
            cboPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosicion.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar
            if (txtNombreJugador.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El Nombre no puede contener números...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataGridViewRow r in dgvJugadores.Rows)
            {
                if (r.Cells["ColNombre"].Value.ToString().Equals(txtNombreJugador.Text))
                {
                    MessageBox.Show("Este Jugador ya existe...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtDni.Text) || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("Debe Ingresar un DNI valido...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtpFecNac.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Debe Ingresar una Fecha valid...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtNroCamiseta.Text) || !int.TryParse(txtNroCamiseta.Text, out _))
            {
                MessageBox.Show("Debe Ingresar un Número de Camiseta valido...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboPosicion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Posicion...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrabarJugador();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (Control c in grpNuevoJugador.Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
                if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Today;
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
            }
        }

        private void GrabarJugador()
        {
            nuevoJ.Persona.NombreCompleto = txtNombreJugador.Text;
            nuevoJ.Persona.Dni = Convert.ToInt32(txtDni.Text);
            nuevoJ.Persona.FechaNac = dtpFecNac.Value;
            nuevoJ.Camiseta = Convert.ToInt32(txtNroCamiseta.Text);
            nuevoJ.Posicion.Nombre = cboPosicion.Text;
            nuevoJ.Posicion.IdPosicion = Convert.ToInt32(cboPosicion.SelectedValue);

            if (gestor.InsertarJugador(nuevoJ))
            {
                MessageBox.Show("Se registro con exito el Jugador...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se pudo registar el Jugador...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarJugadores();
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvJugadores.CurrentCell.ColumnIndex == 6)
            {
                int dni = Convert.ToInt32(dgvJugadores.Rows[e.RowIndex].Cells["ColDNI"].Value);
                dgvJugadores.Rows.RemoveAt(dgvJugadores.CurrentRow.Index);
                gestor.BorrarJugador(dni);
            }
        }

        private void txtNroCamiseta_TextChanged(object sender, EventArgs e)
        {
            int a = txtNroCamiseta.Text.Length;
            if (a > 2)
            {
                txtNroCamiseta.Text = string.Empty;
                MessageBox.Show("Debe Ingresar un Número de Camiseta valido, entre 1 y 99...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
