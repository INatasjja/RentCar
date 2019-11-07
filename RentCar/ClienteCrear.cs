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

namespace RentCar
{
    public partial class ClienteCrear : Form
    {
        private readonly ClienteService _clienteService;
        private readonly TipoPersonaService _tipoPersonaService;

        public ClienteCrear()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            _tipoPersonaService = new TipoPersonaService();
        }

        private void btnCliCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCliGuardar_Click(object sender, EventArgs e)
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
                        vnTotal += int.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
                }

                if (vnTotal % 10 == 0)
                    return true;
                else
                    return false;
            }

            if (txtCliNombre.Text=="" || txtCliApellido.Text == "" || txtCliCedula.Text == "" ||
                txtCliCredLim.Text == "" || txtCliCredCard.Text == "")
            {
                MessageBox.Show("Llene los campos faltantes.",
                "Datos necesarios vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (validaCedula(txtCliCedula.Text) == false)
            {
                MessageBox.Show("Valide su numero de cedula","",
               MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Estado de disponibilidad
                bool estado;
                if (ckbCliEstado.Checked)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }

                var cliente = new Data.Entidades.Cliente
                {
                    Id = lblCliId.Text == "Cliente ID" ? 0 : Convert.ToInt32(lblCliId.Text),
                    Nombre = txtCliNombre.Text,
                    Apellido = txtCliApellido.Text,
                    Cedula = txtCliCedula.Text,
                    LimiteCredito = Convert.ToDecimal(txtCliCredLim.Text),
                    TarjetaCredito = txtCliCredCard.Text,
                    TipoPersonaId = Convert.ToInt32(cbCliTipoCli.SelectedValue),
                    Activo = estado
                };

                _clienteService.Save(cliente);

                MessageBox.Show("El cliente ha sido agregado exitosamente.",
                "Cliente agregado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if(lblCliId.Text == "Cliente ID")
            {
                txtCliNombre.Text = "";
                txtCliApellido.Text = "";
                txtCliCedula.Text = "";
                txtCliCredLim.Text = "";
                txtCliCredCard.Text = "";
                cbCliTipoCli.SelectedItem = 0;
                ckbCliEstado.Checked = true;
            }
            else
            {
                Dispose();
                var clienteLista = new ClienteLista();
                clienteLista.Show();
            }
        }

        private void ClienteCrear_Load(object sender, EventArgs e)
        {
            cbCliTipoCli.DataSource = _tipoPersonaService.GetAll();
            cbCliTipoCli.DisplayMember = "Descripcion";
            cbCliTipoCli.ValueMember = "Id";
            cbCliTipoCli.SelectedIndex = 0;
        }

        public void ClienteCrear_Load(object sender, EventArgs e, Data.Entidades.Cliente cliente)
        {
            cbCliTipoCli.DataSource = _tipoPersonaService.GetAll();
            cbCliTipoCli.DisplayMember = "Descripcion";
            cbCliTipoCli.ValueMember = "Id";

            lblCliId.Text = cliente.Id.ToString();
            txtCliNombre.Text = cliente.Nombre;
            txtCliApellido.Text = cliente.Apellido;
            txtCliCedula.Text = cliente.Cedula;
            txtCliCredLim.Text = cliente.LimiteCredito.ToString();
            txtCliCredCard.Text = cliente.TarjetaCredito;
            cbCliTipoCli.SelectedValue = cliente.TipoPersonaId;
            ckbCliEstado.Checked = cliente.Activo;
        }

        private void txtCliCredLim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
