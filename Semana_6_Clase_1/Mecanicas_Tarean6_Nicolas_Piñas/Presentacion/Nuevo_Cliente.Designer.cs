namespace Mecanicas_Tarean6_Nicolas_Piñas.Migrations
{
    partial class Nuevo_Cliente
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
            txtNombre = new TextBox();
            btn_Guardar = new Button();
            btn_Cancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtModelo = new TextBox();
            label5 = new Label();
            txtMarca = new TextBox();
            label6 = new Label();
            txtPlaca = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Vehiculo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 23);
            txtNombre.TabIndex = 1;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(33, 369);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 2;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(123, 369);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 3;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(33, 147);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(171, 23);
            txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 191);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(33, 209);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(171, 23);
            txtModelo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 250);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(33, 268);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(171, 23);
            txtMarca.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 312);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 12;
            label6.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(33, 330);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(171, 23);
            txtPlaca.TabIndex = 11;
            // 
            // Nuevo_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 414);
            Controls.Add(label6);
            Controls.Add(txtPlaca);
            Controls.Add(label5);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(txtModelo);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Nuevo_Cliente";
            Text = "Nuevo_Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private Label label2;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtModelo;
        private Label label5;
        private TextBox txtMarca;
        private Label label6;
        private TextBox txtPlaca;
    }
}