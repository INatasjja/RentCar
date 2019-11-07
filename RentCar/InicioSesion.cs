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
using RentaCar;
using RentCar.Service;
using RentCar.Data.Entidades;
using RentCar.Data;

namespace RentCar
{
    public partial class InicioSesion : Form
    {
        private readonly EmpleadoService _empleadoService;
        private readonly ApplicationDbContext _context;

        public InicioSesion()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
            _context = new ApplicationDbContext();
        }

        private void btnInicioCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public static string ConectedUser;
        public static bool admin;

        private void btnInicioEntrar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtInicioUsuario.Text))
            {
                MessageBox.Show("Su usuario esta vacio!!!",
                "Datos invalidos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtInicioUsuario.Focus();
            }
            else if (String.IsNullOrEmpty(txtInicioContra.Text))
            {
                MessageBox.Show("Su contraseña esta vacia!!!",
                "Datos invalidos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtInicioContra.Focus();
            }
            else
            {
                try
                {
                    var adminQuery = _context.Empleado.FirstOrDefault(u => u.Usuario == txtInicioUsuario.Text && u.Pass == txtInicioContra.Text && u.Cargo == true);
                    var normalQuery = _context.Empleado.FirstOrDefault(u => u.Usuario == txtInicioUsuario.Text && u.Pass == txtInicioContra.Text && u.Cargo == false);
          
                    if (adminQuery != null)
                    {
                        //get the user that is logged to send it to the main form
                        ConectedUser = txtInicioUsuario.Text;
                        admin = true;

                        this.Hide();
                        Main form = new Main();
                        form.Show();
                    }
                    else if (normalQuery != null)
                    {
                        //get the user that is logged to send it to the main form
                        ConectedUser = txtInicioUsuario.Text;
                        admin = false;

                        this.Hide();
                        Main form = new Main();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Su usuario y/o contraseña son incorrectos!!!",
                        "Datos invalidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtInicioUsuario.Text = "";
                        txtInicioUsuario.Focus();
                        txtInicioContra.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Exception message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void txtInicioUsuario_Click(object sender, EventArgs e)
        {
            txtInicioUsuario.Clear();
        }

        private void txtInicioContra_Click(object sender, EventArgs e)
        {
            txtInicioContra.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtInicioContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
