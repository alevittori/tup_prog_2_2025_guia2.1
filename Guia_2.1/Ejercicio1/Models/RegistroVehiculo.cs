using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class RegistroVehiculo
    {
        public string Patente { get; private set; }
        public string Serie { get; private set; }

        public Persona Propietario { get; private set; }

        public RegistroVehiculo(string nPatente, Persona propietario, int serie)
        {
            this.Patente = nPatente;
            this.Serie = serie.ToString();
            this.Propietario = propietario;

        }

        public string VerDetalle()
        {
            return $"Patente {Patente} - Serie {Serie} - {Propietario.Nombre}(dni: {Propietario.DNI})";
        }

    }
}
