using PedidosSLN.dominio;
using PedidosSLN.Servicios;
using PedidosSLN.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PedidosSLN.presentación
{
    public partial class FrmConsultar : Form
    {
        IServicio servicio = null;
        List<Cliente> lClientes = null;
        public FrmConsultar(FactoryImp factory)
        {
            InitializeComponent();
            servicio = factory.GetServicio();
            lClientes = servicio.GetListClientes(DateTime.Now.AddDays(-30), DateTime.Now);
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
            lClientes = servicio.GetListClientes(dtpDesde.Value,dtpHasta.Value);
            bool aux = false;
            int aux2 = 0;

            if (cboClientes.SelectedItem == null) // Cargar todos los pedidos en la Dgv si no se seleccionan filtros
            {
                foreach (Cliente c in lClientes)
                {
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
                }
                if (aux || aux2 == 0)
                    MessageBox.Show("No hay Pedidos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else // Cargar los pedidos del cliente seleccionado en el ComboBox
            {
                Cliente clienteCbo = (Cliente)cboClientes.SelectedItem;
                Cliente c = lClientes.FirstOrDefault(c1 => c1.Id.Equals(clienteCbo.Id));

                if (c.Pedidos.Count() == 0)
                    aux = true;
                foreach (Pedido p in c.Pedidos)
                {
                    if (p.FechaBaja == DateTime.MinValue) // Solo se muestran en el Dgv los pedidos sin dar de baja, con la feha del ctor sin parametros
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
            // Busca coincidencia del nombre del cliente de la fila actual, en la list de Clientes
            Cliente c = lClientes.FirstOrDefault(c1 => c1.NombreCompleto.Equals(dgvPedidos.CurrentRow.Cells["colCliente"].Value));
            
            // Busca el pedido con el mismo codigo de pedido de la fila actual, en la list Pedidos de ese cliente
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
