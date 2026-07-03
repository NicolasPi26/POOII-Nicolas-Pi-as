using Sistema_libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_libreria.Forms
{
    public partial class FrmVentas : Form
    {
        private LibreriaContext db = new LibreriaContext();
        private int idVenta = 0;
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarLibros();
            CargarVentas();
        }
        private void CargarLibros()
        {
            cbLibro.DataSource = db.Libros.ToList();
            cbLibro.DisplayMember = "Titulo";
            cbLibro.ValueMember = "IdLibro";
        }
        private void CargarVentas()
        {
            dgvVentas.DataSource = db.Ventas.Include(v => v.IdLibroNavigation)
                .Select(v => new
                {
                    v.IdVenta,
                    v.FechaVenta,
                    Libro = v.IdLibroNavigation.Titulo,
                    v.Cantidad,
                    v.Total
                })
                .ToList();
        }
        private void Limpiar()
        {
            txtCantidad.Clear();
            txtTotal.Clear();
            cbLibro.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            idVenta = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad");
                return;
            }

            Libro libro = db.Libros.Find(Convert.ToInt32(cbLibro.SelectedValue));
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            if (libro.Stock < cantidad)
            {
                MessageBox.Show("No hay suficiente stock del libro seleccionado");
                return;
            }

            decimal total = libro.Precio.Value * cantidad;
            Venta venta = new Venta();
            venta.IdLibro = libro.IdLibro;
            venta.Cantidad = cantidad;
            venta.FechaVenta = DateOnly.FromDateTime(dtpFecha.Value);
            venta.Total = total;
            db.Ventas.Add(venta);
            libro.Stock -= cantidad;
            db.SaveChanges();
            txtTotal.Text = total.ToString();
            MessageBox.Show("Venta registrada correctamente");
            CargarVentas();
            Limpiar();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idVenta = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["IdVenta"].Value);
                Venta venta = db.Ventas.Find(idVenta);

                if (venta == null)
                {
                    cbLibro.SelectedValue = venta.IdLibro;
                    txtCantidad.Text = venta.Cantidad.ToString();
                    txtTotal.Text = venta.Total.ToString();
                    dtpFecha.Value = venta.FechaVenta.Value.ToDateTime(TimeOnly.MinValue);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idVenta == 0)
            {
                MessageBox.Show("Seleccione una venta para eliminar");
                return;
            }

            Venta venta = db.Ventas.Find(idVenta);

            if (venta != null)
            {
                Libro libro = db.Libros.Find(venta.IdLibro);
                libro.Stock += venta.Cantidad.Value;
                db.Ventas.Remove(venta);
                db.SaveChanges();
                MessageBox.Show("Venta eliminada correctamente");
                CargarVentas();
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
