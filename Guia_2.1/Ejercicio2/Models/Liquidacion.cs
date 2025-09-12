using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.Models
{
    internal class Liquidacion
    {
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public double MontoBasico { get
            {
                return Empleado.MontoBasicoNominal;
            }
            private set { } } // el valor de la hora es básico/40)
        public double PorcAntiguedad //el porcentaje de antigüedad se calcula en el getter
        {
            get
            {
                int tope = 30;

                double a = ((Año - Empleado.AñoContrato) / tope);
                return a;
            }

            private set { } } 
        public double MontoAntiguedad { 
            get 
            { 
                double monto = MontoBasico * PorcAntiguedad;
                return monto;

            } private set { } }
       
        public double HorasExtras50 { get; private set; }
        public double MontoExtras50 { get 
            {
                double precioPorHora = (MontoBasico / 40); //valor de la hora es básico/40
                double monto = (precioPorHora * 0.50) * HorasExtras50;
                return monto;

            } private set { } }
        public double HorasExtras100 { get; private set; }
        public double MontoExtras100 {
            get 
            {
                double precioPorHora = (MontoBasico / 40);
                return precioPorHora * HorasExtras100; 
            }

            private set { }
        }
        public double Nominal // es la suma de básico según su categoría, un porcentaje por antigüedad y una cantidad de horas extras realizadas al 50% y otras al 100%
        { 
            get 
            {
                return MontoBasico + MontoAntiguedad + MontoExtras50 + MontoExtras100;
            }

            private set { }
        } 

        #region Descuento a Nominal

        //Sobre el nominal se realizan los descuentos:

        public double PorcObraSocial { get; set; } // 3%
        public double PorcJubilado { get; set; } //18%
        public double PorcGremiales { get; set; } //1.5%


        public double MontoObraSocial  { get  {  return Nominal * PorcObraSocial; }private set { }}
        public double MontoJubilado { get { return Nominal * PorcJubilado;  } private set { } }
        public double MontoGremial { get { return Nominal * PorcGremiales; } private set { } }
        #endregion

        public double Neto // es el total menos los descuentos

        {
            get 
            {
                double total = Nominal - MontoObraSocial - MontoJubilado - MontoGremial;
                return total;
                    
            }
            private set { }
        } 
        public double Productividad  // //Sobre la diferencia obtenida se abona un plus de 30% en concepto de producción.
        {
            get
            {
                return Neto * 0.3; 
            }
            private set { } } 

        public double ACobrar { get { return Neto + Productividad; } private set { } }


        public Empleado Empleado { get; private set; }


        public Liquidacion(Empleado empleado, int año, int mes, int h50, int h100)
        {
            //El monto base en la liquidación se tomará del empleado en el momento de construcción de la liquidación
            Empleado = empleado;
            empleado.MontoBasicoNominal = 4000;
            //MontoBasico = 4000;
            PorcObraSocial = 0.03;
            PorcJubilado = 0.18;
            PorcGremiales = 0.015;

            HorasExtras50 = h50;
            HorasExtras100=  h100;

            Año = año;
            Mes = mes;


        }

        public List<string> VerImpreso()
        {
            List<string> resumen = new List<string>();
            resumen.Add($"Empleado {Empleado.Nombre}, {Empleado.Apellido}.");
            resumen.Add($"----------------------------------------------------------------------------------------");
            resumen.Add($"Concepto                Haberes             Descuentos ");
            resumen.Add($"Básico                  {MontoBasico} ");
            resumen.Add($"Antiguedad              {MontoAntiguedad}");
            resumen.Add($"Extras al 50%           {MontoExtras50} ");
            resumen.Add($"Extras al 100%          {MontoExtras100}");
            resumen.Add($"Obra Social                                 {MontoObraSocial} ");
            resumen.Add($"Jubilacion                                   {MontoJubilado}");
            resumen.Add($"Ap. Gremiales                               {MontoGremial}   ");
            resumen.Add($" Productividad           {Productividad}   ");
            resumen.Add($"");
            resumen.Add($"----------------------------------------------------------------------------------------");
            resumen.Add($" Ttotales                    {Neto}   ");
            resumen.Add($"----------------------------------------------------------------------------------------");
            resumen.Add($"  A Cobrar                {ACobrar}");

                                          
            return resumen; 
        
        
        }

    

    }
}
