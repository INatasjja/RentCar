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
    public partial class EmpleadoLista : Form
    {
        private readonly EmpleadoService _empleadoService;
        private readonly ApplicationDbContext _context;

        public EmpleadoLista()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
            _context = new ApplicationDbContext();
        }
        
        private void EmpleadoLista_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = _empleadoService.GetEmpleado();
        }

        private void btnEmpleadoLCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEmpleadoLEditar_Click(object sender, EventArgs e)
        {
            var row = dgvEmpleados.SelectedCells[0].OwningRow;

            var id = Convert.ToInt32(row.Cells[0].Value);

            var empleado = _context.Empleado.SingleOrDefault(x => x.Id == id);

            var empleadoEditar = new EmpleadoCrear();
                
            empleadoEditar.EmpleadoCrear_Load(sender, e, empleado);
            empleadoEditar.Show();
            empleadoEditar.TopMost = true;
            this.Dispose();
        }

        private void btnEmpleadoLEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvEmpleados.SelectedCells[0].OwningRow;

            var empleado = _context.Empleado.Find(Convert.ToInt32(row.Cells[0].Value));

            _empleadoService.Delete(empleado);

            EmpleadoLista_Load(sender, e);
        }

        private void txtEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpleadoBuscar.Text != string.Empty)
            {
                var search = _empleadoService.GetEmpleado().Where(x => x.Nombre.Contains(txtEmpleadoBuscar.Text));
                dgvEmpleados.DataSource = search.ToList();
            }
            else
            {
                dgvEmpleados.DataSource = _empleadoService.GetEmpleado();
            }
        }
    }
}
