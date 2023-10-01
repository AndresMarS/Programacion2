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
    public partial class FrmNuevoEquipo : Form
    {
        HelperDB gestor = null;
        Equipo oEquipo = null;
        List<Jugador> lJugadores = null;
        public FrmNuevoEquipo()
        {
            InitializeComponent();
            gestor = new HelperDB();
            oEquipo = new Equipo();
            lJugadores = new List<Jugador>();
        }

        private void FrmNuevoEquipo_Load(object sender, EventArgs e)
        {
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            DataTable dt = gestor.ConsultarTabla("SP_CONSULTAR_JUGADORES");
            cboJugadores.DataSource = dt;
            cboJugadores.ValueMember = dt.Columns[0].ColumnName;
            cboJugadores.DisplayMember = dt.Columns[1].ColumnName;
            cboJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJugadores.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar
            if (txtNombreEquipo.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El Nombre del Equipo no puede contener números...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTecnico.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El Nombre del Técnico no puede contener números...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            oEquipo.Nombre = txtNombreEquipo.Text;
            oEquipo.DirectorTecnico = txtTecnico.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
