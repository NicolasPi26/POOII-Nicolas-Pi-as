using Sistema_libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_libreria.Forms
{
    public partial class FrmProveedores : Form
    {
        private LibreriaContext db = new LibreriaContext();
        private int idProveedor = 0;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProveedores.DataSource = db.Proveedores.ToList();

            dgvProveedores.Columns["IdProveedor"].HeaderText = "Codigo";
            dgvProveedores.Columns["Nombre"].HeaderText = "Proveedor";
            dgvProveedores.Columns["Telefono"].HeaderText = "Telefono";
            dgvProveedores.Columns["Correo"].HeaderText = "Correo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del proveedor");
                return;

            }

            Proveedore proveedor = new Proveedore();

            proveedor.Nombre = txtNombre.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Correo = txtCorreo.Text;

            db.Proveedores.Add(proveedor);
            db.SaveChanges();

            MessageBox.Show("Proveedor agregado correctamente");

            CargarDatos();

            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            idProveedor = 0;

            txtNombre.Focus();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
                idProveedor = Convert.ToInt32(fila.Cells["IdProveedor"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idProveedor == 0)
            {
                MessageBox.Show("Seleccione un proveedor para actualizar");
                return;
            }

            Proveedore proveedor = db.Proveedores.Find(idProveedor);

            if (proveedor != null)
            {
                proveedor.Nombre = txtNombre.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Correo = txtCorreo.Text;
                db.SaveChanges();
                MessageBox.Show("Proveedor actualizado correctamente");
                CargarDatos();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProveedor == 0)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el proveedor?",
                "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Proveedore proveedor = db.Proveedores.Find(idProveedor);

                if (proveedor != null)
                {
                    db.Proveedores.Remove(proveedor);
                    db.SaveChanges();
                    MessageBox.Show("Proveedor eliminado correctamente");
                    CargarDatos();
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
