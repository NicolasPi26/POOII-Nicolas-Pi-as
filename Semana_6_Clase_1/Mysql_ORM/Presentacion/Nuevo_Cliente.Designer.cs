namespace Mysql_ORM.Presentacion
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
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            txt_nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_apellido = new TextBox();
            label4 = new Label();
            txt_direccion = new TextBox();
            label5 = new Label();
            txt_telefono = new TextBox();
            label6 = new Label();
            txt_Correo = new TextBox();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(24, 308);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(93, 31);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(124, 308);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(93, 31);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Cliente";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(24, 67);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(193, 23);
            txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 49);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(24, 118);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(193, 23);
            txt_apellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 151);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Direccion";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(24, 169);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(193, 23);
            txt_direccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 203);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(24, 221);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(193, 23);
            txt_telefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 257);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "Correo";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(24, 275);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(193, 23);
            txt_Correo.TabIndex = 11;
            // 
            // Nuevo_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 362);
            Controls.Add(label6);
            Controls.Add(txt_Correo);
            Controls.Add(label5);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_direccion);
            Controls.Add(label3);
            Controls.Add(txt_apellido);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar);
            Name = "Nuevo_Cliente";
            Text = "Nuevo_Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private Button btn_cancelar;
        private Label label1;
        private TextBox txt_nombre;
        private Label label2;
        private Label label3;
        private TextBox txt_apellido;
        private Label label4;
        private TextBox txt_direccion;
        private Label label5;
        private TextBox txt_telefono;
        private Label label6;
        private TextBox txt_Correo;
    }
}