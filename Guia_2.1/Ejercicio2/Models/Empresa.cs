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


        public Empleado RegistrarEmpleado(string apell, string nombre, int dni)
        {
            return null;
        }

        public void GenerarLiquidaciones(int mes, int año) { }

        public ArrayList ListarLiquidaciones(int mes, int año,  ref int cantidad) { return null; }

        public double VerMontoLiquidacionTotal(int mes , int año) {  return 0; }

        public string MostrarReciboSueldo(int año, int mes , int dni) { return null; }


    }
}
