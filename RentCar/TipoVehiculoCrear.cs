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
using RentCar.Data.Entidades;
using RentCar.Data;

namespace RentCar
{
    public partial class TipoVehicloCrear : Form
    {
        
        private readonly TipoVehiculoService _tipoVehiculoService;
        private readonly ApplicationDbContext _context;

        public TipoVehicloCrear()
        {
            InitializeComponent();
            _tipoVehiculoService = new TipoVehiculoService();
            _context = new ApplicationDbContext();
        }
        private void TipoVehicloCrear_Load(object sender, EventArgs e)
        {
            dgvTipoVehiculo.DataSource = _tipoVehiculoService.GetAll();
        }
        
        private void TipoVehicloCrear_Load(object sender, EventArgs e, Data.Entidades.TipoVehiculo tipoVehiculo)
        {
            lblTipoVehiculoId.Text = tipoVehiculo.Id.ToString();
            txtTipoVehiculoDescripcion.Text = tipoVehiculo.Descripcion;
        }

        private void btnTipoVehiculoGuardar_Click(object sender, EventArgs e)
        {
            if (txtTipoVehiculoDescripcion.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                var tipoVehiculo = new Data.Entidades.TipoVehiculo
                {
                    Id = lblTipoVehiculoId.Text == "Tip. Vehiculo ID" ? 0 : Convert.ToInt32(lblTipoVehiculoId.Text),
                    Descripcion = txtTipoVehiculoDescripcion.Text,
                };

                _tipoVehiculoService.Save(tipoVehiculo);
                
                MessageBox.Show("El tipo de vehiculo ha sido agregado exitosamente.",
                "Tipo de vehiculo agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                TipoVehicloCrear_Load(sender, e);
                lblTipoVehiculoId.Text = "Tip. Vehiculo ID";

                this.Dispose();
                VehiculoCrear form = new VehiculoCrear();
                form.ShowDialog();
            }

            if (lblTipoVehiculoId.Text == "Tip. Vehiculo ID")
            {
                txtTipoVehiculoDescripcion.Text = "";
            }
        }

        private void btnTipoVehiculoEditar_Click(object sender, EventArgs e)
        {
            var row = dgvTipoVehiculo.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var tipoVehiculo = _context.TipoVehiculo.SingleOrDefault(x => x.Id == id);

            TipoVehicloCrear_Load(sender, e, tipoVehiculo);
        }

        private void btnTipoVehiculoEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvTipoVehiculo.SelectedCells[0].OwningRow;

            var tipoVehiculo = _context.TipoVehiculo.Find(Convert.ToInt32(row.Cells[0].Value));

            _tipoVehiculoService.Delete(tipoVehiculo);

            TipoVehicloCrear_Load(sender, e);
        }

        private void btnTipoVehiculoCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VehiculoCrear form = new VehiculoCrear();
            form.ShowDialog();
        }

        private void txtTipoVehiculoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtTipoVehiculoBuscar.Text != string.Empty)
            {
                var search = _context.TipoVehiculo.Where(x => x.Descripcion.Contains(txtTipoVehiculoBuscar.Text));
                dgvTipoVehiculo.DataSource = search.ToList();
            }
            else
            {
                dgvTipoVehiculo.DataSource = _context.TipoVehiculo.ToList();
            }
        }
    }
}
