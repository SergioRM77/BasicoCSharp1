using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vehiculo
    {
        public string Nombre { get; set; }
        public int Velocidad { get; set; } = 120;

        public void MostrarVehiculo()
        {
            Console.WriteLine($"El coche es: {Nombre} y su velocidad es: {Velocidad}");
        }
    }
}
