namespace BreakingGymUI
{
    partial class CRUDMembresia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarMembresia = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnMembresiaBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgMostrarMenbresia = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.cbxIdServicio = new System.Windows.Forms.ComboBox();
            this.mostrarServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaGymDataSet1 = new BreakingGymUI.PruebaGymDataSet1();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCargarMembresia = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.mostrarServicioTableAdapter = new BreakingGymUI.PruebaGymDataSet1TableAdapters.MostrarServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgMostrarMenbresia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(709, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id";
            this.label1.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(627, 90);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Mask = "00000";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 26);
            this.txtPrecio.TabIndex = 42;
            // 
            // btnRegresar
            // 
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(941, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(103, 71);
            this.btnRegresar.TabIndex = 41;
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(736, 442);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Buscar (Nombre de membresia)";
            // 
            // txtBuscarMembresia
            // 
            this.txtBuscarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMembresia.Location = new System.Drawing.Point(692, 490);
            this.txtBuscarMembresia.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarMembresia.Name = "txtBuscarMembresia";
            this.txtBuscarMembresia.Size = new System.Drawing.Size(381, 26);
            this.txtBuscarMembresia.TabIndex = 39;
            this.txtBuscarMembresia.TextChanged += new System.EventHandler(this.txtBuscarMembresia_TextChanged);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefrescar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefrescar.Location = new System.Drawing.Point(927, 529);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 37);
            this.btnRefrescar.TabIndex = 38;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnMembresiaBuscar
            // 
            this.btnMembresiaBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMembresiaBuscar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembresiaBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMembresiaBuscar.Location = new System.Drawing.Point(697, 529);
            this.btnMembresiaBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMembresiaBuscar.Name = "btnMembresiaBuscar";
            this.btnMembresiaBuscar.Size = new System.Drawing.Size(135, 37);
            this.btnMembresiaBuscar.TabIndex = 37;
            this.btnMembresiaBuscar.Text = "Buscar";
            this.btnMembresiaBuscar.UseVisualStyleBackColor = false;
            this.btnMembresiaBuscar.Click += new System.EventHandler(this.btnMembresiaBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(406, 328);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 37);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(592, 328);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 37);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(219, 328);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 37);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgMostrarMenbresia
            // 
            this.dgMostrarMenbresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMostrarMenbresia.Location = new System.Drawing.Point(59, 423);
            this.dgMostrarMenbresia.Margin = new System.Windows.Forms.Padding(2);
            this.dgMostrarMenbresia.Name = "dgMostrarMenbresia";
            this.dgMostrarMenbresia.RowHeadersWidth = 51;
            this.dgMostrarMenbresia.RowTemplate.Height = 24;
            this.dgMostrarMenbresia.Size = new System.Drawing.Size(559, 256);
            this.dgMostrarMenbresia.TabIndex = 33;
            this.dgMostrarMenbresia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMostrarMenbresia_CellContentClick);
            this.dgMostrarMenbresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMostrarMenbresia_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(131, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(109, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Id Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(544, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Precio $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(96, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(535, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Duracion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(219, 264);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(544, 26);
            this.txtDescripcion.TabIndex = 27;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(633, 177);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuracion.MaxLength = 10;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(141, 26);
            this.txtDuracion.TabIndex = 26;
            // 
            // cbxIdServicio
            // 
            this.cbxIdServicio.DataSource = this.mostrarServicioBindingSource;
            this.cbxIdServicio.DisplayMember = "Nombre";
            this.cbxIdServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdServicio.FormattingEnabled = true;
            this.cbxIdServicio.Location = new System.Drawing.Point(219, 175);
            this.cbxIdServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIdServicio.Name = "cbxIdServicio";
            this.cbxIdServicio.Size = new System.Drawing.Size(155, 28);
            this.cbxIdServicio.TabIndex = 25;
            this.cbxIdServicio.ValueMember = "Id";
            // 
            // mostrarServicioBindingSource
            // 
            this.mostrarServicioBindingSource.DataMember = "MostrarServicio";
            this.mostrarServicioBindingSource.DataSource = this.pruebaGymDataSet1;
            // 
            // pruebaGymDataSet1
            // 
            this.pruebaGymDataSet1.DataSetName = "PruebaGymDataSet1";
            this.pruebaGymDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(217, 92);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 26);
            this.txtNombre.TabIndex = 24;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(740, 27);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 23;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnCargarMembresia
            // 
            this.btnCargarMembresia.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMembresia.Location = new System.Drawing.Point(697, 625);
            this.btnCargarMembresia.Name = "btnCargarMembresia";
            this.btnCargarMembresia.Size = new System.Drawing.Size(135, 37);
            this.btnCargarMembresia.TabIndex = 45;
            this.btnCargarMembresia.Text = "Cargar";
            this.btnCargarMembresia.UseVisualStyleBackColor = true;
            this.btnCargarMembresia.Click += new System.EventHandler(this.btnCargarMembresia_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(926, 625);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 37);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // mostrarServicioTableAdapter
            // 
            this.mostrarServicioTableAdapter.ClearBeforeFill = true;
            // 
            // CRUDMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BreakingGymUI.Properties.Resources.Cuenta__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 690);
            this.Controls.Add(this.btnCargarMembresia);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscarMembresia);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnMembresiaBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgMostrarMenbresia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.cbxIdServicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUDMembresia";
            this.Text = "CRUDMembresia";
            this.Load += new System.EventHandler(this.CRUDMembresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMostrarMenbresia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarMembresia;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnMembresiaBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgMostrarMenbresia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.ComboBox cbxIdServicio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCargarMembresia;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource mostrarServicioBindingSource;
        private PruebaGymDataSet1 pruebaGymDataSet1;
        private PruebaGymDataSet1TableAdapters.MostrarServicioTableAdapter mostrarServicioTableAdapter;
    }
}