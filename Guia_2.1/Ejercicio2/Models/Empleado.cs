using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Empleado
    {
        public int DNI { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public string ApellidoNombre { get; private set; }
        public int AñoContrato { get; private set; }
        public double MontoBasicoNOminal { get; set; }
        public int HorasExtras50 { get;  set; }
        public int HorasExtras100 { get; set; }


        public Empleado(string apellido, string nombre , int añoContrato, int dni) {
            this.DNI = dni;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.AñoContrato = añoContrato;

        }


    }
}
