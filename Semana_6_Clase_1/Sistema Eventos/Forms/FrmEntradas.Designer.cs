namespace Sistema_Eventos.Forms
{
    partial class FrmEntradas
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
            label5 = new Label();
            label6 = new Label();
            cmbEvento = new ComboBox();
            cmbParticipante = new ComboBox();
            txtTipo = new TextBox();
            txtPrecio = new TextBox();
            dtpFechaCompra = new DateTimePicker();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvEntradas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Participante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 184);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Entrada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 234);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 284);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(262, 26);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 5;
            label6.Text = "Entradas";
            // 
            // cmbEvento
            // 
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Location = new Point(27, 99);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(200, 23);
            cmbEvento.TabIndex = 6;
            // 
            // cmbParticipante
            // 
            cmbParticipante.FormattingEnabled = true;
            cmbParticipante.Location = new Point(27, 150);
            cmbParticipante.Name = "cmbParticipante";
            cmbParticipante.Size = new Size(200, 23);
            cmbParticipante.TabIndex = 7;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(27, 202);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(200, 23);
            txtTipo.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(27, 252);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 9;
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Location = new Point(27, 302);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(200, 23);
            dtpFechaCompra.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(27, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(152, 343);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 387);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(152, 387);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvEntradas
            // 
            dgvEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntradas.Location = new Point(286, 79);
            dgvEntradas.Name = "dgvEntradas";
            dgvEntradas.Size = new Size(296, 336);
            dgvEntradas.TabIndex = 15;
            dgvEntradas.CellClick += dgvEntradas_CellClick;
            // 
            // FrmEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(dgvEntradas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaCompra);
            Controls.Add(txtPrecio);
            Controls.Add(txtTipo);
            Controls.Add(cmbParticipante);
            Controls.Add(cmbEvento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEntradas";
            Text = "FrmEntradas";
            Load += FrmEntradas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbEvento;
        private ComboBox cmbParticipante;
        private TextBox txtTipo;
        private TextBox txtPrecio;
        private DateTimePicker dtpFechaCompra;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEntradas;
    }
}