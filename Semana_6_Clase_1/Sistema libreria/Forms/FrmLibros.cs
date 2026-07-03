using Sistema_libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_libreria.Forms
{
    public partial class FrmLibros : Form
    {
        private LibreriaContext db = new LibreriaContext();
        private int idLibro = 0;
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarDatos();
        }
        private void CargarProveedores()
        {
            cbProveedor.DataSource = db.Proveedores.ToList();
            cbProveedor.DisplayMember = "Nombre";
            cbProveedor.ValueMember = "IdProveedor";
        }
        private void CargarDatos()
        {
            dgvLibros.DataSource = db.Libros.Include(l => l.IdProveedorNavigation).Select(l => new
            {
                l.IdLibro,
                l.Titulo,
                l.Autor,
                l.Precio,
                l.Stock,
                Proveedor = l.IdProveedorNavigation.Nombre
            }).ToList();

            dgvLibros.Columns["IdLibro"].HeaderText = "Codigo";
            dgvLibros.Columns["Titulo"].HeaderText = "Titulo";
            dgvLibros.Columns["Autor"].HeaderText = "Autor";
            dgvLibros.Columns["Precio"].HeaderText = "Precio";
            dgvLibros.Columns["Stock"].HeaderText = "Stock";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el titulo del libro");
                txtTitulo.Focus();
                return;
            }
            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el precio del libro");
                txtPrecio.Focus();
                return;
            }
            if (txtStock.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el stock del libro");
                txtStock.Focus();
                return;
            }

            Libro libro = new Libro();

            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;

            libro.Precio = Convert.ToDecimal(txtPrecio.Text);

            libro.Stock = Convert.ToInt32(txtStock.Text);

            libro.IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue);

            db.Libros.Add(libro);

            db.SaveChanges();

            MessageBox.Show("Libro registrado.");

            CargarDatos();

            Limpiar();
        }
        private void Limpiar()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cbProveedor.SelectedIndex = 0;
            idLibro = 0;
            txtTitulo.Focus();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idLibro = Convert.ToInt32(dgvLibros.Rows[e.RowIndex].Cells["IdLibro"].Value);

                Libro libro = db.Libros.Find(idLibro);

                if (libro != null)
                {
                    txtTitulo.Text = libro.Titulo;
                    txtAutor.Text = libro.Autor;
                    txtPrecio.Text = libro.Precio.ToString();
                    txtStock.Text = libro.Stock.ToString();
                    cbProveedor.SelectedValue = libro.IdProveedor;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idLibro == 0)
            {
                MessageBox.Show("Seleccione un libro para actualizar");
                return;
            }

            Libro libro = db.Libros.Find(idLibro);
            if (libro != null)
            {
                libro.Titulo = txtTitulo.Text;
                libro.Autor = txtAutor.Text;
                libro.Precio = Convert.ToDecimal(txtPrecio.Text);
                libro.Stock = Convert.ToInt32(txtStock.Text);
                libro.IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue);
                db.SaveChanges();
                MessageBox.Show("Libro actualizado correctamente");
                CargarDatos();
                Limpiar();

            }
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            if (idLibro == 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar");
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el libro?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Libro libro = db.Libros.Find(idLibro);
                if (libro != null)
                {
                    db.Libros.Remove(libro);
                    db.SaveChanges();
                    MessageBox.Show("Libro eliminado correctamente");
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
