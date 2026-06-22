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
    public partial class Nuevo_Cliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Nuevo_Cliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes
            {
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                modelo = txtModelo.Text.Trim(),
                marca = txtMarca.Text.Trim(),
                placa = txtPlaca.Text.Trim(),
            };
            if (_clienteServicio.insertar(cliente) == "ok")
            {
                MessageBox.Show("Cliente Guardado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Existio un error al guardar");
            }
        }
    }
}
