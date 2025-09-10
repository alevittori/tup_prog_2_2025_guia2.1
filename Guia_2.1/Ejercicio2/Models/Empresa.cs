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

        public Empleado RegistrarEmpleado(string apell, string nombre)
        {
            Empleado nuevo = new Empleado(apell, nombre, añoInicioContrato);
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
                    empleado = (Empleado)item;
                    nuevaLiquidacion = new Liquidacion(empleado, 2025, 9, 4, 5);
                }
            }

        }

        public ArrayList ListarLiquidaciones(int mes, int año,  ref int cantidad) { return null; }

        public double VerMontoLiquidacionTotal(int mes , int año) {  return 0; }

        public string MostrarReciboSueldo(int año, int mes , int dni) { return null; }


    }
}
