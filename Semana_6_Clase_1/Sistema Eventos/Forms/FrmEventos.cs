using Sistema_Eventos.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Eventos.Forms
{
    public partial class FrmEventos : Form
    {
        private SistemaEventosContext db = new SistemaEventosContext();
        private int idEvento = 0;
        private void CargarEventos()
        {
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = db.Eventos.ToList();

            dgvEventos.Columns["Entrada"].Visible = false;
        }
        public FrmEventos()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            idEvento = 0;

            txtNombreEvento.Clear();
            txtLugar.Clear();
            txtCapacidad.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtNombreEvento.Focus();
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEvento.Text) ||
                string.IsNullOrWhiteSpace(txtLugar.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }
            Evento evento = new Evento();
            evento.NombreEvento = txtNombreEvento.Text;
            evento.Lugar = txtLugar.Text;

            evento.Fecha = DateOnly.FromDateTime(dtpFecha.Value);

            evento.Hora = TimeOnly.FromDateTime(dtpHora.Value);

            evento.Capacidad = int.Parse(txtCapacidad.Text);

            db.Eventos.Add(evento);
            db.SaveChanges();

            MessageBox.Show("Evento guardado correctamente.");

            Limpiar();

            CargarEventos();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idEvento == 0)
            {
                MessageBox.Show("Seleccione un evento para editar.");
                return;
            }

            Evento evento = db.Eventos.Find(idEvento);

            if (evento != null)
            {
                evento.NombreEvento = txtNombreEvento.Text;
                evento.Lugar = txtLugar.Text;
                evento.Fecha = DateOnly.FromDateTime(dtpFecha.Value);
                evento.Hora = TimeOnly.FromDateTime(dtpHora.Value);
                evento.Capacidad = int.Parse(txtCapacidad.Text);
                db.SaveChanges();

                MessageBox.Show("Evento editado correctamente.");

                Limpiar();
                CargarEventos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEvento == 0)
            {
                MessageBox.Show("Seleccione un evento para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Esta seguro que quiere eliminar este evento?",
                "Confrimar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Evento evento = db.Eventos.Find(idEvento);
                if (evento != null)
                {
                    db.Eventos.Remove(evento);
                    db.SaveChanges();
                    MessageBox.Show("Evento eliminado correctamente.");
                    Limpiar();
                    CargarEventos();
                }
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEventos.Rows[e.RowIndex];
                idEvento = Convert.ToInt32(fila.Cells["IdEventos"].Value);
                MessageBox.Show("ID:" + idEvento);

                txtNombreEvento.Text = fila.Cells["NombreEvento"].Value.ToString();
                txtLugar.Text = fila.Cells["Lugar"].Value.ToString();
                txtCapacidad.Text = fila.Cells["Capacidad"].Value.ToString();

                if (fila.Cells["Fecha"].Value is DateOnly fecha)
                {
                    dtpFecha.Value = fecha.ToDateTime(TimeOnly.MinValue);
                }

                if (fila.Cells["Hora"].Value is TimeOnly hora)
                {
                    dtpHora.Value = DateTime.Today.Add(hora.ToTimeSpan());
                }
            }
        }
    }
}
