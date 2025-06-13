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
    public partial class InicioEmpleado : Form
    {
        public InicioEmpleado()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CRUDCliente cRUDCliente = new CRUDCliente();
            cRUDCliente.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CRUDInscripcion cRUDInscripcion = new CRUDInscripcion();
            cRUDInscripcion.ShowDialog();
        }

        private void InicioEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
