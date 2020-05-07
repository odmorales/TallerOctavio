using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        private string ruta = "Liquidacion.txt";
        public IList<Liquidacion> Liquidaciones;

        public LiquidacionCuotaModeradoraRepository()
        {
           Liquidaciones = new List<Liquidacion>();
        }

        public void Guardar(Liquidacion liquidacion)
        {        
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);    
                escritor.WriteLine($"{liquidacion.Nombre};{liquidacion.Identificacion};{liquidacion.Salario};{liquidacion.TipoAfiliacion};{liquidacion.ValorServicio};{liquidacion.NumeroLiquidacion}" +
                    $";{liquidacion.CuotaModeradora};{liquidacion.Tarifa};{liquidacion.Tope};{liquidacion.Fecha}");
            escritor.Close();
            file.Close();
        }

        public IList<Liquidacion> Consultar()
        {
           Liquidaciones = new List<Liquidacion>();
            string Line = string.Empty;
            FileStream sourceStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            while ((Line = reader.ReadLine()) != null)
            {

                Liquidacion liquidacion;
                char separador = ';';
                string[] Datos = Line.Split(separador);
                if(Datos[3].Equals("CONTRIBUTIVO"))
                     liquidacion = new LiquidacionContributiva(0);
                else
                liquidacion = new LiquidacionSubsidada(0);
                liquidacion.Nombre = Datos[0];
                liquidacion.Identificacion = Datos[1];
                liquidacion.Salario = Convert.ToDouble(Datos[2]);
                liquidacion.TipoAfiliacion = Datos[3];
                liquidacion.ValorServicio = Convert.ToDouble(Datos[4]);
                liquidacion.NumeroLiquidacion = Convert.ToInt32(Datos[5]);
                liquidacion.CuotaModeradora = Convert.ToDouble(Datos[6]);
                liquidacion.Tarifa = Convert.ToDouble(Datos[7]);
                liquidacion.Tope = Convert.ToDouble(Datos[8]);
                liquidacion.Fecha = Convert.ToDateTime(Datos[9]);
                Liquidaciones.Add(liquidacion);
            }
            reader.Close();
            sourceStream.Close();
            return Liquidaciones;
        }

        public IList<Liquidacion> MostrarLiquidacionPorTipo(String tipoLiquidacion)
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipoLiquidacion)).ToList();
        }

        public int MostrarTotalLiquidacionesPorTipo(string tipoLiquidacion)
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipoLiquidacion)).Count();
        }

        public IList<Liquidacion> ConsultarporFecha(int Mes, int Ann)
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Where(l => ((l.Fecha.Year) == Ann && (l.Fecha.Month == Mes))).ToList();
        }

        public double TotalLiquidadoTipo(string tipoLiquidacion)
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipoLiquidacion)).Sum(l => l.CuotaModeradora);
        }

        public double TotalLiquidaciones()
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Sum(l => l.CuotaModeradora);
        }

        public IList<Liquidacion> ConsultarPorNombre(string buscar)
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Where(l => l.Nombre.Contains(buscar)).ToList();
        }

        public IList<Liquidacion> ConsultarLiquidaciones(string Identificacion)
        {
            Liquidaciones = Consultar();
            return Liquidaciones.Where(l => l.Identificacion.Equals(Identificacion)).ToList();
        }



        public Liquidacion Buscar(string identificacion)
        {

            Liquidaciones = Consultar();
            foreach (var item in Liquidaciones)
            {
                if (item.Identificacion.Equals(identificacion))
                {                
                    return item;
                }
            }
            return null;
        }

        public void Modificar(Liquidacion liquidacion)
        {
            Liquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in Liquidaciones)
            {
                if (item.Identificacion == liquidacion.Identificacion)
                {
                    Guardar(liquidacion);
                }
                else
                {
                    Guardar(item);
                }    
            }
        }

        public void Eliminar(Liquidacion liquidacion)
        {
            Liquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in Liquidaciones)
            {
                if (item.Identificacion != liquidacion.Identificacion)
                {
                    Guardar(item);
                }   
            }
        }

       

    }
}
