namespace ISNP151323_Unidad3
{
    partial class Ejercicio4
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
            this.dgvDatosPelicula = new System.Windows.Forms.DataGridView();
            this.IdPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaPelicula = new System.Windows.Forms.TextBox();
            this.lblBuscarPelicula = new System.Windows.Forms.Label();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNumPelicula = new System.Windows.Forms.TextBox();
            this.lblNumPelicula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPelicula)).BeginInit();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosPelicula
            // 
            this.dgvDatosPelicula.AllowUserToAddRows = false;
            this.dgvDatosPelicula.AllowUserToDeleteRows = false;
            this.dgvDatosPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPelicula,
            this.NoPelicula,
            this.Titulo,
            this.Formato,
            this.Genero,
            this.Cantidad});
            this.dgvDatosPelicula.Location = new System.Drawing.Point(596, 77);
            this.dgvDatosPelicula.Name = "dgvDatosPelicula";
            this.dgvDatosPelicula.ReadOnly = true;
            this.dgvDatosPelicula.RowHeadersWidth = 51;
            this.dgvDatosPelicula.RowTemplate.Height = 24;
            this.dgvDatosPelicula.Size = new System.Drawing.Size(567, 231);
            this.dgvDatosPelicula.TabIndex = 24;
            this.dgvDatosPelicula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosPelicula_CellClick);
            // 
            // IdPelicula
            // 
            this.IdPelicula.DataPropertyName = "IdPelicula";
            this.IdPelicula.HeaderText = "IdPelicula";
            this.IdPelicula.MinimumWidth = 6;
            this.IdPelicula.Name = "IdPelicula";
            this.IdPelicula.ReadOnly = true;
            this.IdPelicula.Visible = false;
            this.IdPelicula.Width = 125;
            // 
            // NoPelicula
            // 
            this.NoPelicula.DataPropertyName = "NoPelicula";
            this.NoPelicula.HeaderText = "NoPelicula";
            this.NoPelicula.MinimumWidth = 6;
            this.NoPelicula.Name = "NoPelicula";
            this.NoPelicula.ReadOnly = true;
            this.NoPelicula.Width = 90;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 150;
            // 
            // Formato
            // 
            this.Formato.DataPropertyName = "Formato";
            this.Formato.HeaderText = "Formato";
            this.Formato.MinimumWidth = 6;
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            this.Formato.Width = 90;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 90;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // txtBuscaPelicula
            // 
            this.txtBuscaPelicula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPelicula.Location = new System.Drawing.Point(788, 23);
            this.txtBuscaPelicula.Name = "txtBuscaPelicula";
            this.txtBuscaPelicula.Size = new System.Drawing.Size(320, 30);
            this.txtBuscaPelicula.TabIndex = 23;
            this.txtBuscaPelicula.TextChanged += new System.EventHandler(this.txtBuscaPelicula_TextChanged);
            this.txtBuscaPelicula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaPelicula_KeyUp);
            // 
            // lblBuscarPelicula
            // 
            this.lblBuscarPelicula.AutoSize = true;
            this.lblBuscarPelicula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPelicula.Location = new System.Drawing.Point(592, 26);
            this.lblBuscarPelicula.Name = "lblBuscarPelicula";
            this.lblBuscarPelicula.Size = new System.Drawing.Size(190, 23);
            this.lblBuscarPelicula.TabIndex = 22;
            this.lblBuscarPelicula.Text = "Nombre de pelicula: ";
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnSalir);
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnModificiar);
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Location = new System.Drawing.Point(596, 338);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(556, 79);
            this.grbEdicion.TabIndex = 21;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(434, 26);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 39);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(296, 26);
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
            this.btnModificiar.Location = new System.Drawing.Point(158, 26);
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
            this.grbNavegacion.Location = new System.Drawing.Point(12, 338);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(556, 79);
            this.grbNavegacion.TabIndex = 20;
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
            this.grbDatos.Controls.Add(this.txtCantidad);
            this.grbDatos.Controls.Add(this.lblCantidad);
            this.grbDatos.Controls.Add(this.cmbGenero);
            this.grbDatos.Controls.Add(this.lblGenero);
            this.grbDatos.Controls.Add(this.cmbFormato);
            this.grbDatos.Controls.Add(this.lblFormato);
            this.grbDatos.Controls.Add(this.txtTitulo);
            this.grbDatos.Controls.Add(this.lblTitulo);
            this.grbDatos.Controls.Add(this.txtNumPelicula);
            this.grbDatos.Controls.Add(this.lblNumPelicula);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(12, 23);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(556, 285);
            this.grbDatos.TabIndex = 19;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(167, 216);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(160, 30);
            this.txtCantidad.TabIndex = 30;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(14, 219);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 23);
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Comedia",
            "Ciencia Ficcion",
            "Infantiles"});
            this.cmbGenero.Location = new System.Drawing.Point(167, 166);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(160, 31);
            this.cmbGenero.TabIndex = 28;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(14, 166);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(88, 23);
            this.lblGenero.TabIndex = 27;
            this.lblGenero.Text = "Genero: ";
            // 
            // cmbFormato
            // 
            this.cmbFormato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "DVD",
            "CD",
            "Memoria"});
            this.cmbFormato.Location = new System.Drawing.Point(167, 117);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(160, 31);
            this.cmbFormato.TabIndex = 26;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(14, 120);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(96, 23);
            this.lblFormato.TabIndex = 25;
            this.lblFormato.Text = "Formato: ";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(167, 69);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(310, 30);
            this.txtTitulo.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(14, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 23);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Titulo: ";
            // 
            // txtNumPelicula
            // 
            this.txtNumPelicula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPelicula.Location = new System.Drawing.Point(167, 26);
            this.txtNumPelicula.Name = "txtNumPelicula";
            this.txtNumPelicula.Size = new System.Drawing.Size(160, 30);
            this.txtNumPelicula.TabIndex = 1;
            // 
            // lblNumPelicula
            // 
            this.lblNumPelicula.AutoSize = true;
            this.lblNumPelicula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPelicula.Location = new System.Drawing.Point(14, 29);
            this.lblNumPelicula.Name = "lblNumPelicula";
            this.lblNumPelicula.Size = new System.Drawing.Size(145, 23);
            this.lblNumPelicula.TabIndex = 0;
            this.lblNumPelicula.Text = "No de pelicula: ";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 450);
            this.Controls.Add(this.dgvDatosPelicula);
            this.Controls.Add(this.txtBuscaPelicula);
            this.Controls.Add(this.lblBuscarPelicula);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPelicula)).EndInit();
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosPelicula;
        private System.Windows.Forms.TextBox txtBuscaPelicula;
        private System.Windows.Forms.Label lblBuscarPelicula;
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
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNumPelicula;
        private System.Windows.Forms.Label lblNumPelicula;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}