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
    public partial class CRUDUsuario : Form
    {
        UsuarioBL _usuarioBL = new UsuarioBL();
        UsuarioEN _usuarioEN = new UsuarioEN();

        public CRUDUsuario()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarUsuario.DataSource = _usuarioBL.MostrarUsuario();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var _usuario = new UsuarioEN
            {
                IdRol = Convert.ToByte(cbxIdRol.SelectedValue),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Celular = txtCelular.Text,
                Cuenta = txtCuenta.Text,
                Contrasenia = txtContrasenia.Text
            };

            if (_usuario.IdRol <= 0 || string.IsNullOrWhiteSpace(_usuario.Nombre) || string.IsNullOrWhiteSpace(_usuario.Apellido)
                || string.IsNullOrWhiteSpace(_usuario.Celular) || string.IsNullOrEmpty(_usuario.Cuenta) || string.IsNullOrEmpty(_usuario.Contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Validación para evitar duplicados por cuenta
            var listaUsuarios = _usuarioBL.MostrarUsuario(); // Este método debe devolverte todos los usuarios existentes

            bool yaExiste = listaUsuarios.Any(u => u.Cuenta.Equals(_usuario.Cuenta, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un usuario con esa cuenta. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar si no existe
            _usuarioBL.GuardarUsuario(_usuario);

            // Limpiar campos
            txtId.Clear();
            cbxIdRol.Text = "";
            txtCuenta.Clear();
            txtContrasenia.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            CargarGrid();

            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, seleccione un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte idEliminar = Convert.ToByte(txtId.Text);

            // 🛑 Validación: No permitir eliminar usuario logueado
            if (SesionActual.UsuarioLogueado != null && idEliminar == SesionActual.UsuarioLogueado.Id)
            {
                MessageBox.Show("No puedes eliminar el usuario con el que estás logueado.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("¿Estás seguro que deseas eliminar este usuario?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;

            var usuarioEliminar = new UsuarioEN { Id = idEliminar };
            _usuarioBL.EliminarUsuario(usuarioEliminar);

            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            txtCuenta.Clear();
            txtContrasenia.Clear();

            CargarGrid();
            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, seleccione un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Usuario = new UsuarioEN
            {
                Id = Convert.ToByte(txtId.Text),
                IdRol = Convert.ToByte(cbxIdRol.SelectedValue),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Celular = txtCelular.Text,
                Cuenta = txtCuenta.Text,
                Contrasenia = txtContrasenia.Text,
            };
            if (Usuario.IdRol <= 0 || string.IsNullOrWhiteSpace(Usuario.Nombre) || string.IsNullOrWhiteSpace(Usuario.Apellido) || string.IsNullOrWhiteSpace(Usuario.Celular) || string.IsNullOrEmpty(Usuario.Cuenta) || string.IsNullOrEmpty(Usuario.Contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar este Usuario?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                _usuarioBL.ModificarUsuario(Usuario);
                txtId.Clear();
                txtContrasenia.Clear();
                txtCuenta.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCelular.Clear();
                CargarGrid();
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text;
            List<UsuarioEN> usuarios = UsuarioBL.BuscarUsuario(nombre);
            dgMostrarUsuario.DataSource = usuarios;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();
            txtBuscarNombre.Clear();
        }

        private void dgMostrarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarUsuario.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarUsuario.CurrentRow.Cells["Id"].Value.ToString();
                cbxIdRol.Text = dgMostrarUsuario.CurrentRow.Cells["IdRol"].Value.ToString();
                txtNombre.Text = dgMostrarUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgMostrarUsuario.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCelular.Text = dgMostrarUsuario.CurrentRow.Cells["Celular"].Value.ToString();
                txtCuenta.Text = dgMostrarUsuario.CurrentRow.Cells["Cuenta"].Value.ToString();
                txtContrasenia.Text = dgMostrarUsuario.CurrentRow.Cells["Contrasenia"].Value.ToString();

            }
        }
        private void ValidaTexto(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Por favor, solo escriba letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ValidaApellidoUsuario(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Por favor, solo escriba letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ValidarBuscarNombre(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Por favor, solo escriba letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void CRUDUsuario_Load(object sender, EventArgs e)
        {
            RolBL rolBL = new RolBL();
            List<RolEN> listaRoles = rolBL.MostrarRol();

            cbxIdRol.DataSource = listaRoles;
            cbxIdRol.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de RolEN
            cbxIdRol.ValueMember = "Id";        // Id debe ser una propiedad de RolEN
            cbxIdRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
