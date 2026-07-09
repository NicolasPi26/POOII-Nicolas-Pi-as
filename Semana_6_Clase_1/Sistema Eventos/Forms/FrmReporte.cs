using Sistema_Eventos.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Eventos.Forms
{

    public partial class FrmReporte : Form
    {
        private SistemaEventosContext db = new SistemaEventosContext();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void BuscarEvento()
        {
            DateOnly fechaInicio = DateOnly.FromDateTime(dtpInicio.Value);
            DateOnly fechaFin = DateOnly.FromDateTime(dtpFin.Value);
            var lista = db.Eventos
                .Where(e => e.Fecha >= fechaInicio && e.Fecha <= fechaFin)
                .Select(e => new
                {
                    e.IdEventos,
                    e.NombreEvento,
                    e.Fecha,
                    e.Lugar,
                    e.Hora,
                    e.Capacidad,
                })
                .ToList();
            dgvReporte.DataSource = lista;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporte.Columns["IdEventos"].HeaderText = "ID";
            dgvReporte.Columns["NombreEvento"].HeaderText = "Evento";
            dgvReporte.Columns["Fecha"].HeaderText = "Fecha";
            dgvReporte.Columns["Lugar"].HeaderText = "Lugar";
            dgvReporte.Columns["Hora"].HeaderText = "Hora";
            dgvReporte.Columns["Capacidad"].HeaderText = "Capacidad";
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            BuscarEvento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEvento();
        }
    }
}
