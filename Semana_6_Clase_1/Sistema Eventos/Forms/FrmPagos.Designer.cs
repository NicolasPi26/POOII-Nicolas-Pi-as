namespace Sistema_Eventos.Forms
{
    partial class FrmPagos
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
            cmbEntrada = new ComboBox();
            txtMetodo = new TextBox();
            txtMonto = new TextBox();
            dtpFechaPago = new DateTimePicker();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvPagos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 61);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Metodo Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 167);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 217);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(243, 15);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 4;
            label5.Text = "Pagos";
            // 
            // cmbEntrada
            // 
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(28, 79);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(161, 23);
            cmbEntrada.TabIndex = 5;
            // 
            // txtMetodo
            // 
            txtMetodo.Location = new Point(28, 134);
            txtMetodo.Name = "txtMetodo";
            txtMetodo.Size = new Size(161, 23);
            txtMetodo.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(28, 185);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(161, 23);
            txtMonto.TabIndex = 7;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(28, 235);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(161, 23);
            dtpFechaPago.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 311);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(114, 311);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(28, 351);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(114, 351);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(243, 61);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(273, 313);
            dgvPagos.TabIndex = 13;
            dgvPagos.CellClick += dgvPagos_CellClick;
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 391);
            Controls.Add(dgvPagos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaPago);
            Controls.Add(txtMonto);
            Controls.Add(txtMetodo);
            Controls.Add(cmbEntrada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPagos";
            Text = "FrmPagos";
            Load += FrmPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbEntrada;
        private TextBox txtMetodo;
        private TextBox txtMonto;
        private DateTimePicker dtpFechaPago;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvPagos;
    }
}