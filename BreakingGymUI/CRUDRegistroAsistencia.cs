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
    public partial class CRUDRegistroAsistencia : Form
    {
        RegistroAsistenciaBL _mostrarAsistencia = new RegistroAsistenciaBL();
        RegistroAsistenciaEN _AsistenciaEN = new RegistroAsistenciaEN();
        public CRUDRegistroAsistencia()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgAsistencia.DataSource = _mostrarAsistencia.MostrarAsistencia();
        }

        private void dgMostrarAsistencia(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAsistencia.SelectedRows.Count > 0) // se verifica si hay filas seleccionadas en el DataGridView
            {
                txtId.Text = dgAsistencia.CurrentRow.Cells["Id"].Value.ToString();// se obtiene el valor de la celda "Id" de la fila seleccionada
                txtIdCliente.Text = dgAsistencia.CurrentRow.Cells["IdCliente"].Value.ToString();// se obtiene el valor de la celda "Nombre" de la fila seleccionada
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.SelectedValue == null || !byte.TryParse(txtIdCliente.SelectedValue.ToString(), out byte idCliente) )
            {
                MessageBox.Show("Por favor, seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar fechas
            if (!DateTime.TryParse(dtpFecha.Text, out DateTime fechaAsistencia))
            {
                MessageBox.Show("Por favor, ingrese fechas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //

            var asis = new RegistroAsistenciaEN() { 
                IdCliente = idCliente,
                FechaAsistencia = fechaAsistencia
            };
            // Guardar inscripción
            _mostrarAsistencia.GuardarInscripcion(asis);    // esta línea guarda la asistencia en la base de datos

            MessageBox.Show("Asistencia registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGrid(); 
        
        }

        private void CRUDRegistroAsistencia_Load(object sender, EventArgs e)
        {
            ClienteBL clienteBL = new ClienteBL();
            List<ClienteEN> listaClientes = clienteBL.MostrarCliente();

            txtIdCliente.DataSource = listaClientes;
            txtIdCliente.DisplayMember = "Documento";  // Nombre debe ser una propiedad de ClienteEN
           txtIdCliente.ValueMember = "Id";        // Id debe ser una propiedad de RolEN
            txtIdCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var asis = new RegistroAsistenciaEN
            {
                Id = Convert.ToInt32(txtId.Text),
                IdCliente = Convert.ToInt32(txtIdCliente.SelectedValue),
                FechaAsistencia = dtpFecha.Value,
            };
            if (asis != null)
            {
                if (asis.Id <= 0 || asis.IdCliente <= 0)
                {
                    MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var confirmResult = MessageBox.Show("¿Estás seguro que deseas modificar esta Asistencia?",
                                              "Confirmar modificación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                    return;
                else
                {
                    _mostrarAsistencia.ModificarAsistencia(asis);
                    txtId.Clear();
                    txtIdCliente.SelectedIndex = -1; // Limpiar selección del ComboBox
                    dtpFecha.Value = DateTime.Now; // Resetear fecha a la actual
                    CargarGrid();
                    MessageBox.Show("Asistencia Modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var fecha = txtBuscarFecha.Value;
            List<RegistroAsistenciaEN> asistencias = RegistroAsistenciaBL.BuscarAsistencia(fecha.ToString("yyyy-MM-dd")); 
            dgAsistencia.DataSource = asistencias;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
