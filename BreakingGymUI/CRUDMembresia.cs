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
    public partial class CRUDMembresia: Form
    {
        MembresiaEN _membresiaEN = new MembresiaEN();
        MembresiaBL _mostrarMembresia = new MembresiaBL();
        public CRUDMembresia()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarMenbresia.DataSource = _mostrarMembresia.MostrarMembresia();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cbxIdServicio.SelectedValue == null || !byte.TryParse(cbxIdServicio.SelectedValue.ToString(), out byte idServicio))
            {
                MessageBox.Show("Seleccione un servicio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar y convertir Precio
            string precioTexto = txtPrecio.Text.Trim();

            if (!int.TryParse(precioTexto, out int precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar campos de texto
            string nombre = txtNombre.Text.Trim();
            string duracion = txtDuracion.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(duracion) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener lista de membresías existentes para validar duplicados
            var listaMembresias = _mostrarMembresia.MostrarMembresia(); // Método que devuelve todas las membresías

            // Validar duplicado: que no exista ya una membresía con el mismo nombre y mismo servicio
            bool yaExiste = listaMembresias.Any(m =>
                m.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                m.IdServicio == idServicio);

            if (yaExiste)
            {
                MessageBox.Show("Ya existe una membresía con ese nombre para el servicio seleccionado. No se puede duplicar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto de membresía
            var membresia = new MembresiaEN
            {
                IdServicio = idServicio,
                Nombre = nombre,
                Duracion = duracion,
                Precio = precio,
                Descripcion = descripcion
            };

            // Guardar membresía
            _mostrarMembresia.GuardarMembresia(membresia);

            // Limpiar campos
            txtNombre.Clear();
            txtDuracion.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();

            MessageBox.Show("Membresía guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(txtId.Text.Trim(), out byte id) || id <= 0)
            {
                MessageBox.Show("Por favor, seleccione un Id válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var membre = new MembresiaEN
            {
                Id = id
            };

            // Confirmar antes de eliminar
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas eliminar esta membresía?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _mostrarMembresia.EliminarMembresia(membre);  // ✅ Ahora usas el objeto correcto
                CargarGrid();
                txtId.Clear();
                MessageBox.Show("Membresía eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar ID
            if (!byte.TryParse(txtId.Text.Trim(), out byte id) || id <= 0)
            {
                MessageBox.Show("Por favor, ingrese un Id válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar servicio seleccionado
            if (cbxIdServicio.SelectedValue == null || !byte.TryParse(cbxIdServicio.SelectedValue.ToString(), out byte idServicio))
            {
                MessageBox.Show("Seleccione un servicio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar precio
            txtPrecio.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;  // Si es MaskedTextBox
            if (!int.TryParse(txtPrecio.Text.Trim(), out int precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar campos de texto
            string nombre = txtNombre.Text.Trim();
            string duracion = txtDuracion.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(duracion) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar modificación
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar esta membresía?",
                                                "Confirmar modificación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;

            // Crear objeto
            var membresia = new MembresiaEN
            {
                Id = id,
                IdServicio = idServicio,
                Nombre = nombre,
                Duracion = duracion,
                Precio = precio,
                Descripcion = descripcion
            };

            // Guardar cambios
            _mostrarMembresia.ModificarMembresia(membresia);

            // Limpiar
            txtId.Clear();
            txtNombre.Clear();
            txtDuracion.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            CargarGrid();

            MessageBox.Show("Membresía modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMembresiaBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarMembresia.Text;
            List<MembresiaEN> membresias = MembresiaBL.BuscarMembresia(nombre);
            dgMostrarMenbresia.DataSource = membresias;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();
            txtBuscarMembresia.Clear();
        }

        private void CRUDMembresia_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;   //  Deshabilitar botón de modificar al inicio
            btnEliminar.Enabled = false;    //  Deshabilitar botón de eliminar al inicio    
            ServicioBL servicioBL = new ServicioBL();
            List<ServicioEN> listaServicios = servicioBL.MostrarServicio();

            cbxIdServicio.DataSource = listaServicios;
            cbxIdServicio.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de ClienteEN
            cbxIdServicio.ValueMember = "Id";        // Id debe ser una propiedad de RolEN
            cbxIdServicio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgMostrarMenbresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarMenbresia.SelectedRows.Count > 0)
            {
                cbxIdServicio.Text = dgMostrarMenbresia.CurrentRow.Cells["IdServicio"].Value.ToString();
                txtId.Text = dgMostrarMenbresia.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgMostrarMenbresia.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDuracion.Text = dgMostrarMenbresia.CurrentRow.Cells["Duracion"].Value.ToString();
                txtDescripcion.Text = dgMostrarMenbresia.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgMostrarMenbresia.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void txtBuscarMembresia_TextChanged(object sender, EventArgs e)
        {

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
    
}
