namespace Sistema_Eventos.Forms
{
    partial class FrmReporte
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
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            btnBuscar = new Button();
            dgvReporte = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Reporte eventos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 2;
            label3.Text = "Fin";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(12, 108);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 4;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(12, 171);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 217);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(227, 50);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Size = new Size(268, 268);
            dgvReporte.TabIndex = 7;
            // 
            // FrmReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 330);
            Controls.Add(dgvReporte);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReporte";
            Text = "FrmReporte";
            Load += FrmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Button btnBuscar;
        private DataGridView dgvReporte;
    }
}