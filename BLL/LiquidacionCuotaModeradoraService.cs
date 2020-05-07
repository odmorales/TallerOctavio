using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public  class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository;
        Liquidacion liquidacion;
        List<Liquidacion> Liquidaciones;
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
            Mirar();
        }
        

        public Liquidacion Buscar(string identificacion)
        {
            liquidacion = liquidacionCuotaModeradoraRepository.Buscar(identificacion);
            return liquidacion;
        }

        public IList<Liquidacion> Mirar()
        {
            Liquidaciones = liquidacionCuotaModeradoraRepository.Consultar().ToList();
            return Liquidaciones;
        }

        public String AgregarPaciente(Liquidacion liquidacion)
        {  
            liquidacionCuotaModeradoraRepository.Guardar(liquidacion);
            return " agregada Correctamente";
        }

        public string Modificar( Liquidacion liquidacionNueva)
        {
            liquidacionCuotaModeradoraRepository.Modificar( liquidacionNueva);
            return " Modificada correctamente";
        }

        public string Eliminar(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.Eliminar(liquidacion);
            return "Eliminada correctamente";
        }

        public IList<Liquidacion> MostrarLiquidacionPorTipo(string tipoLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.MostrarLiquidacionPorTipo(tipoLiquidacion);
        }

        public int MostrarTotalLiquidacionesPorTipo(string tipoLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.MostrarTotalLiquidacionesPorTipo(tipoLiquidacion);
        }

        public double TotalLiquidadTipo(string tipoLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.TotalLiquidadoTipo(tipoLiquidacion);
        }

        public double TotalLiquidados()
        {
            return liquidacionCuotaModeradoraRepository.TotalLiquidaciones();
        }

        public IList<Liquidacion> ConsultarporFecha(int Mes, int Ann)
        {
            return liquidacionCuotaModeradoraRepository.ConsultarporFecha(Mes, Ann);
        }

        public IList<Liquidacion> ConsultarPorNombre(string buscar)
        {
            return liquidacionCuotaModeradoraRepository.ConsultarPorNombre(buscar);
        }

        public IList<Liquidacion> ConsultarLiquidaciones(string Identificacion)
        {
            return liquidacionCuotaModeradoraRepository.ConsultarLiquidaciones(Identificacion);
        }
    }
}
