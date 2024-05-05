namespace ISNP151323_Unidad3
{
    partial class Ejercicio3
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
            this.dgvDatosPaciente = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HepatitisA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HepatitisB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neumococo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaPaciente = new System.Windows.Forms.TextBox();
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
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
            this.grbVacunas = new System.Windows.Forms.GroupBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtNumRegistro = new System.Windows.Forms.TextBox();
            this.lblNumRegistro = new System.Windows.Forms.Label();
            this.cmbVacuna1 = new System.Windows.Forms.ComboBox();
            this.lblVacuna1 = new System.Windows.Forms.Label();
            this.lblVacuna4 = new System.Windows.Forms.Label();
            this.lblVacuna2 = new System.Windows.Forms.Label();
            this.lblVacuna3 = new System.Windows.Forms.Label();
            this.cmbVacuna2 = new System.Windows.Forms.ComboBox();
            this.cmbVacuna3 = new System.Windows.Forms.ComboBox();
            this.cmbVacuna4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaciente)).BeginInit();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.grbVacunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosPaciente
            // 
            this.dgvDatosPaciente.AllowUserToAddRows = false;
            this.dgvDatosPaciente.AllowUserToDeleteRows = false;
            this.dgvDatosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.Registro,
            this.Nombre,
            this.HepatitisA,
            this.HepatitisB,
            this.Polio,
            this.Neumococo});
            this.dgvDatosPaciente.Location = new System.Drawing.Point(596, 82);
            this.dgvDatosPaciente.Name = "dgvDatosPaciente";
            this.dgvDatosPaciente.ReadOnly = true;
            this.dgvDatosPaciente.RowHeadersWidth = 51;
            this.dgvDatosPaciente.RowTemplate.Height = 24;
            this.dgvDatosPaciente.Size = new System.Drawing.Size(567, 231);
            this.dgvDatosPaciente.TabIndex = 18;
            this.dgvDatosPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosPaciente_CellClick);
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            this.IdPaciente.HeaderText = "IdPaciente";
            this.IdPaciente.MinimumWidth = 6;
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Visible = false;
            this.IdPaciente.Width = 125;
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "Registro";
            this.Registro.HeaderText = "Registro";
            this.Registro.MinimumWidth = 6;
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Width = 70;
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
            // HepatitisA
            // 
            this.HepatitisA.DataPropertyName = "Vacuna1";
            this.HepatitisA.HeaderText = "HepatitisA";
            this.HepatitisA.MinimumWidth = 6;
            this.HepatitisA.Name = "HepatitisA";
            this.HepatitisA.ReadOnly = true;
            this.HepatitisA.Width = 80;
            // 
            // HepatitisB
            // 
            this.HepatitisB.DataPropertyName = "Vacuna2";
            this.HepatitisB.HeaderText = "HepatitisB";
            this.HepatitisB.MinimumWidth = 6;
            this.HepatitisB.Name = "HepatitisB";
            this.HepatitisB.ReadOnly = true;
            this.HepatitisB.Width = 80;
            // 
            // Polio
            // 
            this.Polio.DataPropertyName = "Vacuna3";
            this.Polio.HeaderText = "Polio";
            this.Polio.MinimumWidth = 6;
            this.Polio.Name = "Polio";
            this.Polio.ReadOnly = true;
            this.Polio.Width = 70;
            // 
            // Neumococo
            // 
            this.Neumococo.DataPropertyName = "Vacuna4";
            this.Neumococo.HeaderText = "Neumococo";
            this.Neumococo.MinimumWidth = 6;
            this.Neumococo.Name = "Neumococo";
            this.Neumococo.ReadOnly = true;
            this.Neumococo.Width = 70;
            // 
            // txtBuscaPaciente
            // 
            this.txtBuscaPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPaciente.Location = new System.Drawing.Point(811, 28);
            this.txtBuscaPaciente.Name = "txtBuscaPaciente";
            this.txtBuscaPaciente.Size = new System.Drawing.Size(320, 30);
            this.txtBuscaPaciente.TabIndex = 17;
            this.txtBuscaPaciente.TextChanged += new System.EventHandler(this.txtBuscaPaciente_TextChanged);
            this.txtBuscaPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaPaciente_KeyUp);
            // 
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPaciente.Location = new System.Drawing.Point(602, 31);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(203, 23);
            this.lblBuscarPaciente.TabIndex = 16;
            this.lblBuscarPaciente.Text = "Nombre del paciente: ";
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnModificiar);
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Location = new System.Drawing.Point(596, 343);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(556, 79);
            this.grbEdicion.TabIndex = 15;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(389, 26);
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
            this.btnModificiar.Location = new System.Drawing.Point(218, 26);
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
            this.btnAgregar.Location = new System.Drawing.Point(46, 26);
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
            this.grbNavegacion.Location = new System.Drawing.Point(12, 343);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(556, 79);
            this.grbNavegacion.TabIndex = 14;
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
            this.grbDatos.Controls.Add(this.grbVacunas);
            this.grbDatos.Controls.Add(this.txtNombrePaciente);
            this.grbDatos.Controls.Add(this.lblNombrePaciente);
            this.grbDatos.Controls.Add(this.txtNumRegistro);
            this.grbDatos.Controls.Add(this.lblNumRegistro);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(12, 28);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(556, 285);
            this.grbDatos.TabIndex = 13;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // grbVacunas
            // 
            this.grbVacunas.Controls.Add(this.cmbVacuna4);
            this.grbVacunas.Controls.Add(this.cmbVacuna3);
            this.grbVacunas.Controls.Add(this.cmbVacuna2);
            this.grbVacunas.Controls.Add(this.lblVacuna3);
            this.grbVacunas.Controls.Add(this.lblVacuna2);
            this.grbVacunas.Controls.Add(this.lblVacuna4);
            this.grbVacunas.Controls.Add(this.lblVacuna1);
            this.grbVacunas.Controls.Add(this.cmbVacuna1);
            this.grbVacunas.Location = new System.Drawing.Point(18, 121);
            this.grbVacunas.Name = "grbVacunas";
            this.grbVacunas.Size = new System.Drawing.Size(518, 146);
            this.grbVacunas.TabIndex = 20;
            this.grbVacunas.TabStop = false;
            this.grbVacunas.Text = "Vacunas";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(226, 69);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(310, 30);
            this.txtNombrePaciente.TabIndex = 9;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(14, 72);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(91, 23);
            this.lblNombrePaciente.TabIndex = 8;
            this.lblNombrePaciente.Text = "Nombre: ";
            // 
            // txtNumRegistro
            // 
            this.txtNumRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRegistro.Location = new System.Drawing.Point(226, 26);
            this.txtNumRegistro.Name = "txtNumRegistro";
            this.txtNumRegistro.Size = new System.Drawing.Size(160, 30);
            this.txtNumRegistro.TabIndex = 1;
            // 
            // lblNumRegistro
            // 
            this.lblNumRegistro.AutoSize = true;
            this.lblNumRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistro.Location = new System.Drawing.Point(14, 29);
            this.lblNumRegistro.Name = "lblNumRegistro";
            this.lblNumRegistro.Size = new System.Drawing.Size(147, 23);
            this.lblNumRegistro.TabIndex = 0;
            this.lblNumRegistro.Text = "No de registro: ";
            // 
            // cmbVacuna1
            // 
            this.cmbVacuna1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVacuna1.FormattingEnabled = true;
            this.cmbVacuna1.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbVacuna1.Location = new System.Drawing.Point(139, 30);
            this.cmbVacuna1.Name = "cmbVacuna1";
            this.cmbVacuna1.Size = new System.Drawing.Size(72, 31);
            this.cmbVacuna1.TabIndex = 4;
            // 
            // lblVacuna1
            // 
            this.lblVacuna1.AutoSize = true;
            this.lblVacuna1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacuna1.Location = new System.Drawing.Point(17, 33);
            this.lblVacuna1.Name = "lblVacuna1";
            this.lblVacuna1.Size = new System.Drawing.Size(104, 23);
            this.lblVacuna1.TabIndex = 21;
            this.lblVacuna1.Text = "Hepatitis A";
            // 
            // lblVacuna4
            // 
            this.lblVacuna4.AutoSize = true;
            this.lblVacuna4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacuna4.Location = new System.Drawing.Point(277, 94);
            this.lblVacuna4.Name = "lblVacuna4";
            this.lblVacuna4.Size = new System.Drawing.Size(113, 23);
            this.lblVacuna4.TabIndex = 22;
            this.lblVacuna4.Text = "Neumococo";
            // 
            // lblVacuna2
            // 
            this.lblVacuna2.AutoSize = true;
            this.lblVacuna2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacuna2.Location = new System.Drawing.Point(277, 33);
            this.lblVacuna2.Name = "lblVacuna2";
            this.lblVacuna2.Size = new System.Drawing.Size(105, 23);
            this.lblVacuna2.TabIndex = 23;
            this.lblVacuna2.Text = "Hepatitis B";
            // 
            // lblVacuna3
            // 
            this.lblVacuna3.AutoSize = true;
            this.lblVacuna3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacuna3.Location = new System.Drawing.Point(17, 94);
            this.lblVacuna3.Name = "lblVacuna3";
            this.lblVacuna3.Size = new System.Drawing.Size(53, 23);
            this.lblVacuna3.TabIndex = 24;
            this.lblVacuna3.Text = "Polio";
            // 
            // cmbVacuna2
            // 
            this.cmbVacuna2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVacuna2.FormattingEnabled = true;
            this.cmbVacuna2.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbVacuna2.Location = new System.Drawing.Point(399, 30);
            this.cmbVacuna2.Name = "cmbVacuna2";
            this.cmbVacuna2.Size = new System.Drawing.Size(72, 31);
            this.cmbVacuna2.TabIndex = 25;
            // 
            // cmbVacuna3
            // 
            this.cmbVacuna3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVacuna3.FormattingEnabled = true;
            this.cmbVacuna3.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbVacuna3.Location = new System.Drawing.Point(139, 91);
            this.cmbVacuna3.Name = "cmbVacuna3";
            this.cmbVacuna3.Size = new System.Drawing.Size(72, 31);
            this.cmbVacuna3.TabIndex = 26;
            // 
            // cmbVacuna4
            // 
            this.cmbVacuna4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVacuna4.FormattingEnabled = true;
            this.cmbVacuna4.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbVacuna4.Location = new System.Drawing.Point(399, 91);
            this.cmbVacuna4.Name = "cmbVacuna4";
            this.cmbVacuna4.Size = new System.Drawing.Size(72, 31);
            this.cmbVacuna4.TabIndex = 27;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.dgvDatosPaciente);
            this.Controls.Add(this.txtBuscaPaciente);
            this.Controls.Add(this.lblBuscarPaciente);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPaciente)).EndInit();
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbVacunas.ResumeLayout(false);
            this.grbVacunas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosPaciente;
        private System.Windows.Forms.TextBox txtBuscaPaciente;
        private System.Windows.Forms.Label lblBuscarPaciente;
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
        private System.Windows.Forms.GroupBox grbVacunas;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtNumRegistro;
        private System.Windows.Forms.Label lblNumRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn HepatitisA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HepatitisB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neumococo;
        private System.Windows.Forms.Label lblVacuna3;
        private System.Windows.Forms.Label lblVacuna2;
        private System.Windows.Forms.Label lblVacuna4;
        private System.Windows.Forms.Label lblVacuna1;
        private System.Windows.Forms.ComboBox cmbVacuna1;
        private System.Windows.Forms.ComboBox cmbVacuna4;
        private System.Windows.Forms.ComboBox cmbVacuna3;
        private System.Windows.Forms.ComboBox cmbVacuna2;
    }
}