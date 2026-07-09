using Sistema_Eventos.Forms;

namespace Sistema_Eventos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEventos frm = new FrmEventos();
            frm.ShowDialog();
        }
    }
}
