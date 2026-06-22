using Mysql_ORM.Datos.Entidades;
using Mysql_ORM.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mysql_ORM.Presentacion
{
    public partial class Nuevo_Cliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Nuevo_Cliente()
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
