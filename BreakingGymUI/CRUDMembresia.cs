using BreakingGymBL;
using BreakingGymEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder; // Asegúrate de tener instalada la librería QRCoder para generar códigos QR

namespace BreakingGymUI
{
    public partial class CRUDMembresia: Form
    {
        public PrintDocument printDocument = new PrintDocument();
        public MembresiaEN membresiaParaImprimir;
        MembresiaEN _membresiaEN = new MembresiaEN();
        MembresiaBL _mostrarMembresia = new MembresiaBL();
        public CRUDMembresia()
        {
            InitializeComponent();
            printDocument.PrintPage += printDocument1_PrintPage;
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
            if (membresiaParaImprimir == null || string.IsNullOrEmpty(membresiaParaImprimir.Nombre))
            {
                e.Graphics.DrawString("No hay datos para imprimir.",
                    new Font("Times New Roman", 12),
                    Brushes.Black,
                    e.MarginBounds.Left,
                    e.MarginBounds.Top);
                return;
            }

            Graphics g = e.Graphics;
            int y = e.MarginBounds.Top;

            // ----- IMAGEN (LOGO) EN LA PARTE SUPERIOR CENTRADA -----
            Image logito = Properties.Resources.LogitoGod; // Asegúrate de que está en Resources
            int logoWidth = 100;  // Tamaño deseado del logo
            int logoHeight = 100;
            int logoX = e.MarginBounds.Left + (e.MarginBounds.Width - logoWidth) / 2;
            g.DrawImage(logito, new Rectangle(logoX, y, logoWidth, logoHeight));
            y += logoHeight + 10; // Espacio debajo del logo

            // ----- TÍTULO EN DOS LÍNEAS CENTRADAS -----
            string titulo1 = "BREAKING GYM";
            string titulo2 = "TICKET MEMBRESÍA";

            Font fontTitulo1 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font fontTitulo2 = new Font("Times New Roman", 12, FontStyle.Bold);

            SizeF sizeTitulo1 = g.MeasureString(titulo1, fontTitulo1);
            float xTitulo1 = e.MarginBounds.Left + (e.MarginBounds.Width - sizeTitulo1.Width) / 2;
            g.DrawString(titulo1, fontTitulo1, Brushes.Black, xTitulo1, y);
            y += (int)sizeTitulo1.Height + 5;

            SizeF sizeTitulo2 = g.MeasureString(titulo2, fontTitulo2);
            float xTitulo2 = e.MarginBounds.Left + (e.MarginBounds.Width - sizeTitulo2.Width) / 2;
            g.DrawString(titulo2, fontTitulo2, Brushes.Black, xTitulo2, y);
            y += (int)sizeTitulo2.Height + 20;

            // ----- DATOS CENTRADOS -----
            string[] datos =
            {
        $"Numero de membresia: {membresiaParaImprimir.Id}",
        $"Membresia: {membresiaParaImprimir.Nombre}",
        $"Servicio ID: {membresiaParaImprimir.IdServicio}",
        $"Precio: ${membresiaParaImprimir.Precio}",
        $"Duración: {membresiaParaImprimir.Duracion}",
        $"Descripción: {membresiaParaImprimir.Descripcion}"
    };

            foreach (var dato in datosConFuente)
            {
                SizeF size = g.MeasureString(dato.Texto, dato.Fuente);
                float x = e.MarginBounds.Left + (e.MarginBounds.Width - size.Width) / 2;
                g.DrawString(dato.Texto, dato.Fuente, dato.Color, x, y);
                y += (int)size.Height + 10;
            }

            // ----- CÓDIGO QR CENTRADO -----
            string contenidoQR = string.Join("\n", datosConFuente.Select(d => d.Texto));

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(contenidoQR, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5); // Escala del QR

            int qrSize = 120;
            int qrX = e.MarginBounds.Left + (e.MarginBounds.Width - qrSize) / 2;
            g.DrawImage(qrCodeImage, new Rectangle(qrX, y, qrSize, qrSize));
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (membresiaParaImprimir == null)
            {
                MessageBox.Show("Cargue primero una membresía.");
                return;
            }

            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            txtId.Clear();
            txtNombre.Clear();
            txtDuracion.Clear();
            cbxIdServicio.SelectedIndex = -1; // Limpiar selección del ComboBox
            txtPrecio.Clear();
            txtDescripcion.Clear();

        }

        private void btnCargarMembresia_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                membresiaParaImprimir = MembresiaBL.ObtenerMembresiaPorId(id);

                if (membresiaParaImprimir != null && !string.IsNullOrEmpty(membresiaParaImprimir.Nombre))
                {
                    MessageBox.Show("Membresía cargada correctamente para imprimir.");
                }
                else
                {
                    MessageBox.Show("No se encontró una membresía con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
    
}
