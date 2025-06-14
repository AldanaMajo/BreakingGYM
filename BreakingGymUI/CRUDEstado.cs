using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreakingGymBL;
using BreakingGymEN;

namespace BreakingGymUI
{
    public partial class CRUDEstado : Form
    {
        EstadoBL _mostrarEstado = new EstadoBL();
        EstadoEN _estadoEN = new EstadoEN();
        public CRUDEstado()
        {
            InitializeComponent();
            CargarGrid();

        }
        public void CargarGrid()
        {
            dgMostrarEstado.DataSource = _mostrarEstado.MostrarEstado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var estado = new EstadoEN
            {
                Nombre = txtEstado.Text.Trim(),
            };

            // Validar campo vacío
            if (string.IsNullOrEmpty(estado.Nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener lista de estados existentes
            var listaEstados = _mostrarEstado.MostrarEstado(); // Debe devolver la lista completa de estados

            // Validar duplicado por nombre (ignorando mayúsculas/minúsculas)
            bool yaExiste = listaEstados.Any(n => n.Nombre.Equals(estado.Nombre, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un estado con ese nombre. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar estado
            _mostrarEstado.GuardarEstado(estado);

            // Limpiar campo
            txtEstado.Clear();
            CargarGrid();

            MessageBox.Show("Estado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgMostrarEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarEstado.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarEstado.CurrentRow.Cells["Id"].Value.ToString();
                txtEstado.Text = dgMostrarEstado.CurrentRow.Cells["Nombre"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            var est = new EstadoEN
            {
                Id = Convert.ToByte(txtId.Text),
            };
            if (est.Id <= 0)
            {
                MessageBox.Show("Por favor, Seleccione un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas eliminar este Estado?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                _mostrarEstado.EliminarEstado(est);
                txtId.Clear();
                txtId.Clear();
                txtEstado.Clear();

                CargarGrid();
                MessageBox.Show("Estado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona un Id", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }
            var estado = new EstadoEN
            {
                Id = Convert.ToByte(txtId.Text),
                Nombre = txtEstado.Text,
            };
            if (estado.Id <= 0 || string.IsNullOrEmpty(estado.Nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar este Estado?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                _mostrarEstado.ModificarEstado(estado);
                txtId.Clear();
                txtEstado.Clear();
                CargarGrid();
                MessageBox.Show("Estado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CRUDEstado_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;// boton eliminar deshabilitado al inicio
            btnModificar.Enabled = false; // boton modificar deshabilitado al inicio
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
    }
}
