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
            this.txtNumRegistro = new System.Windows.Forms.TextBox();
            this.lblNumRegistro = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.grbVacunas = new System.Windows.Forms.GroupBox();
            this.chbHepatitisA = new System.Windows.Forms.CheckBox();
            this.chbPolio = new System.Windows.Forms.CheckBox();
            this.chbHepatitisB = new System.Windows.Forms.CheckBox();
            this.chbNeumococo = new System.Windows.Forms.CheckBox();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HepatitisA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HepatitisB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neumococo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // txtBuscaPaciente
            // 
            this.txtBuscaPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPaciente.Location = new System.Drawing.Point(788, 28);
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
            this.lblBuscarPaciente.Size = new System.Drawing.Size(187, 23);
            this.lblBuscarPaciente.TabIndex = 16;
            this.lblBuscarPaciente.Text = "Nombre del evento: ";
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
            this.lblNavegacion.Size = new System.Drawing.Size(88, 29);
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
            // grbVacunas
            // 
            this.grbVacunas.Controls.Add(this.chbNeumococo);
            this.grbVacunas.Controls.Add(this.chbHepatitisB);
            this.grbVacunas.Controls.Add(this.chbPolio);
            this.grbVacunas.Controls.Add(this.chbHepatitisA);
            this.grbVacunas.Location = new System.Drawing.Point(18, 121);
            this.grbVacunas.Name = "grbVacunas";
            this.grbVacunas.Size = new System.Drawing.Size(518, 146);
            this.grbVacunas.TabIndex = 20;
            this.grbVacunas.TabStop = false;
            this.grbVacunas.Text = "Vacunas";
            // 
            // chbHepatitisA
            // 
            this.chbHepatitisA.AutoSize = true;
            this.chbHepatitisA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHepatitisA.Location = new System.Drawing.Point(64, 33);
            this.chbHepatitisA.Name = "chbHepatitisA";
            this.chbHepatitisA.Size = new System.Drawing.Size(126, 27);
            this.chbHepatitisA.TabIndex = 0;
            this.chbHepatitisA.Text = "Hepatitis A";
            this.chbHepatitisA.UseVisualStyleBackColor = true;
            // 
            // chbPolio
            // 
            this.chbPolio.AutoSize = true;
            this.chbPolio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPolio.Location = new System.Drawing.Point(313, 33);
            this.chbPolio.Name = "chbPolio";
            this.chbPolio.Size = new System.Drawing.Size(75, 27);
            this.chbPolio.TabIndex = 1;
            this.chbPolio.Text = "Polio";
            this.chbPolio.UseVisualStyleBackColor = true;
            // 
            // chbHepatitisB
            // 
            this.chbHepatitisB.AutoSize = true;
            this.chbHepatitisB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHepatitisB.Location = new System.Drawing.Point(64, 98);
            this.chbHepatitisB.Name = "chbHepatitisB";
            this.chbHepatitisB.Size = new System.Drawing.Size(127, 27);
            this.chbHepatitisB.TabIndex = 2;
            this.chbHepatitisB.Text = "Hepatitis B";
            this.chbHepatitisB.UseVisualStyleBackColor = true;
            // 
            // chbNeumococo
            // 
            this.chbNeumococo.AutoSize = true;
            this.chbNeumococo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNeumococo.Location = new System.Drawing.Point(313, 98);
            this.chbNeumococo.Name = "chbNeumococo";
            this.chbNeumococo.Size = new System.Drawing.Size(135, 27);
            this.chbNeumococo.TabIndex = 3;
            this.chbNeumococo.Text = "Neumococo";
            this.chbNeumococo.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox chbNeumococo;
        private System.Windows.Forms.CheckBox chbHepatitisB;
        private System.Windows.Forms.CheckBox chbPolio;
        private System.Windows.Forms.CheckBox chbHepatitisA;
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
    }
}