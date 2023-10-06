using RecetasSLN.datos;
using RecetasSLN.datos.DTOs;
using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using RecetasSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultar : Form
    {        
        IServicio servicio = null;
        List<Cliente> lClientes = null;
        public FrmConsultar(FactoryImp factory)
        {
            InitializeComponent();
            servicio = factory.GetServicio();
            lClientes = servicio.GetListClientes();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            CargarCombo();
            CantidadPedidos();
        }

        private void CantidadPedidos()
        {
            lblTotal.Text = Convert.ToString(dgvPedidos.RowCount);
        }

        private void CargarCombo()
        {
            cboClientes.DataSource = lClientes;
            cboClientes.ValueMember = "id";
            cboClientes.DisplayMember = "nombreCompleto";
            cboClientes.SelectedIndex = -1;
        }

        private void CargarDgvPedidos()
        {
            dgvPedidos.Rows.Clear();
            lClientes.Clear();
            lClientes = servicio.GetListClientes();

            if (cboClientes.SelectedItem == null)
            {
                bool aux = true;
                int aux2 = 0;
                foreach (Cliente c in lClientes)
                {
                    if (c.Pedidos.Count() == 0)
                        aux = true;
                    else aux = false;
                    foreach (Pedido p in c.Pedidos)
                    {
                        if (p.FechaBaja == DateTime.MinValue)
                        {
                            dgvPedidos.Rows.Add(new object[] { p.Codigo, c.NombreCompleto, p.FechaEntrega.ToString("dd/MM/yyyy"), "Entregar", "Borrar" });
                            aux2++;
                        }
                    }
                }
                if (aux || aux2 == 0)
                    MessageBox.Show("No hay Pedidos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Cliente clienteCbo = (Cliente)cboClientes.SelectedItem;
                Cliente c = lClientes.FirstOrDefault(c1 => c1.Id.Equals(clienteCbo.Id));
                
                bool aux = false;
                int aux2 = 0;
                if (c.Pedidos.Count() == 0)
                    aux = true;
                foreach (Pedido p in c.Pedidos)
                {
                    if (p.FechaBaja == DateTime.MinValue)
                    {
                        dgvPedidos.Rows.Add(new object[] { p.Codigo, c.NombreCompleto, p.FechaEntrega.ToString("dd/MM/yyyy"), "Entregar", "Borrar" });
                        aux2++;
                    }
                }
                if (aux || aux2 == 0)
                    MessageBox.Show("Este Cliente no tiene pedidos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CantidadPedidos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDgvPedidos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente c = lClientes.FirstOrDefault(c1 => c1.NombreCompleto.Equals(dgvPedidos.CurrentRow.Cells["colCliente"].Value));
            Pedido p = c.Pedidos.FirstOrDefault(p1 => p1.Codigo.Equals(dgvPedidos.CurrentRow.Cells["colCodigo"].Value));

            if (dgvPedidos.CurrentCell.ColumnIndex == 4)
            {
                if (p.Entregado == "N")
                {
                    if (servicio.BajarEntregarPedido(p.Codigo, "entrega"))
                    {
                        MessageBox.Show("El Pedido ha sido entregado con exito.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDgvPedidos();

                    }
                    else
                        MessageBox.Show("El Pedido no ha sido entregado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Este Pedido ya ha sido entregado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (dgvPedidos.CurrentCell.ColumnIndex == 5)
            {
                //Completar...
                DialogResult r = MessageBox.Show("Seguro que desea Eliminar el Pedido?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    servicio.BajarEntregarPedido(p.Codigo, "baja");

                    CargarDgvPedidos();
                }

            }
        }
    }
}
