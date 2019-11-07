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
    public partial class Cliente : UserControl
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnClienteLista_Click(object sender, EventArgs e)
        {
            ClienteLista form = new ClienteLista();
            form.ShowDialog();
        }

        private void btnClienteAgregar_Click(object sender, EventArgs e)
        {
            ClienteCrear form = new ClienteCrear();
            form.ShowDialog();
        }
    }
}
