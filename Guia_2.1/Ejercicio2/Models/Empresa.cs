using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.Models
{
    internal class Empresa
    {
        ArrayList liquidaciones = new ArrayList();
        ArrayList empleados = new ArrayList();

        public int AñoActual { get; set; }

        int añoInicioContrato = 2020;

        public Empleado RegistrarEmpleado(string apell, string nombre, int dni)
        {
            Empleado nuevo = new Empleado(apell, nombre,dni, añoInicioContrato);
            empleados.Add(nuevo);
            return nuevo;
        }

        public void GenerarLiquidaciones(int mes, int año) {

            Liquidacion nuevaLiquidacion;
            Empleado empleado;
            foreach(Empleado e in empleados)
            {
                if(e is Empleado)
                {
                    empleado = e as Empleado;
                    nuevaLiquidacion = new Liquidacion(empleado, año, mes, 4, 5);
                    //no estaba guardando la liquidacion

                    liquidaciones.Add(nuevaLiquidacion);
                }
            }

        }

        public ArrayList ListarLiquidaciones( int año, int mes /*, ref int cantidad*/)
        {
            ArrayList soloLiquidaciones = new ArrayList();

            foreach(Liquidacion l in liquidaciones)
            {
                if( l is Liquidacion)
                {
                    Liquidacion li = l as Liquidacion;
                    if(li.Mes == mes && li.Año == año) { soloLiquidaciones.Add(l); }
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

        public void MostrarTodosReciboSueldo(int año, int mes, ListBox lista  /*, int dni*/) 
        {
           List<string> mostrar ;

            foreach(Liquidacion l in liquidaciones)
            {
                if(l is Liquidacion)
                {
                    Liquidacion li = l as Liquidacion;
                    if(li.Año == año && li.Mes == mes  ) 
                    {
                        mostrar = li.VerImpreso();
                        foreach(string s in mostrar)
                        {
                            lista.Items.Add(s);
                        }
                    }

                }
            }
            
        }

        public string MostrarReciboSueldoPorDNI(int dni, int año, int mes, ListBox lista)
        {
            Liquidacion l;
            foreach(Liquidacion li in liquidaciones)
            {
                if(li is Liquidacion)
                {
                    l = li as Liquidacion;
                    if(l.Año== año && l.Mes == mes && l.Empleado.DNI == dni) { lista.Items.Add( l.VerImpreso()); } 

                }
            }
            return "No se encontro Empleado o Recibo";
        }


    }
}
