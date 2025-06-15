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
        public CRUDRegistroAsistencia()
        {
            InitializeComponent();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgMostrarAsistencia(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAsistencia.SelectedRows.Count > 0) // se verifica si hay filas seleccionadas en el DataGridView
            {
                txtId.Text = dgAsistencia.CurrentRow.Cells["Id"].Value.ToString();// se obtiene el valor de la celda "Id" de la fila seleccionada
                txtIdCliente.Text = dgAsistencia.CurrentRow.Cells["IdCliente"].Value.ToString();// se obtiene el valor de la celda "Nombre" de la fila seleccionada
            }
        }
    }
}
