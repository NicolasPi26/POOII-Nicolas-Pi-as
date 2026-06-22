namespace Mecanicas_Tarean6_Nicolas_Piñas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btn_Nuevo = new Button();
            btn_Editar = new Button();
            btn_eliminar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(398, 244);
            listBox1.TabIndex = 0;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Location = new Point(136, 272);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(155, 33);
            btn_Nuevo.TabIndex = 1;
            btn_Nuevo.Text = "Nuevo Vehiculo";
            btn_Nuevo.UseVisualStyleBackColor = true;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(136, 315);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(155, 33);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar Cliente";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(136, 358);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(155, 33);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar Cliente";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 405);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Nuevo);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btn_Nuevo;
        private Button btn_Editar;
        private Button btn_eliminar;
    }
}
