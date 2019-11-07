using RentCar.Data;
using RentCar.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class ClienteLista : Form
    {
        private readonly ClienteService _clienteService;
        private readonly ApplicationDbContext _context;

        public ClienteLista()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            _context = new ApplicationDbContext();
        }

        private void btnClienteLCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnClienteLEditar_Click(object sender, EventArgs e)
        {
            var row = dgvClientes.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var cliente = _context.Cliente.SingleOrDefault(x => x.Id == id);

            var clienteEditar = new ClienteCrear();

            clienteEditar.ClienteCrear_Load(sender, e, cliente);
            clienteEditar.Show();
            clienteEditar.TopMost = true;
            this.Dispose();
        }

        public void ClienteLista_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _clienteService.GetClient();
        }

        private void btnClienteLEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvClientes.SelectedCells[0].OwningRow;

            var cliente = _context.Cliente.Find(Convert.ToInt32(row.Cells[0].Value));

            _clienteService.Delete(cliente);

            ClienteLista_Load(sender, e);
        }

        private void txtClienteBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteBuscar.Text != string.Empty)
            {
                var search = _clienteService.GetClient().Where(x => x.Nombre.Contains(txtClienteBuscar.Text));
                dgvClientes.DataSource = search.ToList();
            }
            else
            {
                dgvClientes.DataSource = _clienteService.GetClient();
            }
        }
    }
}
