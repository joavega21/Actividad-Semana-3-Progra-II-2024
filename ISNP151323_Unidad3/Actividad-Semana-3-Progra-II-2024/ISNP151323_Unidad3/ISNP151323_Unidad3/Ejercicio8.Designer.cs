namespace ISNP151323_Unidad3
{
    partial class Ejercicio8
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
            this.dgvDatosCumple = new System.Windows.Forms.DataGridView();
            this.txtBuscaCumple = new System.Windows.Forms.TextBox();
            this.lblBuscarCumple = new System.Windows.Forms.Label();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblNavegacion = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.IdCumple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCumple)).BeginInit();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosCumple
            // 
            this.dgvDatosCumple.AllowUserToAddRows = false;
            this.dgvDatosCumple.AllowUserToDeleteRows = false;
            this.dgvDatosCumple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCumple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCumple,
            this.Registro,
            this.Nombre,
            this.Telefono,
            this.Fecha});
            this.dgvDatosCumple.Location = new System.Drawing.Point(596, 78);
            this.dgvDatosCumple.Name = "dgvDatosCumple";
            this.dgvDatosCumple.ReadOnly = true;
            this.dgvDatosCumple.RowHeadersWidth = 51;
            this.dgvDatosCumple.RowTemplate.Height = 24;
            this.dgvDatosCumple.Size = new System.Drawing.Size(567, 231);
            this.dgvDatosCumple.TabIndex = 30;
            this.dgvDatosCumple.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosCumple_CellClick);
            // 
            // txtBuscaCumple
            // 
            this.txtBuscaCumple.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCumple.Location = new System.Drawing.Point(843, 24);
            this.txtBuscaCumple.Name = "txtBuscaCumple";
            this.txtBuscaCumple.Size = new System.Drawing.Size(320, 30);
            this.txtBuscaCumple.TabIndex = 29;
            this.txtBuscaCumple.TextChanged += new System.EventHandler(this.txtBuscaCumple_TextChanged);
            this.txtBuscaCumple.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaCumple_KeyUp);
            // 
            // lblBuscarCumple
            // 
            this.lblBuscarCumple.AutoSize = true;
            this.lblBuscarCumple.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCumple.Location = new System.Drawing.Point(602, 27);
            this.lblBuscarCumple.Name = "lblBuscarCumple";
            this.lblBuscarCumple.Size = new System.Drawing.Size(242, 23);
            this.lblBuscarCumple.TabIndex = 28;
            this.lblBuscarCumple.Text = "Nombre del cumpleañero: ";
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnModificiar);
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Location = new System.Drawing.Point(596, 339);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(556, 79);
            this.grbEdicion.TabIndex = 27;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(413, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 39);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificiar
            // 
            this.btnModificiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificiar.Location = new System.Drawing.Point(221, 26);
            this.btnModificiar.Name = "btnModificiar";
            this.btnModificiar.Size = new System.Drawing.Size(116, 39);
            this.btnModificiar.TabIndex = 21;
            this.btnModificiar.Text = "Modificar";
            this.btnModificiar.UseVisualStyleBackColor = true;
            this.btnModificiar.Click += new System.EventHandler(this.btnModificiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(19, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 39);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Controls.Add(this.lblNavegacion);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Location = new System.Drawing.Point(12, 339);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(556, 79);
            this.grbNavegacion.TabIndex = 26;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(450, 26);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(59, 39);
            this.btnUltimo.TabIndex = 19;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(363, 26);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(59, 39);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(121, 26);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(59, 39);
            this.btnAnterior.TabIndex = 17;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblNavegacion
            // 
            this.lblNavegacion.AutoSize = true;
            this.lblNavegacion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavegacion.Location = new System.Drawing.Point(236, 30);
            this.lblNavegacion.Name = "lblNavegacion";
            this.lblNavegacion.Size = new System.Drawing.Size(83, 27);
            this.lblNavegacion.TabIndex = 16;
            this.lblNavegacion.Text = "X de N";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(39, 26);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(59, 39);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtFecha);
            this.grbDatos.Controls.Add(this.txtTelefono);
            this.grbDatos.Controls.Add(this.lblFecha);
            this.grbDatos.Controls.Add(this.lblTelefono);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.txtRegistro);
            this.grbDatos.Controls.Add(this.lblRegistro);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(12, 24);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(556, 285);
            this.grbDatos.TabIndex = 25;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(14, 231);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 23);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Nacimiento: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(14, 167);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(96, 23);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(167, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 23);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(167, 31);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(160, 30);
            this.txtRegistro.TabIndex = 1;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(14, 34);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(84, 23);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(167, 164);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 30);
            this.txtTelefono.TabIndex = 29;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(167, 228);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(160, 30);
            this.txtFecha.TabIndex = 30;
            // 
            // IdCumple
            // 
            this.IdCumple.DataPropertyName = "IdCumple";
            this.IdCumple.HeaderText = "IdCumple";
            this.IdCumple.MinimumWidth = 6;
            this.IdCumple.Name = "IdCumple";
            this.IdCumple.ReadOnly = true;
            this.IdCumple.Visible = false;
            this.IdCumple.Width = 125;
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "Registro";
            this.Registro.HeaderText = "Registro";
            this.Registro.MinimumWidth = 6;
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Width = 90;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 90;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.dgvDatosCumple);
            this.Controls.Add(this.txtBuscaCumple);
            this.Controls.Add(this.lblBuscarCumple);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Name = "Ejercicio8";
            this.Text = "Ejercicio8";
            this.Load += new System.EventHandler(this.Ejercicio8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCumple)).EndInit();
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosCumple;
        private System.Windows.Forms.TextBox txtBuscaCumple;
        private System.Windows.Forms.Label lblBuscarCumple;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblNavegacion;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCumple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}