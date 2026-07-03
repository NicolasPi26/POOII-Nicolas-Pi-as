using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_libreria.Forms
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvReporte.DataSource = db.Ventar
                .GroupBy(v => v.FechaVenta.Value.Month)
                .Select(g => new
                {
                    Mes = g.Key,
                    LibrosVendidos = g.Sum(x => x.Cantidad),
                    TotalVentas = g.Sum(x => x.Total)
                }).ToList();
        }
    }
}
