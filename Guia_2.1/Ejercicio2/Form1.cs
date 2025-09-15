using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Empresa laEmpresa;
        // HACKORDEADOS, despues podemos solicitarlo por sistema
        int año = 2025;
        int mes = 7;



        public Form1()
        {
            InitializeComponent();
            laEmpresa = new Empresa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCargaEmpleado VCargarEmpleado = new FCargaEmpleado();

            if (VCargarEmpleado.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(VCargarEmpleado.tbNombre.Text)) { MessageBox.Show("Completar NOmbre "); return; }
                if (string.IsNullOrEmpty(VCargarEmpleado.tbApellido.Text)) { MessageBox.Show("Completar Apellido "); return; }
                if (string.IsNullOrEmpty(VCargarEmpleado.tbDNI.Text)) { MessageBox.Show("Completar DNI"); return; }

                string nombre = VCargarEmpleado.tbNombre.Text;
                string apellido = VCargarEmpleado.tbApellido.Text;
                int dni = Convert.ToInt32(VCargarEmpleado.tbDNI.Text);
               
                Empleado nuevo  = laEmpresa.RegistrarEmpleado(apellido,nombre,dni);

                MessageBox.Show($"Se Registro Correctamente a {nuevo.ApellidoNombre}.","Exito!");

            }
            else { MessageBox.Show("Algo salio mal", "Atencion!"); }
            
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
          

            laEmpresa.GenerarLiquidaciones(mes, año);
            MessageBox.Show($"Se realizo liquidacion del mes {mes} del años {año}","Operacion Exitosa");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbDetalle.Items.Clear();
            lbDetalle.Items.Add($"Resibos pediodo {mes} / {año} ");
            laEmpresa.MostrarTodosReciboSueldo(año, mes, lbDetalle );
           
            lbDetalle.Items.Add("-------------------------------------------------------");
            lbDetalle.Items.Add($"TOTAL A PAGAR                   {laEmpresa.VerMontoLiquidacionTotal(mes, año)}");
            lbDetalle.Items.Add("     ");
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Empleado juan = new Empleado("pepe", "juan", 33, 2020);
            Liquidacion liquidar = new Liquidacion(juan, 2025, 7, 5, 5);

            Empresa sistema = new Empresa();

            sistema.GenerarLiquidaciones(7, 2025);
            MessageBox.Show($"Monto {liquidar.ACobrar}");
           
            MessageBox.Show($"Monto {juan.MontoBasicoNominal }");
            MessageBox.Show($"Recibo 33 {sistema.MostrarReciboSueldoPorDNI(33,2025,7, lbDetalle) }"); 
            MessageBox.Show($"Monto {sistema.VerMontoLiquidacionTotal(7,2025) }");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            laEmpresa.listarEmpleados(lbDetalle);
        }

        private void btnListarLiquidacion_Click(object sender, EventArgs e)
        {
            laEmpresa.listarLiquidacion(lbDetalle);
        }
    }
}
