using Mysql_ORM.Logica;
using Mysql_ORM.Presentacion;

namespace Mysql_ORM
{
    public partial class Form1 : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Form1()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Llena_lista();
        }
        public void Llena_lista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _clienteServicio.todos();
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "NombreCompleto";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new Nuevo_Cliente();
            nuevo.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var editar = new Editar_Cliente();
            editar.ShowDialog();
        }
    }
}
