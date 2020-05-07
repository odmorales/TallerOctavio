using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace IPSS
{
    public partial class AgregarLiquidacion : Form
    {
        String Identificacion, TipoLiquidacion;
        Liquidacion liquidacion;
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        IList<Liquidacion> listaLiquidaciones;
        public AgregarLiquidacion()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Identificacion = IdentificacionTxt.Text;
            TipoLiquidacion = tipoBox.SelectedItem.ToString();
            liquidacion = liquidacionCuotaModeradoraService.Buscar(Identificacion);
            if (liquidacion != null)
            {
                MessageBox.Show("REGISTRO EXITOSO", "DANGER" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                if (TipoLiquidacion.Equals("CONTRIBUTIVO"))
                {
                    liquidacion = new LiquidacionContributiva(0);
                } else
                {
                    liquidacion = new LiquidacionSubsidada(0);
                }
                listaLiquidaciones = liquidacionCuotaModeradoraService.Mirar();
                liquidacion.Nombre = NombreTxt.Text;
                liquidacion.Identificacion = Identificacion;
                liquidacion.Salario = Convert.ToDouble(SalarioTxt.Text);
                liquidacion.ValorServicio = Convert.ToDouble(ValorServicioTxt.Text);
                liquidacion.NumeroLiquidacion = listaLiquidaciones.Count() + 1;
                liquidacion.CuotaModeradora = liquidacion.CalcularCuotaModeradora();
                liquidacion.Fecha = LiquidacionFecha.Value.Date;
                MessageBox.Show(liquidacionCuotaModeradoraService.AgregarPaciente(liquidacion), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
