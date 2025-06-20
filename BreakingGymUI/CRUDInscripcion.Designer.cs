﻿namespace BreakingGymUI
{
    partial class CRUDInscripcion
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
            this.cbIdCliente = new System.Windows.Forms.ComboBox();
            this.mostrarClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaGymDataSet2 = new BreakingGymUI.PruebaGymDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxIdMembresia = new System.Windows.Forms.ComboBox();
            this.mostrarMembresiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaGymDataSet3 = new BreakingGymUI.PruebaGymDataSet3();
            this.cbxIdEstado = new System.Windows.Forms.ComboBox();
            this.mostrarEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaGymDataSet4 = new BreakingGymUI.PruebaGymDataSet4();
            this.dtInscripcion = new System.Windows.Forms.DateTimePicker();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgMostrarInscripcion = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarInscripcion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mostrarClienteTableAdapter = new BreakingGymUI.PruebaGymDataSet2TableAdapters.MostrarClienteTableAdapter();
            this.mostrarMembresiaTableAdapter = new BreakingGymUI.PruebaGymDataSet3TableAdapters.MostrarMembresiaTableAdapter();
            this.mostrarEstadoTableAdapter = new BreakingGymUI.PruebaGymDataSet4TableAdapters.MostrarEstadoTableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarMembresiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMostrarInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIdCliente
            // 
            this.cbIdCliente.DataSource = this.mostrarClienteBindingSource;
            this.cbIdCliente.DisplayMember = "Documento";
            this.cbIdCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCliente.FormattingEnabled = true;
            this.cbIdCliente.Location = new System.Drawing.Point(237, 56);
            this.cbIdCliente.Name = "cbIdCliente";
            this.cbIdCliente.Size = new System.Drawing.Size(140, 29);
            this.cbIdCliente.TabIndex = 5;
            this.cbIdCliente.ValueMember = "Id";
            // 
            // mostrarClienteBindingSource
            // 
            this.mostrarClienteBindingSource.DataMember = "MostrarCliente";
            this.mostrarClienteBindingSource.DataSource = this.pruebaGymDataSet2;
            // 
            // pruebaGymDataSet2
            // 
            this.pruebaGymDataSet2.DataSetName = "PruebaGymDataSet2";
            this.pruebaGymDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // cbxIdMembresia
            // 
            this.cbxIdMembresia.DataSource = this.mostrarMembresiaBindingSource;
            this.cbxIdMembresia.DisplayMember = "Nombre";
            this.cbxIdMembresia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdMembresia.FormattingEnabled = true;
            this.cbxIdMembresia.Location = new System.Drawing.Point(237, 104);
            this.cbxIdMembresia.Name = "cbxIdMembresia";
            this.cbxIdMembresia.Size = new System.Drawing.Size(140, 29);
            this.cbxIdMembresia.TabIndex = 7;
            this.cbxIdMembresia.ValueMember = "Id";
            this.cbxIdMembresia.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // mostrarMembresiaBindingSource
            // 
            this.mostrarMembresiaBindingSource.DataMember = "MostrarMembresia";
            this.mostrarMembresiaBindingSource.DataSource = this.pruebaGymDataSet3;
            // 
            // pruebaGymDataSet3
            // 
            this.pruebaGymDataSet3.DataSetName = "PruebaGymDataSet3";
            this.pruebaGymDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxIdEstado
            // 
            this.cbxIdEstado.DataSource = this.mostrarEstadoBindingSource;
            this.cbxIdEstado.DisplayMember = "Nombre";
            this.cbxIdEstado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdEstado.FormattingEnabled = true;
            this.cbxIdEstado.Location = new System.Drawing.Point(237, 150);
            this.cbxIdEstado.Name = "cbxIdEstado";
            this.cbxIdEstado.Size = new System.Drawing.Size(140, 29);
            this.cbxIdEstado.TabIndex = 8;
            this.cbxIdEstado.ValueMember = "Id";
            // 
            // mostrarEstadoBindingSource
            // 
            this.mostrarEstadoBindingSource.DataMember = "MostrarEstado";
            this.mostrarEstadoBindingSource.DataSource = this.pruebaGymDataSet4;
            // 
            // pruebaGymDataSet4
            // 
            this.pruebaGymDataSet4.DataSetName = "PruebaGymDataSet4";
            this.pruebaGymDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtInscripcion
            // 
            this.dtInscripcion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInscripcion.Location = new System.Drawing.Point(633, 58);
            this.dtInscripcion.Name = "dtInscripcion";
            this.dtInscripcion.Size = new System.Drawing.Size(254, 29);
            this.dtInscripcion.TabIndex = 9;
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimiento.Location = new System.Drawing.Point(633, 106);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(254, 29);
            this.dtVencimiento.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(39, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 37);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgMostrarInscripcion
            // 
            this.dgMostrarInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMostrarInscripcion.Location = new System.Drawing.Point(39, 282);
            this.dgMostrarInscripcion.Name = "dgMostrarInscripcion";
            this.dgMostrarInscripcion.Size = new System.Drawing.Size(470, 150);
            this.dgMostrarInscripcion.TabIndex = 13;
            this.dgMostrarInscripcion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMostrarInscripcion_CellClick);
            this.dgMostrarInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMostrarInscripcion_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(183, 228);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 37);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModificar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(325, 228);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 37);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(653, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Buscar (Id Cliente)";
            // 
            // txtBuscarInscripcion
            // 
            this.txtBuscarInscripcion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarInscripcion.Location = new System.Drawing.Point(633, 315);
            this.txtBuscarInscripcion.Name = "txtBuscarInscripcion";
            this.txtBuscarInscripcion.Size = new System.Drawing.Size(217, 29);
            this.txtBuscarInscripcion.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(612, 374);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 37);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefrescar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefrescar.Location = new System.Drawing.Point(763, 374);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 37);
            this.btnRefrescar.TabIndex = 24;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(717, 444);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 29);
            this.txtId.TabIndex = 25;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(695, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Id";
            this.label8.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(430, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha Inscripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(430, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fecha Vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(107, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Membresia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(107, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Estado";
            // 
            // mostrarClienteTableAdapter
            // 
            this.mostrarClienteTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarMembresiaTableAdapter
            // 
            this.mostrarMembresiaTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarEstadoTableAdapter
            // 
            this.mostrarEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.BackgroundImage = global::BreakingGymUI.Properties.Resources.flecha;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRegresar.Location = new System.Drawing.Point(808, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(108, 35);
            this.btnRegresar.TabIndex = 47;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtLimpiar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLimpiar.Location = new System.Drawing.Point(374, 441);
            this.txtLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(135, 37);
            this.txtLimpiar.TabIndex = 49;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = false;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // CRUDInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BreakingGymUI.Properties.Resources.Cuenta__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 495);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarInscripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgMostrarInscripcion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtVencimiento);
            this.Controls.Add(this.dtInscripcion);
            this.Controls.Add(this.cbxIdEstado);
            this.Controls.Add(this.cbxIdMembresia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbIdCliente);
            this.Name = "CRUDInscripcion";
            this.Text = "CRUDInscripcion";
            this.Load += new System.EventHandler(this.CRUDInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarMembresiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMostrarInscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbIdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxIdMembresia;
        private System.Windows.Forms.ComboBox cbxIdEstado;
        private System.Windows.Forms.DateTimePicker dtInscripcion;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgMostrarInscripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarInscripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource mostrarClienteBindingSource;
        private PruebaGymDataSet2 pruebaGymDataSet2;
        private System.Windows.Forms.BindingSource mostrarMembresiaBindingSource;
        private PruebaGymDataSet3 pruebaGymDataSet3;
        private System.Windows.Forms.BindingSource mostrarEstadoBindingSource;
        private PruebaGymDataSet4 pruebaGymDataSet4;
        private PruebaGymDataSet2TableAdapters.MostrarClienteTableAdapter mostrarClienteTableAdapter;
        private PruebaGymDataSet3TableAdapters.MostrarMembresiaTableAdapter mostrarMembresiaTableAdapter;
        private PruebaGymDataSet4TableAdapters.MostrarEstadoTableAdapter mostrarEstadoTableAdapter;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button txtLimpiar;
    }
}