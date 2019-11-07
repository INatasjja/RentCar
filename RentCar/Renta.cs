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
    public partial class Renta : UserControl
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void btnRentarVehiculo_Click(object sender, EventArgs e)
        {
            RentaCrear form = new RentaCrear();
            form.ShowDialog();
        }

        private void btnDevolverVehiculo_Click(object sender, EventArgs e)
        {
            RentaLista form = new RentaLista();
            form.ShowDialog();
        }
    }
}
