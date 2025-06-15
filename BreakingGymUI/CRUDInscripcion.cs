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
    public partial class CRUDInscripcion : Form
    {
        InscripcionBL _mostrarInscripcion = new InscripcionBL();
        InscripcionEN _inscripcionEN = new InscripcionEN();
        public CRUDInscripcion()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgMostrarInscripcion.DataSource = _mostrarInscripcion.MostrarInscripcion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbIdCliente.SelectedValue == null || !byte.TryParse(cbIdCliente.SelectedValue.ToString(), out byte idCliente) || idCliente <= 0 ||
     cbxIdMembresia.SelectedValue == null || !byte.TryParse(cbxIdMembresia.SelectedValue.ToString(), out byte idMembresia) || idMembresia <= 0 ||
     cbxIdEstado.SelectedValue == null || !byte.TryParse(cbxIdEstado.SelectedValue.ToString(), out byte idEstado) || idEstado <= 0)
            {
                MessageBox.Show("Por favor, seleccione cliente, membresía y estado válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar fechas
            if (!DateTime.TryParse(dtInscripcion.Text, out DateTime fechaInscripcion) ||
                !DateTime.TryParse(dtVencimiento.Text, out DateTime fechaVencimiento))
            {
                MessageBox.Show("Por favor, ingrese fechas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fechaVencimiento <= fechaInscripcion)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la fecha de inscripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto inscripcion
            var inscripcion = new InscripcionEN
            {
                IdCliente = idCliente,
                IdMembresia = idMembresia,
                IdEstado = idEstado,
                FechaInscripcion = fechaInscripcion,
                FechaVencimiento = fechaVencimiento,
            };

            // Validar duplicados (por ejemplo, evitar que el mismo cliente tenga la misma membresía activa)
            // Para esto necesitas obtener la lista de inscripciones y chequear
            var listaInscripciones = _mostrarInscripcion.MostrarInscripcion(); // Debe devolver todas las inscripciones

            bool yaExiste = listaInscripciones.Any(i =>
                i.IdCliente == idCliente &&
                i.IdMembresia == idMembresia &&
                i.IdEstado == idEstado // o quizá solo estado activo, depende de tu lógica
            );

            if (yaExiste)
            {
                MessageBox.Show("Este cliente ya está inscrito en esta membresía con el mismo estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar inscripción
            _mostrarInscripcion.GuardarInscripcion(inscripcion);

            MessageBox.Show("Inscripción realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(txtId.Text.Trim(), out byte id) || id <= 0)
            {
                MessageBox.Show("Por favor, seleccione un Id válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ins = new InscripcionEN
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
                _mostrarInscripcion.EliminarInscripcion(ins);  // ✅ Ahora usas el objeto correcto
                CargarGrid();
                txtId.Clear();
                MessageBox.Show("Inscripcion eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {

                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var inscripcion = new InscripcionEN
            {
                Id = Convert.ToByte(txtId.Text),
                IdCliente = Convert.ToByte(cbIdCliente.SelectedValue),
                IdMembresia = Convert.ToByte(cbxIdMembresia.SelectedValue),
                IdEstado = Convert.ToByte(cbxIdEstado.SelectedValue),
                FechaInscripcion = Convert.ToDateTime(dtInscripcion.Text),
                FechaVencimiento = Convert.ToDateTime(dtVencimiento.Text),
            };
            if (inscripcion.Id <= 0 || inscripcion.IdCliente <= 0 || inscripcion.IdMembresia <= 0 || inscripcion.IdEstado <= 0)
            {

                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar esta Inscripcion?",
                                               "Confirmar modificación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;
            else
            {

                _mostrarInscripcion.ModificarInscripcion(_inscripcionEN);
                txtId.Clear();
                MessageBox.Show("Inscripcion Modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();

            }
        }

        private void dgMostrarInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarInscripcion.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarInscripcion.CurrentRow.Cells["Id"].Value.ToString();
                cbIdCliente.Text = dgMostrarInscripcion.CurrentRow.Cells["IdCliente"].Value.ToString();
                cbxIdMembresia.Text = dgMostrarInscripcion.CurrentRow.Cells["IdMembresia"].Value.ToString();
                cbxIdEstado.Text = dgMostrarInscripcion.CurrentRow.Cells["IdEstado"].Value.ToString();
                dtInscripcion.Text = dgMostrarInscripcion.CurrentRow.Cells["FechaInscripcion"].Value.ToString();
                dtVencimiento.Text = dgMostrarInscripcion.CurrentRow.Cells["FechaVencimiento"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idCliente = txtBuscarInscripcion.Text;
            List<InscripcionEN> inscripciones = InscripcionBL.BuscarInscripcion(idCliente);
            dgMostrarInscripcion.DataSource = inscripciones;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            CargarGrid();
            txtBuscarInscripcion.Clear();
        }

        private void CRUDInscripcion_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;   // boton modificar deshabilitado al inicio
            btnEliminar.Enabled = false;    // boton eliminar deshabilitado al inicio   
            //Mostrar Cliente en Combobox
            ClienteBL clienteBL = new ClienteBL();
            List<ClienteEN> listaClientes = clienteBL.MostrarCliente();

            cbIdCliente.DataSource = listaClientes;
            cbIdCliente.DisplayMember = "Documento";  // Nombre debe ser una propiedad de ClienteEN
            cbIdCliente.ValueMember = "Id";        // Id debe ser una propiedad de RolEN
            cbIdCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            //Mostrar Membresia en Combobox 
            MembresiaBL membresiaBL = new MembresiaBL();
            List<MembresiaEN> listaMembresias = membresiaBL.MostrarMembresia();
            cbxIdMembresia.DataSource = listaMembresias;
            cbxIdMembresia.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de MembresiaEN
            cbxIdMembresia.ValueMember = "Id";        // Id debe ser una propiedad de MembresiaEN
            cbxIdMembresia.DropDownStyle = ComboBoxStyle.DropDownList;

            //Mostrar Estado en Combobox
            EstadoBL estadoBL = new EstadoBL();
            List<EstadoEN> listaEstados = estadoBL.MostrarEstado();
            cbxIdEstado.DataSource = listaEstados;
            cbxIdEstado.DisplayMember = "Nombre";  // Nombre debe ser una propiedad de EstadoEN
            cbxIdEstado.ValueMember = "Id";        // Id debe ser una propiedad de EstadoEN
            cbxIdEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                btnModificar.Enabled = true;  // Habilitar botón modificar si hay un Id
                btnEliminar.Enabled = true;   // Habilitar botón eliminar si hay un Id
            }
            else
            {
                btnModificar.Enabled = false; // Deshabilitar botón modificar si no hay Id
                btnEliminar.Enabled = false;  // Deshabilitar botón eliminar si no hay Id
            }
        }

        private void dgMostrarInscripcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMostrarInscripcion.SelectedRows.Count > 0)
            {
                txtId.Text = dgMostrarInscripcion.CurrentRow.Cells["Id"].Value.ToString();
                cbIdCliente.Text = dgMostrarInscripcion.CurrentRow.Cells["IdCliente"].Value.ToString();
                cbxIdMembresia.Text = dgMostrarInscripcion.CurrentRow.Cells["IdMembresia"].Value.ToString();
                cbxIdEstado.Text = dgMostrarInscripcion.CurrentRow.Cells["IdEstado"].Value.ToString();
                dtInscripcion.Text = dgMostrarInscripcion.CurrentRow.Cells["FechaInscripcion"].Value.ToString();
                dtVencimiento.Text = dgMostrarInscripcion.CurrentRow.Cells["FechaVencimiento"].Value.ToString();
            }
        }
    }
}
