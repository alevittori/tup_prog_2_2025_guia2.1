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
        List<Liquidacion> liquidaciones = new List<Liquidacion> { };
        ArrayList empleados = new ArrayList();

        public int AñoActual { get; set; }

        int añoInicioContrato = 2020;

        public Empleado RegistrarEmpleado(string apell, string nombre, int dni)
        {
            Empleado nuevo = new Empleado(apell, nombre,dni, añoInicioContrato);
            empleados.Add(nuevo);
            return nuevo;
        }

        #region PARA PRUEBA
        public void listarEmpleados ( ListBox lista)
        {
            lista.Items.Clear();
            foreach (Empleado e in empleados)
            {
                lista.Items.Add(e.ToString());
            }
        }
        public void listarLiquidacion(ListBox lista)
        {
            lista.Items.Clear();
            foreach (Liquidacion l in liquidaciones)
            {
                lista.Items.Add(l.ToString());
            }
        }


        #endregion

        //para probar

        public void GenerarLiquidaciones(int mes, int año) {

            Liquidacion nuevaLiquidacion;
            Empleado empleado;

            foreach(Empleado e in empleados)
            {
                empleado = e as Empleado;
                bool yaLiquido = liquidaciones.Exists(l => l.Empleado == empleado);
               // MessageBox.Show($"Ya liquido ese epleado?  {yaLiquido}");
                if(! yaLiquido)
                {
                    nuevaLiquidacion = new Liquidacion(empleado, año, mes, 4, 5);
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
