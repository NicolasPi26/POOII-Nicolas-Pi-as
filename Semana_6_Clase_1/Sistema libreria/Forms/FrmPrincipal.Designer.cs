namespace Sistema_libreria.Forms
{
    partial class FrmPrincipal
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
            btnProveedores = new Button();
            btnLibros = new Button();
            btnVentas = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(55, 65);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(201, 23);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(54, 98);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(202, 23);
            btnLibros.TabIndex = 1;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(54, 135);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(202, 23);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(54, 173);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(202, 23);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(54, 207);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(202, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(70, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 5;
            label1.Text = "Sistema de Libreria";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 261);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Controls.Add(btnLibros);
            Controls.Add(btnProveedores);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProveedores;
        private Button btnLibros;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnSalir;
        private Label label1;
    }
}