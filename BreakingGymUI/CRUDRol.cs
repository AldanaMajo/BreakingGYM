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
    }
}
