using BreakingGymBL;
using BreakingGymEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingGymUI
{
    public partial class Login : Form
    {
        UsuarioEN pusuarioEN = new UsuarioEN();
        UsuarioBL pBL = new UsuarioBL();
        List<UsuarioEN> lisc = new List<UsuarioEN>();
        public Login()
        {

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cuenta = txtCuenta.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(cuenta) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar iniciar sesión
            UsuarioEN usuario = UsuarioBL.IniciarSesion(cuenta, contrasenia);

            if (usuario != null)
            {
                if (usuario.IdRol == 1) // Administrador
                {
                    InicioAdministrador formAdmi = new InicioAdministrador();
                    formAdmi.Show();
                    this.Hide();
                }
                // Validación correcta, redirigir según el rol
                else if (usuario.IdRol == 2) // Empleado
                {
                    InicioEmpleado formEmpleado = new InicioEmpleado();
                    formEmpleado.Show();
                    this.Hide();
                }
               
                else
                {
                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RolBL rolBL = new RolBL();
            List<RolEN> listaRoles = rolBL.MostrarRol();

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContrasenia.PasswordChar = '*';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContrasenia.PasswordChar = '\0';
        }

        private void txtCuenta_Enter(object sender, EventArgs e)
        {
            if (txtCuenta.Text == "Nombre de cuenta")
            {
                txtCuenta.Text = "";
                txtCuenta.ForeColor = Color.Black;
            }
        }

        private void txtCuenta_Leave(object sender, EventArgs e)
        {
            if (txtCuenta.Text == "")
            {
                txtCuenta.Text = "Nombre de cuenta";
                txtCuenta.ForeColor = Color.Gray;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "Contraseña")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.Black;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "Contraseña";
                txtContrasenia.ForeColor = Color.Gray;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
