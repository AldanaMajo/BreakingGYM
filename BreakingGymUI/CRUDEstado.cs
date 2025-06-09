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
    }
}
