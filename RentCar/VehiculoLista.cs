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
    public partial class VehiculoLista : Form
    {
        private readonly VehiculoService _vehiculoService;
        private readonly ApplicationDbContext _context;

        public VehiculoLista()
        {
            InitializeComponent();
            _vehiculoService = new VehiculoService();
            _context = new ApplicationDbContext();
        }
        
        private void VehiculoLista_Load(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource = _vehiculoService.GetVehiculo();
        }

        private void btnVehiculoLCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnVehiculoLEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvVehiculos.SelectedCells[0].OwningRow;

            var vehiculo = _context.Vehiculo.Find(Convert.ToInt32(row.Cells[0].Value));

            _vehiculoService.Delete(vehiculo);

            VehiculoLista_Load(sender, e);
        }

        private void btnVehiculoLEditar_Click(object sender, EventArgs e)
        {
            var row = dgvVehiculos.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var vehiculo = _context.Vehiculo.SingleOrDefault(x => x.Id == id);

            var vehiculoEditar = new VehiculoCrear();

            vehiculoEditar.VehiculoCrear_Load(sender, e, vehiculo);
            vehiculoEditar.Show();
            vehiculoEditar.TopMost = true;
            this.Dispose();
        }

        private void txtVehiculoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtVehiculoBuscar.Text != string.Empty)
            {
                var search = _vehiculoService.GetVehiculo().Where(x => x.Descripcion.Contains(txtVehiculoBuscar.Text));
                dgvVehiculos.DataSource = search.ToList();
            }
            else
            {
                dgvVehiculos.DataSource = _vehiculoService.GetVehiculo();
            }
        }
    }
}
