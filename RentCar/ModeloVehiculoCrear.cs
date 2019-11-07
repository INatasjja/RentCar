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
    public partial class ModeloVehiculoCrear : Form
    {
        private readonly ModeloService _modeloService;
        private readonly MarcaService _marcaService;
        private readonly ApplicationDbContext _context;

        public ModeloVehiculoCrear()
        {
            InitializeComponent();
            _modeloService = new ModeloService();
            _marcaService = new MarcaService();
            _context = new ApplicationDbContext();
        }

        private void btnModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VehiculoCrear form = new VehiculoCrear();
            form.ShowDialog();
        }

        private void ModeloVehiculo_Load(object sender, EventArgs e)
        {
            dgvModelo.DataSource = _modeloService.GetModelo();

            cbModeloMarca.DataSource = _marcaService.GetAll();
            cbModeloMarca.DisplayMember = "Descripcion";
            cbModeloMarca.ValueMember = "Id";
            cbModeloMarca.SelectedIndex = 0;
        }

        public void ModeloVehiculo_Load(object sender, EventArgs e, Data.Entidades.Modelo modelo)
        {
            cbModeloMarca.DataSource = _marcaService.GetAll();
            cbModeloMarca.DisplayMember = "Descripcion";
            cbModeloMarca.ValueMember = "Id";

            lblModeloId.Text = modelo.Id.ToString();
            txtModeloDescripcion.Text = modelo.Descripcion;
            cbModeloMarca.SelectedValue = modelo.MarcaId;
        }

        private void btnModeloEditar_Click(object sender, EventArgs e)
        {
            var row = dgvModelo.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var modelo = _context.Modelo.SingleOrDefault(x => x.Id == id);
            
            ModeloVehiculo_Load(sender, e, modelo);
        }

        private void btnModeloGuardar_Click(object sender, EventArgs e)
        {
            if (txtModeloDescripcion.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                var modelo = new Data.Entidades.Modelo
                {
                    Id = lblModeloId.Text == "Modelo ID" ? 0 : Convert.ToInt32(lblModeloId.Text),
                    Descripcion = txtModeloDescripcion.Text,
                    MarcaId = Convert.ToInt32(cbModeloMarca.SelectedValue)
                };

                _modeloService.Save(modelo);

                MessageBox.Show("El Modelo ha sido agregado exitosamente.",
                "Modelo agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModeloVehiculo_Load(sender, e);
                lblModeloId.Text = "Modelo ID";

                this.Dispose();
                VehiculoCrear form = new VehiculoCrear();
                form.ShowDialog();
            }

            if (lblModeloId.Text == "Modelo ID")
            {
                txtModeloDescripcion.Text = "";
                cbModeloMarca.SelectedValue = cbModeloMarca.Items[0];
            }
        }

        private void btnModeloEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvModelo.SelectedCells[0].OwningRow;

            var modelo = _context.Modelo.Find(Convert.ToInt32(row.Cells[0].Value));

            _modeloService.Delete(modelo);

            ModeloVehiculo_Load(sender, e);
        }

        private void txtModeloVehiculoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtModeloVehiculoBuscar.Text != string.Empty)
            {
                var search = _modeloService.GetModelo().Where(x => x.Descripcion.Contains(txtModeloVehiculoBuscar.Text));
                dgvModelo.DataSource = search.ToList();
            }
            else
            {
                dgvModelo.DataSource = _modeloService.GetModelo();
            }
        }
    }
}
