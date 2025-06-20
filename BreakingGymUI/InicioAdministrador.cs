﻿using BreakingGymEN;
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
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
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

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            CRUDMembresia cRUDMembresia = new CRUDMembresia();
            cRUDMembresia.ShowDialog();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            CRUDServicio cRUDServicio = new CRUDServicio();
            cRUDServicio.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDUsuario cRUDUsuario = new CRUDUsuario();
            cRUDUsuario.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDRol cRUDRol = new CRUDRol();
            cRUDRol.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRUDEstado cRUDEstado = new CRUDEstado();
            cRUDEstado.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CRUDTipoDocumento cRUDTipoDocumento = new CRUDTipoDocumento();
            cRUDTipoDocumento.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioActual.Cuenta = null;
            UsuarioActual.UsuarioLogueado = null;

            // Mostrar nuevo login limpio
            Login nuevoLogin = new Login();
            nuevoLogin.Show();

            // Cerrar el formulario actual (InicioAdministrador o InicioEmpleado)
            this.Close();

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            CRUDRegistroAsistencia cRUDRegistroAsistencia = new CRUDRegistroAsistencia();
            cRUDRegistroAsistencia.ShowDialog();
        }
    }
}
