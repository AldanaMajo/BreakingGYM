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
    public partial class CRUDTipoDocumento : Form
    {
        TipoDocumentoBL _mostrarTipoDocumento = new TipoDocumentoBL();
        TipoDocumentoEN _tipoDocumentoEN = new TipoDocumentoEN();
        public CRUDTipoDocumento()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarTipoDocumento.DataSource = _mostrarTipoDocumento.MostrarTipoDocumento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var tipoDocumento = new TipoDocumentoEN
            {
                Nombre = txtNombre.Text.Trim(),
            };

            // Validar campo vacío
            if (string.IsNullOrEmpty(tipoDocumento.Nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener lista de estados existentes
            var listaTipoDocumentos = _mostrarTipoDocumento.MostrarTipoDocumento(); // Debe devolver la lista completa de estados

            // Validar duplicado por nombre (ignorando mayúsculas/minúsculas)
            bool yaExiste = listaTipoDocumentos.Any(n => n.Nombre.Equals(tipoDocumento.Nombre, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un estado con ese nombre. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar estado
            _mostrarTipoDocumento.GuardarTipoDocumento(tipoDocumento);

            // Limpiar campo
            txtNombre.Clear();
            CargarGrid();

            MessageBox.Show("Tipo Documento guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona un ID.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }
            var docu = new TipoDocumentoEN
            {
                Id = Convert.ToByte(txtId.Text),
            };
            if (docu.Id <= 0)
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
                _mostrarTipoDocumento.EliminarTipoDocumento(docu);
                txtId.Clear();
                txtNombre.Clear();
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
            var docu = new TipoDocumentoEN
            {
                Id = Convert.ToByte(txtId.Text),
                Nombre = txtNombre.Text,
            };
            if (docu.Id <= 0 || string.IsNullOrEmpty(docu.Nombre))
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
                _mostrarTipoDocumento.ModificarTipoDocumento(docu);
                txtId.Clear();
                txtNombre.Clear();
                CargarGrid();
                MessageBox.Show("Estado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgMostrarTipoDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarTipoDocumento.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarTipoDocumento.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgMostrarTipoDocumento.CurrentRow.Cells["Nombre"].Value.ToString();
            }
        }

        private void CRUDTipoDocumento_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;   //      Deshabilitar el botón de modificar al cargar el formulario  
            btnEliminar.Enabled = false;    //      Deshabilitar el botón de eliminar al cargar el formulario   
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtId.Text))
            {
                btnModificar.Enabled = true;   //      Habilitar el botón de modificar al ingresar un Id
                btnEliminar.Enabled = true;    //      Habilitar el botón de eliminar al ingresar un Id
            }
            else
            {
                btnModificar.Enabled = false;  //      Deshabilitar el botón de modificar si no hay Id
                btnEliminar.Enabled = false;   //      Deshabilitar el botón de eliminar si no hay Id
            }
        }
    }
}
