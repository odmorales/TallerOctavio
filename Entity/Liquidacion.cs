using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Liquidacion 
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public string TipoAfiliacion { get; set; }
        public int NumeroLiquidacion { get; set; }
        public double CuotaModeradora { get; set; }
        public double ValorServicio { get; set; }
        public DateTime Fecha{ get; set; }
        public double Tarifa { get; set; }
        public double Tope { get; set; }

        public Liquidacion(double salario)
        {
            Salario = salario;
        }
        public abstract void CalcularTarifa();
        public abstract void CalcularTopeMaximo();

        public double CalcularCuotaModeradora()
        {
            double cuotaModeradora;
             CalcularTopeMaximo();
             CalcularTarifa();

            cuotaModeradora = Tarifa * ValorServicio;
            if (Tope < cuotaModeradora)
            {
                cuotaModeradora = Tope;
            }
            return cuotaModeradora;
        }
    }
}
