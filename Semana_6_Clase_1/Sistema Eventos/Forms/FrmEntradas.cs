using Sistema_Eventos.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Eventos.Forms
{
    public partial class FrmEntradas : Form
    {
        private SistemaEventosContext db = new SistemaEventosContext();
        private int idEntrada = 0;
        public FrmEntradas()
        {
            InitializeComponent();
        }
        private void CargarEventos()
        {
            cmbEvento.DataSource = db.Eventos.ToList();
            cmbEvento.DisplayMember = "NombreEvento";
            cmbEvento.ValueMember = "IdEvento";
        }

        private void CargarParticipantes()
        {
            cmbParticipante.DataSource = db.Participantes.ToList();
            cmbParticipante.DisplayMember = "Nombre";
            cmbParticipante.ValueMember = "IdParticipante";
        }

        private void CargarEntradas()
        {
            dgvEntradas.DataSource = db.Entradas
                .Include(e => e.IdEventosNavigation)
                .Include(e => e.IdParticipanteNavigation)
                .Select(e => new
                {
                    e.IdEntrada,
                    Evento = e.IdEventosNavigation.NombreEvento,
                    Participante = e.IdParticipanteNavigation.Nombre,
                    e.TipoEntrada,
                    e.Precio,
                    e.FechaCompra
                })
                .ToList();
        }

        private void Limpiar()
        {
            idEntrada = 0;
            cmbEvento.SelectedIndex = 0;
            cmbParticipante.SelectedIndex = 0;
            txtTipo.Clear();
            txtPrecio.Clear();
            dtpFechaCompra.Value = DateTime.Now;
        }
        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            CargarEventos();
            CargarParticipantes();
            CargarEntradas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();

            entrada.IdEventos = Convert.ToInt32(cmbEvento.SelectedValue);
            entrada.IdParticipante = Convert.ToInt32(cmbParticipante.SelectedValue);
            entrada.TipoEntrada = txtTipo.Text;
            entrada.Precio = decimal.Parse(txtPrecio.Text);
            entrada.FechaCompra = dtpFechaCompra.Value;
            db.Entradas.Add(entrada);
            db.SaveChanges();
            MessageBox.Show("Entrada guardada correctamente.");
            Limpiar();
            CargarEntradas();
        }

        private void dgvEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEntrada = Convert.ToInt32(dgvEntradas.Rows[e.RowIndex].Cells["IdEntrada"].Value);

                Entrada entrada = db.Entradas.Find(idEntrada);
                cmbEvento.SelectedValue = entrada.IdEventos;
                cmbParticipante.SelectedValue = entrada.IdParticipante;
                txtTipo.Text = entrada.TipoEntrada;
                txtPrecio.Text = entrada.Precio.ToString();
                dtpFechaCompra.Value = entrada.FechaCompra.Value;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idEntrada == 0)
            {
                MessageBox.Show("Seleccione una entrada para editar.");
                return;
            }

            Entrada entrada = db.Entradas.Find(idEntrada);
            entrada.IdEventos = Convert.ToInt32(cmbEvento.SelectedValue);
            entrada.IdParticipante = Convert.ToInt32(cmbParticipante.SelectedValue);
            entrada.TipoEntrada = txtTipo.Text;
            entrada.Precio = decimal.Parse(txtPrecio.Text);
            entrada.FechaCompra = dtpFechaCompra.Value;
            db.SaveChanges();
            MessageBox.Show("Entrada editada correctamente.");
            Limpiar();
            CargarEntradas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEntrada == 0)
            {
                MessageBox.Show("Seleccione una entrada para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta entrada?",
                "Confirmar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Entrada entrada = db.Entradas.Find(idEntrada);
                db.Entradas.Remove(entrada);
                db.SaveChanges();
                MessageBox.Show("Entrada eliminada correctamente.");
                Limpiar();
                CargarEntradas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
