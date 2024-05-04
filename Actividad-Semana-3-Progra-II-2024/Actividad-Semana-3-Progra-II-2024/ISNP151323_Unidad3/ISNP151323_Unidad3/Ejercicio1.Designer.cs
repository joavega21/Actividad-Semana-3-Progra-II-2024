namespace ISNP151323_Unidad3
{
    partial class Ejercicio1
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.cmbSexoAlumno = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPromedioAlumno = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblPromedioAlumno = new System.Windows.Forms.Label();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.lblLab2 = new System.Windows.Forms.Label();
            this.lblLab1 = new System.Windows.Forms.Label();
            this.txtEdadAlumno = new System.Windows.Forms.TextBox();
            this.lblSexoAlumno = new System.Windows.Forms.Label();
            this.lblEdadAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblNavegacion = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvDatosAlumno = new System.Windows.Forms.DataGridView();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatos.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cmbSexoAlumno);
            this.grbDatos.Controls.Add(this.btnCalcular);
            this.grbDatos.Controls.Add(this.txtPromedioAlumno);
            this.grbDatos.Controls.Add(this.txtParcial);
            this.grbDatos.Controls.Add(this.lblPromedioAlumno);
            this.grbDatos.Controls.Add(this.txtLab2);
            this.grbDatos.Controls.Add(this.lblParcial);
            this.grbDatos.Controls.Add(this.txtLab1);
            this.grbDatos.Controls.Add(this.lblLab2);
            this.grbDatos.Controls.Add(this.lblLab1);
            this.grbDatos.Controls.Add(this.txtEdadAlumno);
            this.grbDatos.Controls.Add(this.lblSexoAlumno);
            this.grbDatos.Controls.Add(this.lblEdadAlumno);
            this.grbDatos.Controls.Add(this.txtNombreAlumno);
            this.grbDatos.Controls.Add(this.lblNombreAlumno);
            this.grbDatos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(38, 51);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(556, 345);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // cmbSexoAlumno
            // 
            this.cmbSexoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexoAlumno.FormattingEnabled = true;
            this.cmbSexoAlumno.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoAlumno.Location = new System.Drawing.Point(226, 152);
            this.cmbSexoAlumno.Name = "cmbSexoAlumno";
            this.cmbSexoAlumno.Size = new System.Drawing.Size(160, 31);
            this.cmbSexoAlumno.TabIndex = 24;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(421, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 39);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPromedioAlumno
            // 
            this.txtPromedioAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioAlumno.Location = new System.Drawing.Point(226, 310);
            this.txtPromedioAlumno.Name = "txtPromedioAlumno";
            this.txtPromedioAlumno.ReadOnly = true;
            this.txtPromedioAlumno.Size = new System.Drawing.Size(160, 30);
            this.txtPromedioAlumno.TabIndex = 16;
            // 
            // txtParcial
            // 
            this.txtParcial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcial.Location = new System.Drawing.Point(226, 270);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(160, 30);
            this.txtParcial.TabIndex = 15;
            // 
            // lblPromedioAlumno
            // 
            this.lblPromedioAlumno.AutoSize = true;
            this.lblPromedioAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioAlumno.Location = new System.Drawing.Point(14, 313);
            this.lblPromedioAlumno.Name = "lblPromedioAlumno";
            this.lblPromedioAlumno.Size = new System.Drawing.Size(106, 23);
            this.lblPromedioAlumno.TabIndex = 14;
            this.lblPromedioAlumno.Text = "Promedio: ";
            // 
            // txtLab2
            // 
            this.txtLab2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab2.Location = new System.Drawing.Point(226, 231);
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(160, 30);
            this.txtLab2.TabIndex = 13;
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.Location = new System.Drawing.Point(14, 274);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(155, 23);
            this.lblParcial.TabIndex = 12;
            this.lblParcial.Text = "Nota de parcial: ";
            // 
            // txtLab1
            // 
            this.txtLab1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab1.Location = new System.Drawing.Point(226, 191);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(160, 30);
            this.txtLab1.TabIndex = 11;
            // 
            // lblLab2
            // 
            this.lblLab2.AutoSize = true;
            this.lblLab2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab2.Location = new System.Drawing.Point(14, 234);
            this.lblLab2.Name = "lblLab2";
            this.lblLab2.Size = new System.Drawing.Size(208, 23);
            this.lblLab2.TabIndex = 10;
            this.lblLab2.Text = "Nota de laboratorio 2: ";
            // 
            // lblLab1
            // 
            this.lblLab1.AutoSize = true;
            this.lblLab1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab1.Location = new System.Drawing.Point(14, 195);
            this.lblLab1.Name = "lblLab1";
            this.lblLab1.Size = new System.Drawing.Size(208, 23);
            this.lblLab1.TabIndex = 8;
            this.lblLab1.Text = "Nota de laboratorio 1: ";
            // 
            // txtEdadAlumno
            // 
            this.txtEdadAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadAlumno.Location = new System.Drawing.Point(226, 113);
            this.txtEdadAlumno.Name = "txtEdadAlumno";
            this.txtEdadAlumno.Size = new System.Drawing.Size(160, 30);
            this.txtEdadAlumno.TabIndex = 7;
            // 
            // lblSexoAlumno
            // 
            this.lblSexoAlumno.AutoSize = true;
            this.lblSexoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoAlumno.Location = new System.Drawing.Point(14, 155);
            this.lblSexoAlumno.Name = "lblSexoAlumno";
            this.lblSexoAlumno.Size = new System.Drawing.Size(66, 23);
            this.lblSexoAlumno.TabIndex = 6;
            this.lblSexoAlumno.Text = "Sexo: ";
            // 
            // lblEdadAlumno
            // 
            this.lblEdadAlumno.AutoSize = true;
            this.lblEdadAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadAlumno.Location = new System.Drawing.Point(14, 113);
            this.lblEdadAlumno.Name = "lblEdadAlumno";
            this.lblEdadAlumno.Size = new System.Drawing.Size(68, 23);
            this.lblEdadAlumno.TabIndex = 4;
            this.lblEdadAlumno.Text = "Edad: ";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(226, 68);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(320, 30);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(14, 71);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(91, 23);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "Nombre: ";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAlumno.Location = new System.Drawing.Point(226, 26);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(160, 30);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(14, 29);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(84, 23);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "Codigo: ";
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Controls.Add(this.lblNavegacion);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Location = new System.Drawing.Point(38, 409);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(556, 79);
            this.grbNavegacion.TabIndex = 1;
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
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnModificiar);
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Location = new System.Drawing.Point(622, 409);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(556, 79);
            this.grbEdicion.TabIndex = 2;
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
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(756, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(320, 30);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(628, 54);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(91, 23);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Nombre: ";
            // 
            // dgvDatosAlumno
            // 
            this.dgvDatosAlumno.AllowUserToAddRows = false;
            this.dgvDatosAlumno.AllowUserToDeleteRows = false;
            this.dgvDatosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno,
            this.Codigo,
            this.Nombre,
            this.Edad,
            this.Sexo,
            this.Lab1,
            this.Lab2,
            this.Parcial,
            this.Promedio});
            this.dgvDatosAlumno.Location = new System.Drawing.Point(622, 105);
            this.dgvDatosAlumno.Name = "dgvDatosAlumno";
            this.dgvDatosAlumno.ReadOnly = true;
            this.dgvDatosAlumno.RowHeadersWidth = 51;
            this.dgvDatosAlumno.RowTemplate.Height = 24;
            this.dgvDatosAlumno.Size = new System.Drawing.Size(567, 286);
            this.dgvDatosAlumno.TabIndex = 6;
            this.dgvDatosAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosAlumno_CellClick);
            // 
            // IdAlumno
            // 
            this.IdAlumno.DataPropertyName = "IdAlumno";
            this.IdAlumno.HeaderText = "IdAlumno";
            this.IdAlumno.MinimumWidth = 6;
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Visible = false;
            this.IdAlumno.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 125;
            // 
            // Lab1
            // 
            this.Lab1.DataPropertyName = "Nota1";
            this.Lab1.HeaderText = "Lab1";
            this.Lab1.MinimumWidth = 6;
            this.Lab1.Name = "Lab1";
            this.Lab1.ReadOnly = true;
            this.Lab1.Width = 125;
            // 
            // Lab2
            // 
            this.Lab2.DataPropertyName = "Nota2";
            this.Lab2.HeaderText = "Lab2";
            this.Lab2.MinimumWidth = 6;
            this.Lab2.Name = "Lab2";
            this.Lab2.ReadOnly = true;
            this.Lab2.Width = 125;
            // 
            // Parcial
            // 
            this.Parcial.DataPropertyName = "Parcial";
            this.Parcial.HeaderText = "Parcial";
            this.Parcial.MinimumWidth = 6;
            this.Parcial.Name = "Parcial";
            this.Parcial.ReadOnly = true;
            this.Parcial.Width = 125;
            // 
            // Promedio
            // 
            this.Promedio.DataPropertyName = "Promedio";
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 125;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 570);
            this.Controls.Add(this.dgvDatosAlumno);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.TextBox txtEdadAlumno;
        private System.Windows.Forms.Label lblSexoAlumno;
        private System.Windows.Forms.Label lblEdadAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label lblPromedioAlumno;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.Label lblLab2;
        private System.Windows.Forms.Label lblLab1;
        private System.Windows.Forms.Label lblNavegacion;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificiar;
        private System.Windows.Forms.TextBox txtPromedioAlumno;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbSexoAlumno;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvDatosAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
    }
}