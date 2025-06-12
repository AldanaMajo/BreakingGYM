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
            {
                UsuarioEN usuarioEN = new UsuarioEN();
                usuarioEN.IdRol = Convert.ToByte(cbIdRol.SelectedValue);
                usuarioEN.Cuenta = txtCuenta.Text.Trim();
                usuarioEN.Contrasenia = txtContrasenia.Text.Trim();

                // Validar campos vacíos
                if (string.IsNullOrEmpty(usuarioEN.Cuenta) || string.IsNullOrEmpty(usuarioEN.Contrasenia))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (usuarioEN.IdRol != 1)
                {
                    MessageBox.Show("Por favor, Seleccione un rol correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar credenciales usando la capa lógica
                UsuarioBL usuarioBL = new UsuarioBL();
                int esValido = usuarioBL.VerificarUsuarioLogin(usuarioEN);

                if (esValido == 1)
                {
                    // Abrir el formulario principal
                    InicioAdministrador frm = new InicioAdministrador();
                    frm.Show();
                    this.Hide(); // Oculta el login
                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RolBL rolBL = new RolBL();
            List<RolEN> listaRoles = rolBL.MostrarRol();

            cbIdRol.DataSource = listaRoles;
            cbIdRol.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de ClienteEN
            cbIdRol.ValueMember = "Id";        // Id debe ser una propiedad de RolEN
            cbIdRol.DropDownStyle = ComboBoxStyle.DropDownList;
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
    }
}
