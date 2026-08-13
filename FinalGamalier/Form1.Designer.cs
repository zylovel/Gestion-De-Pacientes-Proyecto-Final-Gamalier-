namespace FinalGamalier
{
    partial class Form1
    {
        /// <summary>
        ///  Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Liberar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        ///  Método requerido para el soporte del Diseñador - no modificar
        ///  el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistroEdicion = new Label();
            dataGridView1 = new DataGridView();
            btnBuscarPorNombre = new Button();
            btnListarTodos = new Button();
            btnBuscarPorId = new Button();
            textBox3 = new TextBox();
            btnLimpiar = new Button();
            bntEliminar = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            cmbFechaIngreso = new ComboBox();
            cmbEstado = new ComboBox();
            cmbSexo = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtBNombre = new TextBox();
            txtBID = new TextBox();
            lblNombre = new Label();
            lblEdad = new Label();
            lblDiagnostico = new Label();
            lblSexo = new Label();
            lblEstado = new Label();
            lblFechaIngreso = new Label();
            lblBusquedaYListado = new Label();
            lblID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroEdicion
            // 
            lblRegistroEdicion.Location = new Point(-1, 16);
            lblRegistroEdicion.Name = "lblRegistroEdicion";
            lblRegistroEdicion.Size = new Size(214, 22);
            lblRegistroEdicion.TabIndex = 51;
            lblRegistroEdicion.Text = "Registro / Edicion de Pacientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(559, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(881, 592);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBuscarPorNombre
            // 
            btnBuscarPorNombre.Location = new Point(36, 619);
            btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            btnBuscarPorNombre.Size = new Size(153, 29);
            btnBuscarPorNombre.TabIndex = 49;
            btnBuscarPorNombre.Text = "Buscar por Nombre";
            btnBuscarPorNombre.UseVisualStyleBackColor = true;
            btnBuscarPorNombre.Click += btnBuscarPorNombre_Click;
            // 
            // btnListarTodos
            // 
            btnListarTodos.BackColor = Color.Transparent;
            btnListarTodos.Location = new Point(256, 619);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(137, 29);
            btnListarTodos.TabIndex = 48;
            btnListarTodos.Text = "Listar Todos";
            btnListarTodos.UseVisualStyleBackColor = false;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // btnBuscarPorId
            // 
            btnBuscarPorId.Location = new Point(380, 562);
            btnBuscarPorId.Name = "btnBuscarPorId";
            btnBuscarPorId.Size = new Size(137, 37);
            btnBuscarPorId.TabIndex = 47;
            btnBuscarPorId.Text = "Buscar por ID";
            btnBuscarPorId.UseVisualStyleBackColor = true;
            btnBuscarPorId.Click += btnBuscarPorId_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 567);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 27);
            textBox3.TabIndex = 46;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(423, 410);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 45);
            btnLimpiar.TabIndex = 45;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Location = new Point(299, 410);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(94, 45);
            bntEliminar.TabIndex = 44;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(36, 410);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 45);
            btnAgregar.TabIndex = 43;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(161, 410);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 45);
            btnActualizar.TabIndex = 42;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cmbFechaIngreso
            // 
            cmbFechaIngreso.FormattingEnabled = true;
            cmbFechaIngreso.Location = new Point(395, 330);
            cmbFechaIngreso.Name = "cmbFechaIngreso";
            cmbFechaIngreso.Size = new Size(122, 28);
            cmbFechaIngreso.TabIndex = 41;
            cmbFechaIngreso.SelectedIndexChanged += cmbFechaIngreso_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(114, 330);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(196, 28);
            cmbEstado.TabIndex = 40;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(344, 148);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(173, 28);
            cmbSexo.TabIndex = 39;
            cmbSexo.SelectedIndexChanged += cmbSexo_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 202);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 107);
            textBox2.TabIndex = 38;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 27);
            textBox1.TabIndex = 37;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtBNombre
            // 
            txtBNombre.Location = new Point(114, 102);
            txtBNombre.Name = "txtBNombre";
            txtBNombre.Size = new Size(403, 27);
            txtBNombre.TabIndex = 36;
            txtBNombre.TextChanged += txtBNombre_TextChanged;
            // 
            // txtBID
            // 
            txtBID.Location = new Point(114, 56);
            txtBID.Name = "txtBID";
            txtBID.Size = new Size(403, 27);
            txtBID.TabIndex = 35;
            txtBID.TextChanged += txtBID_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(4, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(4, 148);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 33;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(4, 202);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(89, 20);
            lblDiagnostico.TabIndex = 32;
            lblDiagnostico.Text = "Diagnostico";
            lblDiagnostico.Click += lblDiagnostico_Click;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(280, 148);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(41, 20);
            lblSexo.TabIndex = 31;
            lblSexo.Text = "Sexo";
            lblSexo.Click += lblSexo_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(4, 333);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 30;
            lblEstado.Text = "Estado";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(328, 333);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(47, 20);
            lblFechaIngreso.TabIndex = 29;
            lblFechaIngreso.Text = "Fecha";
            lblFechaIngreso.Click += lblFechaIngreso_Click;
            // 
            // lblBusquedaYListado
            // 
            lblBusquedaYListado.AutoSize = true;
            lblBusquedaYListado.Location = new Point(4, 522);
            lblBusquedaYListado.Name = "lblBusquedaYListado";
            lblBusquedaYListado.Size = new Size(137, 20);
            lblBusquedaYListado.TabIndex = 28;
            lblBusquedaYListado.Text = "Busqueda y Listado";
            lblBusquedaYListado.Click += lblBusquedaYListado_Click;
            // 
            // lblID
            // 
            lblID.Location = new Point(4, 59);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 19);
            lblID.TabIndex = 27;
            lblID.Text = "ID";
            lblID.Click += lblID_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 745);
            Controls.Add(lblRegistroEdicion);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscarPorNombre);
            Controls.Add(btnListarTodos);
            Controls.Add(btnBuscarPorId);
            Controls.Add(textBox3);
            Controls.Add(btnLimpiar);
            Controls.Add(bntEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(cmbFechaIngreso);
            Controls.Add(cmbEstado);
            Controls.Add(cmbSexo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtBNombre);
            Controls.Add(txtBID);
            Controls.Add(lblNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblSexo);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblBusquedaYListado);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroEdicion;
        private DataGridView dataGridView1;
        private Button btnBuscarPorNombre;
        private Button btnListarTodos;
        private Button btnBuscarPorId;
        private TextBox textBox3;
        private Button btnLimpiar;
        private Button bntEliminar;
        private Button btnAgregar;
        private Button btnActualizar;
        private ComboBox cmbFechaIngreso;
        private ComboBox cmbEstado;
        private ComboBox cmbSexo;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtBNombre;
        private TextBox txtBID;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblDiagnostico;
        private Label lblSexo;
        private Label lblEstado;
        private Label lblFechaIngreso;
        private Label lblBusquedaYListado;
        private Label lblID;
    }
}
