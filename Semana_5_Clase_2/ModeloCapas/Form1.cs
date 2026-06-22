using ModeloCapas.CapaDatos;
using ModeloCapas.CapaLogica;

using System.Data;

namespace ModeloCapas
{
    public partial class Form1 : Form
    {
        private readonly VehiculosServicio _vehiculosServicio;

        public Form1()

        {
            InitializeComponent();
            _vehiculosServicio = new VehiculosServicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable tabla = new DataTable("Vehiculos Matriculados");

            tabla.Columns.Add("IdVehiculo", typeof(int));
            tabla.Columns.Add("Placa", typeof(string));
            tabla.Columns.Add("Marca", typeof(string));
            tabla.Columns.Add("Modelo", typeof(string));
            tabla.Columns.Add("Estado Matricula", typeof(bool));

            var lsmatriculas = _vehiculosServicio.todosVehiculosMatriculados();

            foreach (var item in lsmatriculas)
            {
                tabla.Rows.Add(
                    item.id,
                    item.VehiculoEntity.Placa,
                    item.VehiculoEntity.Marca,
                    item.VehiculoEntity.Modelo,
                    item.Estado 
                    );
            }

            ds.Tables.Add(tabla);

            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = ds.Tables["Vehiculos Matriculados"];
        }
    }
}
