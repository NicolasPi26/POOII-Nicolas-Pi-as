namespace Sistema_Eventos.Forms
{
    partial class FrmParticipantes
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
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvParticipantes = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 167);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 220);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(29, 134);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(194, 23);
            txtCedula.TabIndex = 5;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(27, 188);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(196, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(27, 243);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(196, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 298);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(148, 298);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(32, 355);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(148, 355);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(303, 60);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.Size = new Size(293, 321);
            dgvParticipantes.TabIndex = 12;
            dgvParticipantes.CellClick += dgvParticipantes_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(235, 19);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 13;
            label5.Text = "Participantes";
            // 
            // FrmParticipantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 399);
            Controls.Add(label5);
            Controls.Add(dgvParticipantes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmParticipantes";
            Text = "FrmParticipantes";
            Load += FrmParticipantes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvParticipantes;
        private Label label5;
    }
}