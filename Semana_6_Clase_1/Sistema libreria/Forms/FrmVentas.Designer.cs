namespace Sistema_libreria.Forms
{
    partial class FrmVentas
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
            cbLibro = new ComboBox();
            txtCantidad = new TextBox();
            dtpFecha = new DateTimePicker();
            txtTotal = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvVentas = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(256, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // cbLibro
            // 
            cbLibro.FormattingEnabled = true;
            cbLibro.Location = new Point(12, 86);
            cbLibro.Name = "cbLibro";
            cbLibro.Size = new Size(228, 23);
            cbLibro.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 141);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(228, 23);
            txtCantidad.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 193);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 23);
            dtpFecha.TabIndex = 3;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(12, 250);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(154, 23);
            txtTotal.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(57, 305);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(57, 334);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(57, 363);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(282, 60);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(295, 345);
            dgvVentas.TabIndex = 8;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 9;
            label2.Text = "Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha de adquisicion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 232);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 12;
            label5.Text = "Total de venta";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 426);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvVentas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTotal);
            Controls.Add(dtpFecha);
            Controls.Add(txtCantidad);
            Controls.Add(cbLibro);
            Controls.Add(label1);
            Name = "FrmVentas";
            Text = "FrmVentas";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbLibro;
        private TextBox txtCantidad;
        private DateTimePicker dtpFecha;
        private TextBox txtTotal;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvVentas;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}