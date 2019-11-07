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
using System.Globalization;

namespace RentCar
{

    public partial class EmpleadoCrear : Form
    {
        private readonly EmpleadoService _empleadoService;
        private readonly TandaLaborService _tandaLaborService;

        public EmpleadoCrear()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
            _tandaLaborService = new TandaLaborService();
            DateTime today = DateTime.Today;
            lblEmpleadoIngreso.Text = today.ToString("dd/MM/yyyy");
        }

        private void EmpleadoCrear_Load(object sender, EventArgs e)
        {
            cbEmpleadoTanda.DataSource = _tandaLaborService.GetAll();
            cbEmpleadoTanda.DisplayMember = "Descripcion";
            cbEmpleadoTanda.ValueMember = "Id";
            cbEmpleadoTanda.SelectedIndex = 0;
        }
        public void EmpleadoCrear_Load(object sender, EventArgs e, Data.Entidades.Empleado empleado)
        {
            cbEmpleadoTanda.DataSource = _tandaLaborService.GetAll();
            cbEmpleadoTanda.DisplayMember = "Descripcion";
            cbEmpleadoTanda.ValueMember = "Id";

            lblEmpleadoId.Text = empleado.Id.ToString();
            txtEmpleadoNombre.Text = empleado.Nombre;
            txtEmpleadoApellido.Text = empleado.Apellido;
            txtEmpleadoCedula.Text = empleado.Cedula;
            txtEmpleadoComision.Text = Convert.ToString(empleado.PorcientoComision);
            txtEmpleadoUsuario.Text = empleado.Usuario;
            txtEmpleadoPass.Text = empleado.Pass;
            chkClienteAdmin.Checked = empleado.Cargo;
            lblEmpleadoIngreso.Text = Convert.ToString(empleado.FechaIngreso.ToString("dd/MM/yyyy"));
            cbEmpleadoTanda.SelectedValue = empleado.TandaLaborId;
            ckbEmpleadoEstado.Checked = empleado.Activo;
        }
        private void btnEmpleadoCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
        private void btnEmpleadoGuardar_Click(object sender, EventArgs e)
        {

            bool validaCedula(string pCedula)
            {
                int vnTotal = 0;
                string vcCedula = pCedula.Replace("-", "");
                int pLongCed = vcCedula.Trim().Length;
                int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

                if (pLongCed < 11 || pLongCed > 11)
                    return false;

                for (int vDig = 1; vDig <= pLongCed; vDig++)
                {
                    int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                    if (vCalculo < 10)
                        vnTotal += vCalculo;
                    else
                        vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
                }

                if (vnTotal % 10 == 0)
                    return true;
                else
                    return false;
            }

            if (txtEmpleadoNombre.Text == "" || txtEmpleadoApellido.Text == "" || txtEmpleadoCedula.Text == ""
                || txtEmpleadoComision.Text == "" || txtEmpleadoUsuario.Text == "" || txtEmpleadoPass.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(validaCedula(txtEmpleadoCedula.Text)==false) {
                MessageBox.Show("Corrija su num de Cedula",
               "Cedula Mal",
               MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DateTime today = DateTime.Today;
                var fechaIngreso = lblEmpleadoIngreso.Text;

                // Estado de disponibilidad
                bool estado;
                if (ckbEmpleadoEstado.Checked)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                

                var empleado = new Data.Entidades.Empleado
                {
                    Id = lblEmpleadoId.Text == "Empleado ID" ? 0 : Convert.ToInt32(lblEmpleadoId.Text),
                    Nombre = txtEmpleadoNombre.Text,
                    Apellido = txtEmpleadoApellido.Text,
                    Cedula = txtEmpleadoCedula.Text,
                    PorcientoComision = Convert.ToDecimal(txtEmpleadoComision.Text),
                    Usuario = txtEmpleadoUsuario.Text,
                    Pass = txtEmpleadoPass.Text,
                    Cargo = chkClienteAdmin.Checked,
                    FechaIngreso = today.Date,
                    TandaLaborId = Convert.ToInt32(cbEmpleadoTanda.SelectedValue),
                    Activo = estado
                };

                _empleadoService.Save(empleado);
                MessageBox.Show("El empleado a sido agregado satisfactoriamente",
                "Empeado agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (lblEmpleadoId.Text == "Empleado ID")
            {
                txtEmpleadoNombre.Text = "";
                txtEmpleadoApellido.Text = "";
                txtEmpleadoCedula.Text = "";
                txtEmpleadoUsuario.Text = "";
                txtEmpleadoPass.Text = "";
                txtEmpleadoComision.Text = "";
                chkClienteAdmin.Checked = false;
                cbEmpleadoTanda.SelectedIndex = 0;
                ckbEmpleadoEstado.Checked = true;
            }
            else
            {
                Dispose();
                var empleadoLista = new EmpleadoLista();
                empleadoLista.Show();
            }
        }
        private void txtEmpleadoComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void txtEmpleadoCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
