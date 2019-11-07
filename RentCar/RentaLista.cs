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
    public partial class RentaLista : Form
    {
        private readonly ProcesoRentaService _procesoRentaService;
        private readonly ApplicationDbContext _context;

        public RentaLista()
        {
            InitializeComponent();
            _procesoRentaService = new ProcesoRentaService();
            _context = new ApplicationDbContext();
        }

        private void RentaLista_Load(object sender, EventArgs e)
        {
            dgvRenta.DataSource = _procesoRentaService.GetRenta();
        }

        private void btnRentaLEditar_Click(object sender, EventArgs e)
        {
            var row = dgvRenta.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var renta = _context.ProcesoRenta.SingleOrDefault(x => x.Id == id);

            var rentaEditar = new RentaCrear();

            rentaEditar.RentaCrear_Load(sender, e, renta);
            rentaEditar.Show();
            rentaEditar.TopMost = true;
            this.Dispose();
        }

        private void btnRentaLEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvRenta.SelectedCells[0].OwningRow;

            var renta = _context.ProcesoRenta.Find(Convert.ToInt32(row.Cells[0].Value));

            _procesoRentaService.Delete(renta);

            RentaLista_Load(sender, e);
        }

        private void btnRentaLCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtRentaBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtRentaBuscar.Text != string.Empty)
            {
               //Se filtra por comentario, buscar la
               //forma de filtar por los demas campos
               var search = _procesoRentaService.GetRenta().Where(x => x.Comentario.Contains(txtRentaBuscar.Text));
               dgvRenta.DataSource = search.ToList();
            }
            else
            {
                dgvRenta.DataSource = _procesoRentaService.GetRenta();
            }
        }
    }
}
