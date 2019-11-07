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
    public partial class TipoCombustibleCrear : Form
    {
        private readonly TipoCombustibleService _tipoCombustibleService;
        private readonly ApplicationDbContext _context;

        public TipoCombustibleCrear()
        {
            InitializeComponent();
            _tipoCombustibleService = new TipoCombustibleService();
            _context = new ApplicationDbContext();
        }

        private void TipoCombustible_Load(object sender, EventArgs e)
        {
            dgvTipoCombustible.DataSource = _tipoCombustibleService.GetAll();
        }
        private void TipoCombustible_Load(object sender, EventArgs e, Data.Entidades.TipoCombustible tipoCombustible)
        {
            lblTipoCombustibleId.Text = tipoCombustible.Id.ToString();
            txtTipoCombustibleDescripcion.Text = tipoCombustible.Descripcion;
        }

        private void btnTipoCombustibleGuardar_Click(object sender, EventArgs e)
        {
            if (txtTipoCombustibleDescripcion.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                var tipoCombustible = new Data.Entidades.TipoCombustible
                {
                    Id = lblTipoCombustibleId.Text == "Comb. ID" ? 0 : Convert.ToInt32(lblTipoCombustibleId.Text),
                    Descripcion = txtTipoCombustibleDescripcion.Text,
                };

                _tipoCombustibleService.Save(tipoCombustible);

                MessageBox.Show("El tipo de Combustible ha sido agregado exitosamente.",
                "Tipo de combustible agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                TipoCombustible_Load(sender, e);
                lblTipoCombustibleId.Text = "Comb. ID";

                this.Dispose();
                VehiculoCrear form = new VehiculoCrear();
                form.ShowDialog();
            }

            if (lblTipoCombustibleId.Text == "Comb. ID")
            {
                txtTipoCombustibleDescripcion.Text = "";
            }
            else
            {
                Dispose();
                var tipoCombustibleCrear = new TipoCombustibleCrear();
                tipoCombustibleCrear.Show();
            }
        }

        private void btnTipoCombustibleEditar_Click(object sender, EventArgs e)
        {
            var row = dgvTipoCombustible.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var combustible = _context.TipoCombustible.SingleOrDefault(x => x.Id == id);
                
            TipoCombustible_Load(sender, e, combustible);
        }

        private void btnTipoCombustibleEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvTipoCombustible.SelectedCells[0].OwningRow;

            var combustible = _context.TipoCombustible.Find(Convert.ToInt32(row.Cells[0].Value));

            _tipoCombustibleService.Delete(combustible);

            TipoCombustible_Load(sender, e);
        }

        private void btnTipoCombustibleCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VehiculoCrear form = new VehiculoCrear();
            form.ShowDialog();
        }

        private void txtCombustibleBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtCombustibleBuscar.Text != string.Empty)
            {
                var search = _context.TipoCombustible.Where(x => x.Descripcion.Contains(txtCombustibleBuscar.Text));
                dgvTipoCombustible.DataSource = search.ToList();
            }
            else
            {
                dgvTipoCombustible.DataSource = _context.TipoCombustible.ToList();
            }
        }
    }
}
