namespace BreakingGymUI
{
    partial class CRUDCliente
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
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxIdRol = new System.Windows.Forms.ComboBox();
            this.ModificarCliente = new System.Windows.Forms.Button();
            this.EliminarCliente = new System.Windows.Forms.Button();
            this.GuardarCliente = new System.Windows.Forms.Button();
            this.dgMostrarCliente = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMostrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(627, 73);
            this.txtCelular.Mask = "0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(104, 32);
            this.txtCelular.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(542, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(49, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(556, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id Rol";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(140, 69);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.MaxLength = 8;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 32);
            this.txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(140, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 32);
            this.txtNombre.TabIndex = 22;
            // 
            // cbxIdRol
            // 
            this.cbxIdRol.DisplayMember = "Nombre";
            this.cbxIdRol.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdRol.FormattingEnabled = true;
            this.cbxIdRol.Location = new System.Drawing.Point(627, 18);
            this.cbxIdRol.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIdRol.Name = "cbxIdRol";
            this.cbxIdRol.Size = new System.Drawing.Size(82, 32);
            this.cbxIdRol.TabIndex = 21;
            this.cbxIdRol.ValueMember = "Id";
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModificarCliente.Location = new System.Drawing.Point(458, 175);
            this.ModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Size = new System.Drawing.Size(94, 60);
            this.ModificarCliente.TabIndex = 32;
            this.ModificarCliente.Text = "Modificar";
            this.ModificarCliente.UseVisualStyleBackColor = true;
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarCliente.Location = new System.Drawing.Point(276, 175);
            this.EliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(94, 60);
            this.EliminarCliente.TabIndex = 31;
            this.EliminarCliente.Text = "Eliminar";
            this.EliminarCliente.UseVisualStyleBackColor = true;
            // 
            // GuardarCliente
            // 
            this.GuardarCliente.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuardarCliente.Location = new System.Drawing.Point(99, 175);
            this.GuardarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarCliente.Name = "GuardarCliente";
            this.GuardarCliente.Size = new System.Drawing.Size(94, 60);
            this.GuardarCliente.TabIndex = 30;
            this.GuardarCliente.Text = "Guardar";
            this.GuardarCliente.UseVisualStyleBackColor = true;
            // 
            // dgMostrarCliente
            // 
            this.dgMostrarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMostrarCliente.Location = new System.Drawing.Point(54, 252);
            this.dgMostrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgMostrarCliente.Name = "dgMostrarCliente";
            this.dgMostrarCliente.RowHeadersWidth = 51;
            this.dgMostrarCliente.RowTemplate.Height = 24;
            this.dgMostrarCliente.Size = new System.Drawing.Size(528, 187);
            this.dgMostrarCliente.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(666, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Id";
            this.label5.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(688, 419);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 33;
            this.txtId.Visible = false;
            // 
            // CRUDCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ModificarCliente);
            this.Controls.Add(this.EliminarCliente);
            this.Controls.Add(this.GuardarCliente);
            this.Controls.Add(this.dgMostrarCliente);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbxIdRol);
            this.Name = "CRUDCliente";
            this.Text = "CRUDCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgMostrarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxIdRol;
        private System.Windows.Forms.Button ModificarCliente;
        private System.Windows.Forms.Button EliminarCliente;
        private System.Windows.Forms.Button GuardarCliente;
        private System.Windows.Forms.DataGridView dgMostrarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
    }
}