using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class Vehiculos : UserControl
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void btnClienteAgregar_Click(object sender, EventArgs e)
        {
            VehiculoCrear form = new VehiculoCrear();
            form.ShowDialog();
        }

        private void btnClienteLista_Click(object sender, EventArgs e)
        {
            VehiculoLista form = new VehiculoLista();
            form.ShowDialog();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
