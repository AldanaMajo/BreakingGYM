namespace BreakingGymUI
{
    partial class CRUDRegistroAsistencia
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
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgAsistencia = new System.Windows.Forms.DataGridView();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.ComboBox();
            this.mostrarClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaGymDataSet9 = new BreakingGymUI.PruebaGymDataSet9();
            this.mostrarClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaGymDataSet8 = new BreakingGymUI.PruebaGymDataSet8();
            this.pruebaGymDataSet6 = new BreakingGymUI.PruebaGymDataSet6();
            this.mostrarAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarAsistenciaTableAdapter = new BreakingGymUI.PruebaGymDataSet6TableAdapters.MostrarAsistenciaTableAdapter();
            this.mostrarClienteTableAdapter = new BreakingGymUI.PruebaGymDataSet8TableAdapters.MostrarClienteTableAdapter();
            this.mostrarClienteTableAdapter1 = new BreakingGymUI.PruebaGymDataSet9TableAdapters.MostrarClienteTableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(653, 214);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 24);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id";
            this.lbId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento del cliente";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(723, 211);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 29);
            this.txtId.TabIndex = 2;
            this.txtId.Visible = false;
            // 
            // dgAsistencia
            // 
            this.dgAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsistencia.Location = new System.Drawing.Point(52, 284);
            this.dgAsistencia.Name = "dgAsistencia";
            this.dgAsistencia.Size = new System.Drawing.Size(521, 278);
            this.dgAsistencia.TabIndex = 4;
            this.dgAsistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMostrarAsistencia);
            this.dgAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMostrarAsistencia);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(143, 144);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(69, 24);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(218, 142);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(344, 29);
            this.dtpFecha.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(122, 209);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 37);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnModificar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(394, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 37);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefrescar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefrescar.Location = new System.Drawing.Point(663, 474);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 37);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(663, 417);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 37);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarFecha
            // 
            this.txtBuscarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFecha.Location = new System.Drawing.Point(599, 380);
            this.txtBuscarFecha.Name = "txtBuscarFecha";
            this.txtBuscarFecha.Size = new System.Drawing.Size(279, 29);
            this.txtBuscarFecha.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(595, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Buscar (Asistencia por fecha)";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.DataSource = this.mostrarClienteBindingSource1;
            this.txtIdCliente.DisplayMember = "Documento";
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.FormattingEnabled = true;
            this.txtIdCliente.Location = new System.Drawing.Point(344, 70);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(185, 32);
            this.txtIdCliente.TabIndex = 43;
            this.txtIdCliente.ValueMember = "Id";
            // 
            // mostrarClienteBindingSource1
            // 
            this.mostrarClienteBindingSource1.DataMember = "MostrarCliente";
            this.mostrarClienteBindingSource1.DataSource = this.pruebaGymDataSet9;
            // 
            // pruebaGymDataSet9
            // 
            this.pruebaGymDataSet9.DataSetName = "PruebaGymDataSet9";
            this.pruebaGymDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarClienteBindingSource
            // 
            this.mostrarClienteBindingSource.DataMember = "MostrarCliente";
            this.mostrarClienteBindingSource.DataSource = this.pruebaGymDataSet8;
            // 
            // pruebaGymDataSet8
            // 
            this.pruebaGymDataSet8.DataSetName = "PruebaGymDataSet8";
            this.pruebaGymDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruebaGymDataSet6
            // 
            this.pruebaGymDataSet6.DataSetName = "PruebaGymDataSet6";
            this.pruebaGymDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarAsistenciaBindingSource
            // 
            this.mostrarAsistenciaBindingSource.DataMember = "MostrarAsistencia";
            this.mostrarAsistenciaBindingSource.DataSource = this.pruebaGymDataSet6;
            // 
            // mostrarAsistenciaTableAdapter
            // 
            this.mostrarAsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarClienteTableAdapter
            // 
            this.mostrarClienteTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarClienteTableAdapter1
            // 
            this.mostrarClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.BackgroundImage = global::BreakingGymUI.Properties.Resources.flecha;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRegresar.Location = new System.Drawing.Point(779, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(108, 35);
            this.btnRegresar.TabIndex = 47;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // CRUDRegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BreakingGymUI.Properties.Resources._12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 589);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscarFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.dgAsistencia);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Name = "CRUDRegistroAsistencia";
            this.Text = "CRUDRegistroAsistencia";
            this.Load += new System.EventHandler(this.CRUDRegistroAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaGymDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarAsistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgAsistencia;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker txtBuscarFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtIdCliente;
        private System.Windows.Forms.BindingSource mostrarAsistenciaBindingSource;
        private PruebaGymDataSet6 pruebaGymDataSet6;
        private PruebaGymDataSet6TableAdapters.MostrarAsistenciaTableAdapter mostrarAsistenciaTableAdapter;
        private System.Windows.Forms.BindingSource mostrarClienteBindingSource;
        private PruebaGymDataSet8 pruebaGymDataSet8;
        private PruebaGymDataSet8TableAdapters.MostrarClienteTableAdapter mostrarClienteTableAdapter;
        private System.Windows.Forms.BindingSource mostrarClienteBindingSource1;
        private PruebaGymDataSet9 pruebaGymDataSet9;
        private PruebaGymDataSet9TableAdapters.MostrarClienteTableAdapter mostrarClienteTableAdapter1;
        private System.Windows.Forms.Button btnRegresar;
    }
}