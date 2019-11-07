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
    public partial class Consultar : Form
    {
        private readonly ProcesoRentaService _procesoRentaService;
        public Consultar()
        {
            InitializeComponent();
            _procesoRentaService = new ProcesoRentaService();
        }
        private void Consultar_Load(object sender, EventArgs e)
        {

            dgvConsulta.DataSource = _procesoRentaService.GetConsulta();
        }

        private void btnConsultaLCancelar_Click(object sender, EventArgs e)
        {
            Dispose(); ;
        }
    }
}
