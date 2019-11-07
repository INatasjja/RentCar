using RentCar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panelSelector.Height = btnInicio.Height;
            panelSelector.Top = btnInicio.Top;
            inicio1.BringToFront();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            //Usuario logeado
            lblEmpleadoConectado.Text = '"' + InicioSesion.ConectedUser + '"';
            
            //Cargo del usuario
            if (InicioSesion.admin == false)
            {
                btnEmpleados.Hide();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnClientes.Height;
            panelSelector.Top = btnClientes.Top;
            cliente1.BringToFront();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnVehiculos.Height;
            panelSelector.Top = btnVehiculos.Top;
            vehiculos1.BringToFront();
        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnInspeccion.Height;
            panelSelector.Top = btnInspeccion.Top;
            Inspeccionar form = new Inspeccionar();
            form.ShowDialog();
        }

        private void btnRenta_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnRenta.Height;
            panelSelector.Top = btnRenta.Top;
            renta1.BringToFront();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnConsulta.Height;
            panelSelector.Top = btnConsulta.Top;
            Consultar form = new Consultar();
            form.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnReporte.Height;
            panelSelector.Top = btnReporte.Top;
            Reporte form = new Reporte();
            form.ShowDialog();
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnEmpleado.Height;
            panelSelector.Top = btnEmpleados.Top;
            empleado1.BringToFront();

        }

            private void btnExit_Click(object sender, EventArgs e)
        {
            var selectedOption = MessageBox.Show("Esta seguro que desea cerrar el programa?",
                "Cerrar programa", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(selectedOption == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnInicio.Height;
            panelSelector.Top = btnInicio.Top;
            inicio1.BringToFront();
        }
        private void btnEmpleados_Click ( object sender, EventArgs e)
        {
                panelSelector.Height = btnInicio.Height;
                panelSelector.Top = btnInicio.Top;
                empleado1.BringToFront();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void empleado1_Load(object sender, EventArgs e)
        {

        }

        private void lblEmpleadoConectado_Click(object sender, EventArgs e)
        {

        }

        private void renta1_Load(object sender, EventArgs e)
        {

        }

        private void inicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
