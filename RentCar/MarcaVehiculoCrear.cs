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
    public partial class MarcaVehiculoCrear : Form
    {
        private readonly MarcaService _marcaService;
        private readonly ApplicationDbContext _context;

        public MarcaVehiculoCrear()
        {
            InitializeComponent();
            _marcaService = new MarcaService();
            _context = new ApplicationDbContext();
        }

        private void MarcaVehiculo_Load(object sender, EventArgs e)
        {
            dgvMarca.DataSource = _marcaService.GetAll();
        }
        private void MarcaVehiculo_Load(object sender, EventArgs e, Data.Entidades.Marca marca)
        {
            lblMarcaId.Text = marca.Id.ToString();
            txtMarcaDescripcion.Text = marca.Descripcion;
        }

        private void btnMarcaGuardar_Click(object sender, EventArgs e)
        {
            if (txtMarcaDescripcion.Text=="")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                var marca = new Data.Entidades.Marca
                {
                    Id = lblMarcaId.Text == "Marca ID" ? 0 : Convert.ToInt32(lblMarcaId.Text),
                    Descripcion = txtMarcaDescripcion.Text,
                };

                _marcaService.Save(marca);

                MessageBox.Show("El Marca ha sido agregado exitosamente.",
                "Marca agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                MarcaVehiculo_Load(sender, e);
                lblMarcaId.Text = "Marca ID";

                this.Dispose();
                VehiculoCrear form = new VehiculoCrear();
                form.ShowDialog();
            }

            if (lblMarcaId.Text == "Marca ID")
            {
                txtMarcaDescripcion.Text = "";
            }
        }

        private void btnMarcaEditar_Click(object sender, EventArgs e)
        {
            var row = dgvMarca.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var marca = _context.Marca.SingleOrDefault(x => x.Id == id);
            
            MarcaVehiculo_Load(sender, e, marca);
        }

        private void btnMarcaEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvMarca.SelectedCells[0].OwningRow;

            var marca = _context.Marca.Find(Convert.ToInt32(row.Cells[0].Value));

            _marcaService.Delete(marca);

            MarcaVehiculo_Load(sender, e);
        }

        private void btnMarcaCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VehiculoCrear form = new VehiculoCrear();
            form.ShowDialog();
        }

        private void txtMarcaVehiculoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtMarcaVehiculoBuscar.Text != string.Empty)
            {
                var search = _context.Marca.Where(x => x.Descripcion.Contains(txtMarcaVehiculoBuscar.Text));
                dgvMarca.DataSource = search.ToList();
            }
            else
            {
                dgvMarca.DataSource = _context.Marca.ToList();
            }
        }

        private void lblMarcaTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
