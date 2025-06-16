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
    public partial class CRUDServicio : Form
    {
        ServicioBL _mostrarServicio = new ServicioBL();
        ServicioEN _servicioEN = new ServicioEN();
        public CRUDServicio()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarServicio.DataSource = _mostrarServicio.MostrarServicio();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var servicio = new ServicioEN
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
            };

            // Validar campos vacíos
            if (string.IsNullOrEmpty(servicio.Nombre) || string.IsNullOrEmpty(servicio.Descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener lista de servicios existentes
            var listaServicios = _mostrarServicio.MostrarServicio(); // Método que devuelve todos los servicios

            // Validar duplicado por nombre (ignorando mayúsculas/minúsculas)
            bool yaExiste = listaServicios.Any(s => s.Nombre.Equals(servicio.Nombre, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un servicio con ese nombre. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar servicio
            _mostrarServicio.GuardarServicio(servicio);

            // Limpiar campos
            txtNombre.Clear();
            txtDescripcion.Clear();
            CargarGrid();

            MessageBox.Show("Servicio guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgMostrarServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)// evento que se dispara al hacer clic en una celda del DataGridView
        {

            if (dgMostrarServicio.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarServicio.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgMostrarServicio.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgMostrarServicio.CurrentRow.Cells["Descripcion"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, ingrese un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var servicio = new ServicioEN
            {
                Id = Convert.ToByte(txtId.Text),
            };
            if (servicio.Id <= 0)
            {
                MessageBox.Show("Por favor, ingrese un Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas Eliminar este Servicio?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                MessageBox.Show("Servicio Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mostrarServicio.EliminarServicio(servicio);
                txtId.Clear();
                CargarGrid();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var servi = new ServicioEN
            {
                Id = Convert.ToByte(txtId.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
            };
            if (string.IsNullOrEmpty(servi.Nombre) || string.IsNullOrEmpty(servi.Descripcion) || servi.Id <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar este Servicio?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {
                _mostrarServicio.ModificarServicio(servi);
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtId.Clear();
                CargarGrid();
                MessageBox.Show("Servicio modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CRUDServicio_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;   //  deshabilitar el botón de modificar al cargar el formulario
            btnEliminar.Enabled = false;    //  deshabilitar el botón de eliminar al cargar el formulario   
            txtLimpiar.Enabled = false; // Deshabilitar el botón de limpiar al cargar el formulario
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                txtLimpiar.Enabled = true; // Deshabilitar el botón de limpiar al cargar el formulario
                btnModificar.Enabled = true; // Habilitar el botón de modificar si hay un ID
                btnEliminar.Enabled = true;  // Habilitar el botón de eliminar si hay un ID
            }
            else
            {
                btnModificar.Enabled = false; // Deshabilitar el botón de modificar si no hay ID
                btnEliminar.Enabled = false;  // Deshabilitar el botón de eliminar si no hay ID
                txtLimpiar.Enabled = false; // Deshabilitar el botón de limpiar al cargar el formulario
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();

        }
    }
}
