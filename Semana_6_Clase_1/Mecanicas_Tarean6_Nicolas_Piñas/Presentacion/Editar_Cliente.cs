using Mecanicas_Tarean6_Nicolas_Piñas.Data.Entidades;
using Mecanicas_Tarean6_Nicolas_Piñas.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mecanicas_Tarean6_Nicolas_Piñas.Migrations
{
    public partial class Editar_Cliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Editar_Cliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var existe = _clienteServicio.uno(Program.idCliente);
            if (existe == null)
            {
                MessageBox.Show("Cliente no encontrado");
                this.Close();
            }

            existe.nombre = txtNombre.Text.Trim();
            existe.apellido = txtApellido.Text.Trim();
            existe.modelo = txtModelo.Text.Trim();
            existe.marca = txtMarca.Text.Trim();
            existe.placa = txtPlaca.Text.Trim();
            existe.id = Program.idCliente;
           
            if (_clienteServicio.actualizar(existe) == "ok")
            {
                MessageBox.Show("Cliente actualizado");
                Program.resultado_Dialog = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Existio un error al actualizar");
            }
        }

        private void Editar_Cliente_Load(object sender, EventArgs e)
        {
            CargaCliente();
        }
        public void CargaCliente()
        {
            var cliente = _clienteServicio.uno(Program.idCliente);
            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                
                this.Close();
            }                
            else
            {
                txtApellido.Text = cliente.apellido;
                txtNombre.Text = cliente.nombre;
                txtModelo.Text = cliente.modelo;
                txtMarca.Text = cliente.marca;
                txtPlaca.Text = cliente.placa;
            }
        }
    }
}
