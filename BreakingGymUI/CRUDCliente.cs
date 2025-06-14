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
    public partial class CRUDCliente : Form
    {
        ClienteBL _clienteBL = new ClienteBL();
        ClienteEN _clienteEN = new ClienteEN();
        public CRUDCliente()
        {
            InitializeComponent();
            CargarGrid();
               
        }
        public void CargarGrid()
        {
            dgMostrarCliente.DataSource = _clienteBL.MostrarCliente();
        }
        private void ValidarNombreCuenta(object sender, KeyPressEventArgs e)
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

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteEN
            {
                IdRol = Convert.ToByte(cbxIdRol.SelectedValue),
                IdTipoDocumento = Convert.ToByte(cbxIdTipoDocumento.SelectedValue),
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Celular = txtCelular.Text.Trim(),

            };

            // Validar campos obligatorios
            if (cliente.IdRol <= 0 || cliente.IdTipoDocumento <= 0 || string.IsNullOrEmpty(cliente.Documento) || string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellido) || string.IsNullOrEmpty(cliente.Celular))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener lista de clientes existentes
            var listaClientes = _clienteBL.MostrarCliente(); // Este método debe devolver la lista completa de clientes

            // Validar duplicado (mismo Nombre + Apellido + Celular, ignorando mayúsculas/minúsculas)
            bool yaExiste = listaClientes.Any(c =>
                c.Nombre.Equals(cliente.Nombre, StringComparison.OrdinalIgnoreCase) &&
                c.Apellido.Equals(cliente.Apellido, StringComparison.OrdinalIgnoreCase) &&
                c.Celular.Equals(cliente.Celular, StringComparison.OrdinalIgnoreCase) &&
                c.Documento.Equals(cliente.Documento, StringComparison.OrdinalIgnoreCase)
            );

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un cliente con esos datos. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar cliente
            _clienteBL.GuardarCliente(cliente);

            // Limpiar campos
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            txtDocumento.Clear();

            CargarGrid();

            MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                btnEliminar.Visible = false;
                MessageBox.Show("Por favor, Seleccione un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cli = new ClienteEN
            {
                Id = Convert.ToByte(txtId.Text),
            };
            if (cli.Id <= 0)
            {
                MessageBox.Show("Por favor, Seleccione un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas eliminar este Cliente?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                _clienteBL.EliminarCliente(cli);
                txtNombre.Clear();
                txtCelular.Clear();
                txtApellido.Clear();
                txtId.Clear();
                txtDocumento.Clear();
                CargarGrid();
                MessageBox.Show("Cliente Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, Seleccione un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cliente = new ClienteEN
            {
                Id = Convert.ToByte(txtId.Text),
                IdRol = Convert.ToByte(cbxIdRol.SelectedValue),
                IdTipoDocumento = Convert.ToByte(cbxIdTipoDocumento.SelectedValue),
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Celular = txtCelular.Text,

            };
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellido) || string.IsNullOrEmpty(cliente.Celular) || cliente.IdRol <= 0 || cliente.IdTipoDocumento <= 0 || string.IsNullOrEmpty(cliente.Documento))
            {
                MessageBox.Show("Por favor, Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar este Cliente?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                _clienteBL.ModificarCliente(cliente);
                txtNombre.Clear();
                txtCelular.Clear();
                txtApellido.Clear();
                txtId.Clear();
                txtDocumento.Clear();
                CargarGrid();
                MessageBox.Show(" Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CRUDCliente_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;    // deshabilitar el botón de eliminar al cargar el formulario
            btnModificar.Enabled = false; // deshabilitar el botón de modificar al cargar el formulario
            RolBL rolBL = new RolBL();
            List<RolEN> listaRoles = rolBL.MostrarRol();

            cbxIdRol.DataSource = listaRoles;
            cbxIdRol.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de RolEN
            cbxIdRol.ValueMember = "Id";        // Id debe ser una propiedad de RolEN
            cbxIdRol.DropDownStyle = ComboBoxStyle.DropDownList;

            TipoDocumentoBL tipoDocumentoBL = new TipoDocumentoBL();
            List<TipoDocumentoEN> listaTipoDocumentos = tipoDocumentoBL.MostrarTipoDocumento();
            cbxIdTipoDocumento.DataSource = listaTipoDocumentos;
            cbxIdTipoDocumento.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de TipoDocumentoEN
            cbxIdTipoDocumento.ValueMember = "Id";        // Id debe ser una propiedad de TipoDocumentoEN 
            cbxIdTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgMostrarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarCliente.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarCliente.CurrentRow.Cells["Id"].Value.ToString();
                cbxIdRol.Text = dgMostrarCliente.CurrentRow.Cells["IdRol"].Value.ToString();
                cbxIdTipoDocumento.Text = dgMostrarCliente.CurrentRow.Cells["IdTipoDocumento"].Value.ToString();
                txtNombre.Text = dgMostrarCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgMostrarCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCelular.Text = dgMostrarCliente.CurrentRow.Cells["Celular"].Value.ToString();
                txtDocumento.Text = dgMostrarCliente.CurrentRow.Cells["Documento"].Value.ToString();

            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                btnEliminar.Enabled = true; // habilitar el botón de eliminar si hay un Id
                btnModificar.Enabled = true; // habilitar el botón de modificar si hay un Id
            }
            else
            {
                btnEliminar.Enabled = false; // deshabilitar el botón de eliminar si no hay Id
                btnModificar.Enabled = false; // deshabilitar el botón de modificar si no hay Id
            }  
        }
    }
}
