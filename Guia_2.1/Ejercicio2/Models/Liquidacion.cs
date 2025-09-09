using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Liquidacion
    {
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public double MontoBasico { get; private set; } // el valor de la hora es básico/40)
        public double PorcAntiguedad { get; private set; }
        public double MontoAntiguedad { get; private set; }
        public double HorasExtras50 { get; private set; }
        public double MontoExtras50 { get; private set; }
        public double HorasExtras100 { get; private set; }
        public double MontoExtras100 { get; private set; }
        public double Nominal {  get; private set; } // es la suma de básico según su categoría, un porcentaje por antigüedad y una cantidad de horas extras realizadas al 50% y otras al 100%

        #region Descuento a Nominal

        //Sobre el nominal se realizan los descuentos:

        public double PorcObraSocial { get; set; } // 3%
        public double PorcJubilado { get; set; } //18%
        public double PorcGremiales { get; set; } //1.5%


        public double MontoObraSocial  { get; private set; }
        public double MontoJubilado { get; private set; }
        public double MontoGremial { get; private set; }
        #endregion

        public double Neto { get; private set; } // es el total menos los descuentos
        public double Productividad { get; private set; } //Sobre la diferencia obtenida se abona un plus de 30% en concepto de producción.

        public double ACobrar { get; private set; }


        public Empleado Empleado { get; private set; }


        public Liquidacion(Empleado empleado, int año, int mes, int h50, int h100)
        {
            MontoBasico = 4000;
            PorcJubilado = 0.03;
            PorcJubilado = 0.18;
            PorcGremiales = 0.015;


        }

        public string VerImpreso() { return ""; }

    

    }
}
