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
using System.Data.Entity;

namespace RentCar
{
    public partial class RentaCrear : Form
    {
        private readonly ProcesoRentaService _procesoRenta;
        private readonly ClienteService _clienteService;
        private readonly ApplicationDbContext _context;
        private readonly VehiculoService _vehiculoService;
        private readonly EstatusRentaService _estatusRentaService;
        DateTime today = DateTime.Today;

        public RentaCrear()
        {
            InitializeComponent();
            _procesoRenta = new ProcesoRentaService();
            _clienteService = new ClienteService();
            _context = new ApplicationDbContext();
            _vehiculoService = new VehiculoService();
            _estatusRentaService = new EstatusRentaService();
            lblRentaFechaActual.Text = today.ToString("dd/MM/yyyy");
            lblRentaEmpleado.Text = InicioSesion.ConectedUser;

            int DiasRentar = Convert.ToInt32(txtRentaDias.Value);
            var devolucion = DateTime.Today.AddDays(DiasRentar);
            lblRentaFechaDevolucion.Text = devolucion.ToString("dd/MM/yyyy");
        }

        private void btnCliCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RentaCrear_Load(object sender, EventArgs e)
        {
            cbRentaVehiculo.DataSource = _vehiculoService.GetAll();
            cbRentaVehiculo.DisplayMember = "Descripcion";
            cbRentaVehiculo.ValueMember = "Id";

            cbRentaCliente.DataSource = _clienteService.GetAvalible();
            cbRentaCliente.DisplayMember = "Nombre";
            cbRentaCliente.ValueMember = "Id";
            cbRentaCliente.SelectedIndex = 0;

            cbEstatusRenta.DataSource = _estatusRentaService.GetAll();
            cbEstatusRenta.DisplayMember = "Descripcion";
            cbEstatusRenta.ValueMember = "Id";
        }
        public void RentaCrear_Load(object sender, EventArgs e, Data.Entidades.ProcesoRenta renta)
        {
            cbRentaVehiculo.DataSource = _vehiculoService.GetAll();
            cbRentaVehiculo.DisplayMember = "Descripcion";
            cbRentaVehiculo.ValueMember = "Id";

            cbRentaCliente.DataSource = _clienteService.GetAvalible();
            cbRentaCliente.DisplayMember = "Descripcion";
            cbRentaCliente.ValueMember = "Id";

            cbEstatusRenta.DataSource = _estatusRentaService.GetAll();
            cbEstatusRenta.DisplayMember = "Descripcion";
            cbEstatusRenta.ValueMember = "Id";

            lblRentaId.Text = renta.Id.ToString();
            cbRentaVehiculo.SelectedValue = renta.VehiculoId;
            cbRentaCliente.SelectedValue = renta.ClienteId;
            txtRentaMonto.Text = Convert.ToString(renta.MontoPorDia);
            txtRentaDias.Text = renta.CantidadDias.ToString();
            txtRentaComentario.Text = renta.Comentario;
            txtRentaTotal.Text = renta.MontoAPagar.ToString();
            cbEstatusRenta.SelectedValue = renta.EstatusRentaId;

        }

        private void txtRentaMonto_TextChanged(object sender, EventArgs e)
        {
            if (txtRentaMonto.Text=="")
            {
                txtRentaTotal.Text = 0.ToString();
            }
            else
            {
                decimal total = Convert.ToDecimal(txtRentaMonto.Text) * Convert.ToDecimal(txtRentaDias.Value);
                txtRentaTotal.Text = Convert.ToString(total);
            }
        }

        private void txtRentaDias_ValueChanged(object sender, EventArgs e)
        {
            if (txtRentaMonto.Text == "")
            {
                txtRentaTotal.Text = 0.ToString();
            }
            else
            {
                decimal total = Convert.ToDecimal(txtRentaMonto.Text) * Convert.ToDecimal(txtRentaDias.Value);
                txtRentaTotal.Text = Convert.ToString(total);
            }

            int DiasRentar = Convert.ToInt32(txtRentaDias.Value);
            var devolucion = DateTime.Today.AddDays(DiasRentar);

            lblRentaFechaDevolucion.Text = devolucion.ToString("dd/MM/yyyy");
        }

        private void btnCliGuardar_Click(object sender, EventArgs e)
        {
            if (txtRentaMonto.Text == "" || txtRentaDias.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                var empleado = _context.Empleado.Where(x => x.Nombre == lblRentaEmpleado.Text).SingleOrDefault()?.Id;
                var procesoRenta = new Data.Entidades.ProcesoRenta
                {
                    Id = lblRentaId.Text == "Renta ID" ? 0 : Convert.ToInt32(lblRentaId.Text),
                    VehiculoId = Convert.ToInt32(cbRentaVehiculo.SelectedValue),
                    ClienteId = Convert.ToInt32(cbRentaCliente.SelectedValue),
                    EmpleadoId = Convert.ToInt32(empleado),
                    FechaRenta = today.Date,
                    FechaDevolucion = DateTime.Today.AddDays(Convert.ToInt32(txtRentaDias.Value)),
                    MontoPorDia = Convert.ToDecimal(txtRentaMonto.Text),
                    CantidadDias = Convert.ToInt32(txtRentaDias.Text),
                    MontoAPagar = Convert.ToDecimal(txtRentaTotal.Text),
                    Comentario = txtRentaComentario.Text,
                    EstatusRentaId = Convert.ToInt32(cbEstatusRenta.SelectedValue)
                };

                _procesoRenta.Save(procesoRenta);

                // Cambiar el estado del vehiculo de disponible a no disponible
                int renta = Convert.ToInt32(cbEstatusRenta.SelectedValue);
                if (renta == 1)
                {
                    int vehiculo = Convert.ToInt32(cbRentaVehiculo.SelectedValue);

                    var vehiculoEstado = _context.Vehiculo.SingleOrDefault(x => x.Id == vehiculo).EstadoId = 2;

                    _context.SaveChanges();
                }
                else
                {
                    int vehiculo = Convert.ToInt32(cbRentaVehiculo.SelectedValue);

                    var vehiculoEstado = _context.Vehiculo.SingleOrDefault(x => x.Id == vehiculo).EstadoId = 1;

                    _context.SaveChanges();
                }
                
                MessageBox.Show("La renta se ha guardado exitosamente",
                "Renta guardado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (lblRentaId.Text == "ProcesoRenta ID")
            {
                cbRentaVehiculo.SelectedIndex = 0;
                cbRentaCliente.SelectedIndex = 0;
                txtRentaMonto.Text = "";
                txtRentaDias.Text = "";
                txtRentaTotal.Text = "";
                txtRentaComentario.Text = "";
                cbEstatusRenta.SelectedIndex = 0;
            }
            else
            {
                Dispose();
                var rentaLista = new RentaLista();
                rentaLista.Show();
            }
        }

        private void txtRentaMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
