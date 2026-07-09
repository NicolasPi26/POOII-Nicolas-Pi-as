namespace Sistema_Eventos
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            participantesToolStripMenuItem = new ToolStripMenuItem();
            entradasToolStripMenuItem = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            eventosPorFechaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, eventosToolStripMenuItem, participantesToolStripMenuItem, entradasToolStripMenuItem, pagosToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(60, 20);
            eventosToolStripMenuItem.Text = "Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click;
            // 
            // participantesToolStripMenuItem
            // 
            participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            participantesToolStripMenuItem.Size = new Size(87, 20);
            participantesToolStripMenuItem.Text = "Participantes";
            // 
            // entradasToolStripMenuItem
            // 
            entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            entradasToolStripMenuItem.Size = new Size(64, 20);
            entradasToolStripMenuItem.Text = "Entradas";
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(51, 20);
            pagosToolStripMenuItem.Text = "Pagos";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventosPorFechaToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // eventosPorFechaToolStripMenuItem
            // 
            eventosPorFechaToolStripMenuItem.Name = "eventosPorFechaToolStripMenuItem";
            eventosPorFechaToolStripMenuItem.Size = new Size(168, 22);
            eventosPorFechaToolStripMenuItem.Text = "Eventos por fecha";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem participantesToolStripMenuItem;
        private ToolStripMenuItem entradasToolStripMenuItem;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem eventosPorFechaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
