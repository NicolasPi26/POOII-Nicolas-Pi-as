using Sistema_Eventos.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Eventos.Forms
{
    public partial class FrmParticipantes : Form
    {
        private SistemaEventosContext db = new SistemaEventosContext();
        private int idParticipante = 0;
        public FrmParticipantes()
        {
            InitializeComponent();
        }
        private void CargarParticipantes()
        {
            dgvParticipantes.DataSource = null;
            dgvParticipantes.DataSource = db.Participantes.ToList();

            dgvParticipantes.Columns["Entrada"].Visible = false;
        }

        private void Limpiar()
        {
            idParticipante = 0;

            txtNombre.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

            txtNombre.Focus();
        }

        private void FrmParticipantes_Load(object sender, EventArgs e)
        {
            CargarParticipantes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtCedula.Text) ||
            string.IsNullOrWhiteSpace(txtCorreo.Text) ||
            string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Participante participante = new Participante();

            participante.Nombre = txtNombre.Text;
            participante.Cedula = txtCedula.Text;
            participante.Correo = txtCorreo.Text;
            participante.Telefono = txtTelefono.Text;

            db.Participantes.Add(participante);
            db.SaveChanges();

            MessageBox.Show("Participante guardado correctamente.");

            Limpiar();
            CargarParticipantes();
        }

        private void dgvParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvParticipantes.Rows[e.RowIndex];
                idParticipante = Convert.ToInt32(row.Cells["IdParticipante"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtCedula.Text = row.Cells["Cedula"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idParticipante == 0)
            {
                MessageBox.Show("Seleccione un participante para editar.");
                return;
            }

            Participante participante = db.Participantes.Find(idParticipante);

            if (participante != null)
            {
                participante.Nombre = txtNombre.Text;
                participante.Cedula = txtCedula.Text;
                participante.Correo = txtCorreo.Text;
                participante.Telefono = txtTelefono.Text;

                db.SaveChanges();

                MessageBox.Show("Participante editado correctamente.");

                Limpiar();
                CargarParticipantes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idParticipante == 0)
            {
                MessageBox.Show("Seleccione un participante para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este participante?",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Participante participante = db.Participantes.Find(idParticipante);
                if (participante != null)
                {
                    db.Participantes.Remove(participante);
                    db.SaveChanges();
                    MessageBox.Show("Participante eliminado correctamente.");
                    Limpiar();
                    CargarParticipantes();

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
