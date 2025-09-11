using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Empresa
    {
        ArrayList liquidaciones = new ArrayList();

        public int AñoActual { get; set; }

        int añoInicioContrato = 2020;

        public Empleado RegistrarEmpleado(string apell, string nombre, int dni)
        {
            Empleado nuevo = new Empleado(apell, nombre,dni, añoInicioContrato);
            liquidaciones.Add(nuevo);
            return nuevo;
        }

        public void GenerarLiquidaciones(int mes, int año) {

            Liquidacion nuevaLiquidacion;
            Empleado empleado;
            foreach(var item in liquidaciones)
            {
                if(item is Empleado)
                {
                    empleado = item as Empleado;
                    nuevaLiquidacion = new Liquidacion(empleado, 2025, 9, 4, 5);
                }
            }

        }

        public ArrayList ListarLiquidaciones( int año, int mes /*, ref int cantidad*/)
        {
            ArrayList soloLiquidaciones = new ArrayList();

            foreach(var item in liquidaciones)
            {
                if( item is Liquidacion)
                {
                    Liquidacion l = item as Liquidacion;
                    if(l.Mes == mes && l.Año == año) { soloLiquidaciones.Add(l); }
                }
            }

            return soloLiquidaciones;
        
        }

        public double VerMontoLiquidacionTotal(int mes , int año) 
        {
            double total = 0;
            ArrayList liquidaciones = ListarLiquidaciones(año, mes);
            foreach(Liquidacion l in liquidaciones)
            {
                total += l.ACobrar;
            }
            return total; 
        }

        public List<string> MostrarTodosReciboSueldo(int año, int mes  /*, int dni*/) 
        { 
            List<string> mostrar = new List<string>();

            foreach(var item in liquidaciones)
            {
                if(item is Liquidacion)
                {
                    Liquidacion li = item as Liquidacion;
                    if(li.Año == año && li.Mes == mes  ) { mostrar.Add(li.VerImpreso()); }

                }
            }
            return mostrar; 
        }

        public string MostrarReciboSueldoPorDNI(int dni, int año, int mes)
        {
            Liquidacion l;
            foreach(var item in liquidaciones)
            {
                if(item is Liquidacion)
                {
                    l = item as Liquidacion;
                    if(l.Año== año && l.Mes == mes && l.Empleado.DNI == dni) {  return l.VerImpreso(); } 

                }
            }
            return "No se encontro Empleado o Recibo";
        }


    }
}
