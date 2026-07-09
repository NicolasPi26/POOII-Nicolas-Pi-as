namespace Sistema_Eventos.Forms
{
    partial class FrmEventos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreEvento = new TextBox();
            txtLugar = new TextBox();
            txtCapacidad = new TextBox();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvEventos = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 77);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 135);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Lugar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 189);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 305);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Capacidad";
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(28, 98);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new Size(201, 23);
            txtNombreEvento.TabIndex = 4;
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(28, 154);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(201, 23);
            txtLugar.TabIndex = 5;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(28, 329);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(201, 23);
            txtCapacidad.TabIndex = 6;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 245);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Hora";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(28, 211);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(28, 265);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(200, 23);
            dtpHora.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 26);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(149, 371);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 26);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(31, 400);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 26);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(149, 400);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 26);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(262, 76);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.Size = new Size(335, 362);
            dgvEventos.TabIndex = 14;
            dgvEventos.CellClick += dgvEventos_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(262, 23);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 15;
            label6.Text = "Eventos";
            // 
            // FrmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(label6);
            Controls.Add(dgvEventos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(label5);
            Controls.Add(txtCapacidad);
            Controls.Add(txtLugar);
            Controls.Add(txtNombreEvento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEventos";
            Text = "FrmEventos";
            Load += FrmEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreEvento;
        private TextBox txtLugar;
        private TextBox txtCapacidad;
        private Label label5;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEventos;
        private Label label6;
    }
}