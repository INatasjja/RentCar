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
    public partial class Empleado : UserControl
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void btnClienteAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoCrear form = new EmpleadoCrear();
            form.ShowDialog();
        }

        private void btnClienteLista_Click(object sender, EventArgs e)
        {
            EmpleadoLista form = new EmpleadoLista();
            form.ShowDialog();
        }
    }
}
