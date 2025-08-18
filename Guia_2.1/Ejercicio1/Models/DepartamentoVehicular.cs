using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class DepartamentoVehicular
    {
        ArrayList registros = new ArrayList();

        public int CantidadRegistros { get; private set; }
        int nuevaSerie = 0;
        string nuevaPatente = "";

        public RegistroVehiculo RegistrarVechiculo(Persona elPropietario)
        {
            this.nuevaSerie = GenerarSerie();

            this.nuevaPatente = GenerarPatente();

            RegistroVehiculo unRegistro = new RegistroVehiculo(this.nuevaPatente, elPropietario, this.nuevaSerie);

            return unRegistro;
        }

        string GenerarPatente()
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string patente = "";
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                patente += $"{letras[rnd.Next(letras.Length)]}";
            }

            //preguntar a que se refiere de forma secuencial, sino deberiamos cambiar esta formula
            for(int i = 0;i < 3; i++)
            {
                patente += $"{rnd.Next(0, 10)}";
            }
            

            return patente;
        }
        int GenerarSerie()
        {
            Random rnd = new Random();

            string serie = "";
            for (int i = 0; i < 9; i++)
            {
                serie += $"{rnd.Next(0, 9)}";
            }

            return int.Parse(serie);
        }
    }
}
