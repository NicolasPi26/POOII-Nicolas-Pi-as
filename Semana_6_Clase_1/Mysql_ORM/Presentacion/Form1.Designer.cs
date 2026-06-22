namespace Mysql_ORM
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
            btn_nuevo = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(26, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 259);
            listBox1.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(82, 342);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(102, 23);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo Cliente";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(82, 371);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(102, 23);
            btn_editar.TabIndex = 2;
            btn_editar.Text = "Editar Cliente";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(82, 400);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(102, 23);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar Cliente";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 442);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_nuevo);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btn_nuevo;
        private Button btn_editar;
        private Button btn_eliminar;
    }
}
