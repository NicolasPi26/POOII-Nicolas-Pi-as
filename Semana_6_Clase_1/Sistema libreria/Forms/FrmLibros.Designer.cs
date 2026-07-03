namespace Sistema_libreria.Forms
{
    partial class FrmLibros
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
            btnGuardar = new Button();
            btnElminar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            cbProveedor = new ComboBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            dgvLibros = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(274, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Libros";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnElminar
            // 
            btnElminar.Location = new Point(10, 360);
            btnElminar.Name = "btnElminar";
            btnElminar.Size = new Size(121, 23);
            btnElminar.TabIndex = 2;
            btnElminar.Text = "Eliminar";
            btnElminar.UseVisualStyleBackColor = true;
            btnElminar.Click += btnElminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(137, 331);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(137, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(23, 274);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(139, 23);
            cbProveedor.TabIndex = 5;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(23, 77);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(139, 23);
            txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(23, 123);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(139, 23);
            txtAutor.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(23, 173);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(139, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(23, 222);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(139, 23);
            txtStock.TabIndex = 9;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(274, 69);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(328, 315);
            dgvLibros.TabIndex = 10;
            dgvLibros.CellClick += dgvLibros_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 155);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 13;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 206);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 14;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 256);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 15;
            label6.Text = "Proveedor";
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 410);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvLibros);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(cbProveedor);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnElminar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Name = "FrmLibros";
            Text = "FrmLibros";
            Load += FrmLibros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private Button btnElminar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private ComboBox cbProveedor;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private DataGridView dgvLibros;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}