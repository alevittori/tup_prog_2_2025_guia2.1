using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; private set; }

        public Persona(string dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        public string VerDatos()
        {
            return $"{Nombre}(dni: { DNI}";
        }
    }
}
