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

namespace RentCar
{
    public partial class VehiculoCrear : Form
    {
        private readonly VehiculoService _vehiculoService;
        private readonly TipoVehiculoService _tipoVehiculoService;
        private readonly MarcaService _marcaService;
        private readonly ModeloService _modeloService;
        private readonly TipoCombustibleService _tipoCombustibleService;
        
        public VehiculoCrear()
        {
            InitializeComponent();
            _vehiculoService = new VehiculoService();
            _tipoVehiculoService = new TipoVehiculoService();
            _marcaService = new MarcaService();
            _modeloService = new ModeloService();
            _tipoCombustibleService = new TipoCombustibleService();
        }
        
        private void VehiculoCrear_Load(object sender, EventArgs e)
        {
            cbVehiculoTipo.DataSource = _tipoVehiculoService.GetAll();
            cbVehiculoTipo.DisplayMember = "Descripcion";
            cbVehiculoTipo.ValueMember = "Id";
            cbVehiculoTipo.SelectedIndex = 0;

            cbVehiculoMarca.DataSource = _marcaService.GetAll();
            cbVehiculoMarca.DisplayMember = "Descripcion";
            cbVehiculoMarca.ValueMember = "Id";
            cbVehiculoMarca.SelectedIndex = 0;

            cbVehiculoModelo.DataSource = _modeloService.Join();
            cbVehiculoModelo.DisplayMember = "Value";
            cbVehiculoModelo.ValueMember = "Key";
            cbVehiculoModelo.SelectedIndex = 0;

            cbVehiculoCombustible.DataSource = _tipoCombustibleService.GetAll();
            cbVehiculoCombustible.DisplayMember = "Descripcion";
            cbVehiculoCombustible.ValueMember = "Id";
            cbVehiculoCombustible.SelectedIndex = 0;
        }

        public void VehiculoCrear_Load(object sender, EventArgs e, Data.Entidades.Vehiculo vehiculo)
        {
            cbVehiculoTipo.DataSource = _tipoVehiculoService.GetAll();
            cbVehiculoTipo.DisplayMember = "Descripcion";
            cbVehiculoTipo.ValueMember = "Id";

            cbVehiculoMarca.DataSource = _marcaService.GetAll();
            cbVehiculoMarca.DisplayMember = "Descripcion";
            cbVehiculoMarca.ValueMember = "Id";

            cbVehiculoModelo.DataSource = _modeloService.Join();
            cbVehiculoModelo.DisplayMember = "Value";
            cbVehiculoModelo.ValueMember = "Key";

            cbVehiculoCombustible.DataSource = _tipoCombustibleService.GetAll();
            cbVehiculoCombustible.DisplayMember = "Descripcion";
            cbVehiculoCombustible.ValueMember = "Id";

            lblVehiculoId.Text = vehiculo.Id.ToString();
            txtVehiculoDescripcion.Text = vehiculo.Descripcion;
            cbVehiculoTipo.SelectedValue = vehiculo.TipoVehiculoId;
            cbVehiculoMarca.SelectedValue = vehiculo.MarcaId;
            cbVehiculoModelo.SelectedValue = vehiculo.ModeloId;
            cbVehiculoTipo.SelectedValue = vehiculo.CombustibleId;
            txtVehiculoChasis.Text = vehiculo.NumeroChasis;
            txtVehiculoMotor.Text = vehiculo.NumeroMotor;
            txtVehiculoPlaca.Text = vehiculo.NumeroPlaca;
            ckbVehiculoEstado.Checked = Convert.ToBoolean(vehiculo.EstadoId);
        }

        private void btnVehiculoCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnVehiculoGuardar_Click(object sender, EventArgs e)
        {
            if (txtVehiculoDescripcion.Text == "" || txtVehiculoMotor.Text == "" || txtVehiculoPlaca.Text == "" ||
                txtVehiculoChasis.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Estado de disponibilidad
                int estado;
                if (ckbVehiculoEstado.Checked)
                {
                    estado = 1;
                }
                else
                {
                    estado = 2;
                }
                try
                {
                    var vehiculo = new Data.Entidades.Vehiculo
                    {
                       // Id = lblVehiculoId.Text == "Vehiculo ID" ? 0 : Convert.ToInt32(lblVehiculoId.Text),
                        Descripcion = txtVehiculoDescripcion.Text,
                        TipoVehiculoId = Convert.ToInt32(cbVehiculoTipo.SelectedValue),
                        MarcaId = Convert.ToInt32(cbVehiculoMarca.SelectedValue),
                        ModeloId = Convert.ToInt32(cbVehiculoModelo.SelectedValue),
                        CombustibleId = Convert.ToInt32(cbVehiculoCombustible.SelectedValue),
                        NumeroChasis = txtVehiculoChasis.Text,
                        NumeroMotor = txtVehiculoMotor.Text,
                        NumeroPlaca = txtVehiculoPlaca.Text,
                        EstadoId = estado
                    };

                    _vehiculoService.Save(vehiculo);

                    MessageBox.Show("El vehiculo se ha guardado exitosamente",
                    "Vehiculo guardado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex)
                {
                    MessageBox.Show("Error",
                    ex.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (lblVehiculoId.Text == "Vehiculo ID")
            {
                txtVehiculoDescripcion.Text = "";
                txtVehiculoChasis.Text = "";
                txtVehiculoMotor.Text = "";
                txtVehiculoPlaca.Text = "";
                cbVehiculoTipo.SelectedIndex = 0;
                cbVehiculoMarca.SelectedIndex = 0;
                cbVehiculoModelo.SelectedIndex = 0;
                cbVehiculoCombustible.SelectedIndex = 0;
                ckbVehiculoEstado.Checked = true;
            }
            else
            {
                Dispose();
                var vehiculoLista = new VehiculoLista();
                vehiculoLista.Show();
            }
        }

        private void btnVehiculoTipo_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoVehicloCrear form = new TipoVehicloCrear();
            form.ShowDialog();
        }

        private void btnVehiculoMarca_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MarcaVehiculoCrear form = new MarcaVehiculoCrear();
            form.ShowDialog();
        }

        private void btnVehiculoComb_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoCombustibleCrear form = new TipoCombustibleCrear();
            form.ShowDialog();
        }

        private void btnVehiculoModelo_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ModeloVehiculoCrear form = new ModeloVehiculoCrear();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblVehiculoId_Click(object sender, EventArgs e)
        {

        }
    }
}
