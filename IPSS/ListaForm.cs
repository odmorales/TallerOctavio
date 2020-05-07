using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace IPSS
{
    public partial class ListaForm : Form
    {
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        IList<Liquidacion> Liquidaciones;
        double Total, TotalLiquidado;
        public ListaForm()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void TipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoBox.SelectedItem.Equals("contributiva"))
            {
                Liquidaciones = liquidacionCuotaModeradoraService.MostrarLiquidacionPorTipo("Contributiva");
                Total = liquidacionCuotaModeradoraService.MostrarTotalLiquidacionesPorTipo("Contributiva");
                TotalLiquidado = liquidacionCuotaModeradoraService.TotalLiquidadTipo("Contributiva");
            } else if (TipoBox.SelectedItem.Equals("subsidiada"))
            {
                Liquidaciones = liquidacionCuotaModeradoraService.MostrarLiquidacionPorTipo("Subsidiada");
                Total = liquidacionCuotaModeradoraService.MostrarTotalLiquidacionesPorTipo("Subsidiada");
                TotalLiquidado = liquidacionCuotaModeradoraService.TotalLiquidadTipo("Subsidiada");
            }
            else
            {
                Liquidaciones = liquidacionCuotaModeradoraService.Mirar();
                Total = liquidacionCuotaModeradoraService.Mirar().Count();
                TotalLiquidado = liquidacionCuotaModeradoraService.TotalLiquidados();
            }
            LlenarTabla(Liquidaciones);
            PintarLabels(Total, TotalLiquidado);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Liquidaciones = liquidacionCuotaModeradoraService.ConsultarporFecha(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            LlenarTabla(Liquidaciones);
        }

        private void TablaLiquidaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PintarLabels(double total, double totalLiquidado)
        {
            TotalBox.Text = total + "";
            TotalLiquidadoTxt.Text = totalLiquidado + "";
        }

        private void LlenarTabla(IList<Liquidacion> liquidaciones)
        {
            TablaLiquidaciones.DataSource = liquidaciones;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            Liquidaciones = liquidacionCuotaModeradoraService.ConsultarPorNombre(BuscarTxt.Text);
            LlenarTabla(Liquidaciones);
        }

        private void BuscarTxt_TextChanged(object sender, EventArgs e)
        {
            Liquidaciones = liquidacionCuotaModeradoraService.ConsultarPorNombre(BuscarTxt.Text);
            LlenarTabla(Liquidaciones);
        }

    }
}
