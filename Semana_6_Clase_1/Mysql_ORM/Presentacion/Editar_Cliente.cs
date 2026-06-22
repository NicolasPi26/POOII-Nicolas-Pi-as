using Mysql_ORM.Datos.Entidades;
using Mysql_ORM.Logica;

namespace Mysql_ORM.Presentacion
{
    public partial class Editar_Cliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Editar_Cliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes
            {
                apellido = txt_apellido.Text.Trim(),
                correo = txt_Correo.Text.Trim(),
                direccion = txt_direccion.Text.Trim(),
                nombre = txt_nombre.Text.Trim(),
                telefono = txt_telefono.Text.Trim(),
            };
            if (_clienteServicio.insertar(cliente) == "ok")
            {
                MessageBox.Show("Cliente Cuardado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Existio un error al guardar");
            }

        }
    }
}
