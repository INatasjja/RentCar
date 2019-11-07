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
    public partial class Reporte : Form
    {
        private readonly InspeccionService _inspeccionService;
        public Reporte()
        {
            InitializeComponent();
            _inspeccionService = new InspeccionService();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            dgvReporte.DataSource = _inspeccionService.GetReporte();
        }

        private void btnReporteLCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
