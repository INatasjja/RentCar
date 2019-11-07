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
    public partial class Inspeccionar : Form
    {
        private readonly InspeccionService _inspeccionService;
        private readonly ClienteService _clienteService;
        private readonly VehiculoService _vehiculoService;
        private readonly EmpleadoService _empleadoService;
        private readonly ApplicationDbContext _context;

        public Inspeccionar()
        {
            InitializeComponent();
            _inspeccionService = new InspeccionService();
            _clienteService = new ClienteService();
            _vehiculoService = new VehiculoService();
            _empleadoService = new EmpleadoService();
            _context = new ApplicationDbContext();
            DateTime today = DateTime.Today;
            lblInspecFechaActual.Text = today.ToString("dd/MM/yyyy");
            lblInspecEmpConectado.Text = InicioSesion.ConectedUser;
        }

        private void Inspeccionar_Load(object sender, EventArgs e)
        {
            cbInspecCliente.DataSource = _clienteService.GetAvalible();
            cbInspecCliente.DisplayMember = "Nombre";
            cbInspecCliente.ValueMember = "Id";
            cbInspecCliente.SelectedIndex = 0;
            
            cbInspecVehiculo.DataSource = _vehiculoService.GetAll();
            cbInspecVehiculo.DisplayMember = "Descripcion";
            cbInspecVehiculo.ValueMember = "Id";
            //cbInspecVehiculo.SelectedIndex = 0;
        }

        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            if (cbInspecCliente.Text == "" || cbInspecVehiculo.Text == "" || (chkInspectComb1.Checked == false && chkInspectComb2.Checked == false
                && chkInspectComb3.Checked == false && chkInspectComb4.Checked == false))
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Cantidad de Combustible
                String comb = "";

                if (chkInspectComb1.Checked)
                {
                    comb = "1/4";
                }
                else if(chkInspectComb2.Checked)
                {
                    comb = "1/2";
                }
                else if (chkInspectComb3.Checked)
                {
                    comb = "3/4";
                }
                else if (chkInspectComb4.Checked)
                {
                    comb = "Lleno";
                }

                // Estado de disponibilidad
                int estado;

                if (chkInspecEstado.Checked)
                {
                    estado = 1;
                }
                else
                {
                    estado = 2;
                }

                DateTime today = DateTime.Today;
                var empleado = _context.Empleado.Where(x => x.Nombre == lblInspecEmpConectado.Text).SingleOrDefault()?.Id;
                var inspeccion = new Data.Entidades.Inspeccion
                {
                    Id = lblInspecId.Text == "Inspeccion ID" ? 0 : Convert.ToInt32(lblInspecId.Text),
                    VehiculoId = Convert.ToInt32(cbInspecVehiculo.SelectedValue),
                    ClienteId = Convert.ToInt32(cbInspecCliente.SelectedValue),
                    EmpleadoId = Convert.ToInt32(empleado),
                    CantidadCombustible = comb,
                    EstaRayado = chkInspecRalladura.Checked,
                    TieneGomaRepuesta = chkInspectRespaldo.Checked,
                    TieneGato = chkInspectGato.Checked,
                    TieneCristalRoto = chkInspectRotCristal.Checked,
                    EstadoGomaDelanteraDerecha = chkInspecGoma1.Checked,
                    EstadoGomaDelanteraIzquierda = chkInspecGoma2.Checked,
                    EstadoGomaTraseraDerecha = chkInspecGoma3.Checked,
                    EstadoGomaTraseraIzquierda = chkInspecGoma4.Checked,
                    Fecha = today.Date,
                    EstadoId = Convert.ToInt32(estado)
                };

                _inspeccionService.Save(inspeccion);

                MessageBox.Show("Su inspeccion ha sido Guardada exitosamente.",
                 "Inspeccion Guardada",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (lblInspecId.Text == "Inspeccion ID")
            {
                cbInspecVehiculo.SelectedValue = cbInspecVehiculo.Items[0];
                cbInspecCliente.SelectedValue = cbInspecCliente.Items[0];
                chkInspecRalladura.Checked = false;
                chkInspectComb1.Checked = false;
                chkInspectComb2.Checked = false;
                chkInspectComb3.Checked = false;
                chkInspectComb4.Checked = false;
                chkInspectRespaldo.Checked = false;
                chkInspectRotCristal.Checked = false;
                chkInspecGoma1.Checked = false;
                chkInspecGoma2.Checked = false;
                chkInspecGoma3.Checked = false;
                chkInspecGoma4.Checked = false;
                chkInspecEstado.Checked = true;
            }
        }
    }
}
