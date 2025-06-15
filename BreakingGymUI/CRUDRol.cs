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
    public partial class CRUDRol : Form
    {
        RolBL _mostrarRol = new RolBL();
        RolEN _rolEN = new RolEN();
        public CRUDRol()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarRol.DataSource = _mostrarRol.MostrarRol();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var _rol = new RolEN
            {
                Nombre = txtNombre.Text.Trim()
            };

            // Validar campo vacío
            if (string.IsNullOrEmpty(_rol.Nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre de rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener lista de roles existentes
            var listaRoles = _mostrarRol.MostrarRol(); // Método que devuelve todos los roles

            // Validar duplicado por nombre (sin distinguir mayúsculas/minúsculas)
            bool yaExiste = listaRoles.Any(r => r.Nombre.Equals(_rol.Nombre, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un rol con ese nombre. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar rol
            _mostrarRol.GuardarRol(_rol);

            // Limpiar campo
            txtNombre.Clear();
            CargarGrid();

            MessageBox.Show("Rol guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, ingrese un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Rol = new RolEN
            {
                Id = Convert.ToByte(txtId.Text),
            };
            if (Rol != null)
            {
                if (Rol.Id <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var confirmResult = MessageBox.Show("¿Estás seguro que deseas Eliminar este Rol?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No)
                    return;
                else
                {
                    _mostrarRol.EliminarRol(Rol);
                    txtId.Clear();
                    txtNombre.Clear();
                    CargarGrid();
                    MessageBox.Show("Rol Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rol = new RolEN
            {
                Id = Convert.ToByte(txtId.Text),
                Nombre = txtNombre.Text,
            };
            if (rol != null)
            {
                if (rol.Id <= 0 || string.IsNullOrEmpty(rol.Nombre))
                {
                    MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar este Rol?",
                                              "Confirmar modificación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No)
                    return;
                else
                {
                    _mostrarRol.ModificarRol(rol);
                    txtId.Clear();
                    txtNombre.Clear();
                    CargarGrid();
                    MessageBox.Show("Rol Modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
        private void ValidarNombreRol(object sender, KeyPressEventArgs e)
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

        private void CRUDRol_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;//  deshabilitar el botón de eliminar al cargar el formulario
            btnModificar.Enabled = false; // deshabilitar el botón de modificar al cargar el formulario
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                btnEliminar.Enabled = true; // Habilitar botón eliminar si hay un Id
                btnModificar.Enabled = true; // Habilitar botón modificar si hay un Id
            }
            else
            {
                btnEliminar.Enabled = false; // Deshabilitar si no hay Id
                btnModificar.Enabled = false; // Deshabilitar si no hay Id
            }
        }

        private void dgMostrarRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarRol.SelectedRows.Count > 0) // se verifica si hay filas seleccionadas en el DataGridView
            {
                txtId.Text = dgMostrarRol.CurrentRow.Cells["Id"].Value.ToString();// se obtiene el valor de la celda "Id" de la fila seleccionada
                txtNombre.Text = dgMostrarRol.CurrentRow.Cells["Nombre"].Value.ToString();// se obtiene el valor de la celda "Nombre" de la fila seleccionada
            }
        }
    }
}
