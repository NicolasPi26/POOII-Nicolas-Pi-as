using Mecanicas_Tarean6_Nicolas_Piñas.Logica;
using Mecanicas_Tarean6_Nicolas_Piñas.Migrations;

namespace Mecanicas_Tarean6_Nicolas_Piñas
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
            LLena_lista();
        }
        public void LLena_lista()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = _clienteServicio.todos();
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "NombreCompleto";
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new Nuevo_Cliente();
            nuevo.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un item de la lista");
                return;
            }
            Program.idCliente = (int)listBox1.SelectedValue;

            var editar = new Editar_Cliente();

            if (editar.ShowDialog() == DialogResult.Cancel)
            {
                LLena_lista();
            }


        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un item de la lista");
                return;
            }
            Program.idCliente = (int)listBox1.SelectedValue;
            var frm_eliminar = new Eliminar_Cliente();
            if (frm_eliminar.ShowDialog() == DialogResult.Cancel)
            {
                LLena_lista();
            }
        }
    }
}
