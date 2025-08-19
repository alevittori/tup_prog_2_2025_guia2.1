using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular departamento;
        RegistroVehiculo nuevoRegistro;
        public Form1()
        {
            InitializeComponent();

            departamento = new DepartamentoVehicular();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargarPersona_Click(object sender, EventArgs e)
        {

            //AGREGAR UN CONTROL PARA QUE NO SE REPITAN LOS DNI 



            FDatosPersona VDatosPersona = new FDatosPersona();
            string dni;
            string nombre;
            if(VDatosPersona.ShowDialog() == DialogResult.OK)
            {
                dni = VDatosPersona.tbDNI.Text; // debemos hacer una validacion para que no ingresen otra cosa, en el gormulario de cargar los datos de la persona.
                nombre = VDatosPersona.tbNombre.Text;
                Persona nuevoPropietario = new Persona(dni,nombre);
                nuevoRegistro = departamento.RegistrarVechiculo(nuevoPropietario); // para guardar el registro y agregarlo o no  a la lista, si es que se da click en el boton registrar

                //mostramos los datos en la ventana principal
                lBoxDatosRegistro.Items.Clear();
                lBoxDatosRegistro.Items.Add(nuevoRegistro.VerDetalle());

                
                
            }

            VDatosPersona.Dispose();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Registrar el Vehiculo?", "Registrar", MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.Yes)
            {
                //departamento.
            }
        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< departamento.CantidadRegistros; i++)
            {
                lBoxListado.Items.Add(departamento.VerRegistro(i).VerDetalle());
            }
        }
    }
}
