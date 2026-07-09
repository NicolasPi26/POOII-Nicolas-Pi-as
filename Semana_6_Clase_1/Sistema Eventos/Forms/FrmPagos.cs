using Sistema_Eventos.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Eventos.Forms
{
    public partial class FrmPagos : Form
    {
        private SistemaEventosContext db = new SistemaEventosContext();
        private int idPago = 0;
        public FrmPagos()
        {
            InitializeComponent();
        }
        private void CargarEntradas()
        {
            var lista = db.Entradas
                .Include(e => e.IdEventosNavigation)
                .Include(e => e.IdParticipanteNavigation)
                .Select(e => new
                {
                    e.IdEntrada,
                    Descipcion = "Entrada #" + e.IdEntrada + " - " +
                    e.IdEventosNavigation.NombreEvento + " - " +
                    e.IdParticipanteNavigation.Nombre
                })
                .ToList();
            cmbEntrada.DataSource = lista;
            cmbEntrada.DisplayMember = "Descripcion";
            cmbEntrada.ValueMember = "IdEntrada";
        }

        private void CargarPagos()
        {
            dgvPagos.DataSource = db.Pagos
                .Include(p => p.IdEntradaNavigation)
                .Select(p => new
                {
                    p.IdPago,
                    Entrada = "Entrada #" + p.IdEntrada + " - " +
                    p.IdEntradaNavigation.IdEventosNavigation.NombreEvento + " - " +
                    p.IdEntradaNavigation.IdParticipanteNavigation.Nombre,
                    p.Monto,
                    p.FechaPago
                })
                .ToList();
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Limpiar()
        {
            idPago = 0;
            if (cmbEntrada.Items.Count > 0)
                cmbEntrada.SelectedIndex = 0;
            txtMetodo.Clear();
            txtMonto.Clear();
            dtpFechaPago.Value = DateTime.Now;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            CargarEntradas();
            CargarPagos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMetodo.Text) ||
            string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Pago pago = new Pago();

            pago.IdEntrada = Convert.ToInt32(cmbEntrada.SelectedValue);
            pago.MetodoPago = txtMetodo.Text;
            pago.Monto = decimal.Parse(txtMonto.Text);
            pago.FechaPago = dtpFechaPago.Value;
            db.Pagos.Add(pago);
            db.SaveChanges();
            MessageBox.Show("Pago guardado correctamente.");
            Limpiar();
            CargarPagos();
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPago = Convert.ToInt32(dgvPagos.Rows[e.RowIndex].Cells["IdPago"].Value);
                Pago pago = db.Pagos.FirstOrDefault(x => x.IdPago == idPago);
                if (pago != null)
                {
                    cmbEntrada.SelectedValue = pago.IdEntrada;
                    txtMetodo.Text = pago.MetodoPago;
                    txtMonto.Text = pago.Monto.ToString();
                    dtpFechaPago.Value = pago.FechaPago.Value;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idPago == 0)
            {
                MessageBox.Show("Seleccione un pago para editar.");
                return;
            }
            Pago pago = db.Pagos.FirstOrDefault(x => x.IdPago == idPago);
            if (pago != null)
            {
                pago.IdEntrada = Convert.ToInt32(cmbEntrada.SelectedValue);
                pago.MetodoPago = txtMetodo.Text;
                pago.Monto = decimal.Parse(txtMonto.Text);
                pago.FechaPago = dtpFechaPago.Value;
                db.SaveChanges();
                MessageBox.Show("Pago editado correctamente.");
                Limpiar();
                CargarPagos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPago == 0)
            {
                MessageBox.Show("Seleccione un pago para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este pago?",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Pago pago = db.Pagos.FirstOrDefault(x => x.IdPago == idPago);
                if (pago != null)
                {
                    db.Pagos.Remove(pago);
                    db.SaveChanges();
                    MessageBox.Show("Pago eliminado correctamente.");
                    Limpiar();
                    CargarPagos();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
