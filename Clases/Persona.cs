using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Persona
    {
        private int edadJub = 65;
        /*
         * ESTA ES LA MANERA TRADICIONAL
            string nombre;
            int edad;
            bool isTrabajando;

            public Persona(string nombre, int edad, bool? trabajando) 
            {
                this.nombre = nombre;
                this.edad = edad;
                isTrabajando = trabajando;
            }
        */
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool? Trabajando { get; set; }
        //con ? permito que sea null para empezar, si no, por defeto es false

        private int? AnniosParaJubilarse { get; set; }

        /// <summary>
        /// Saludar una vez creada la persona, no retorna nada
        /// </summary>
        public void Saludo()
        {
            Console.WriteLine($"Hola soy {Nombre}, tengo {Edad}, Estoy trabajando?? {Trabajando}");
        }

        /// <summary>
        /// Saber edad restante de Jubilación, es público, se puede acceder,
        /// pero el cálculo es privado
        /// </summary>
        public void AnniosRestantes()
        {
            CalculoAnnios(Edad);
        }

        /// <summary>
        /// Realiza la opercación, pero no es accesible desde fuera
        /// </summary>
        private void CalculoAnnios(int annios)
        {
            AnniosParaJubilarse = edadJub - annios;
        }

        /// <summary>
        /// Retorna string con mensaje
        /// </summary>
        /// <returns></returns>
        public string SaberJubilacion()
        {
            if (AnniosParaJubilarse is null)
                return "Llama al método AnniosRestantes, para saber tu jubilación";

            return "Te quedan de años para jubilarte: " + AnniosParaJubilarse;
        }

        /// <summary>
        /// Método accesible desde la clase, no desde el objeto
        /// </summary>
        public static void InfoPersonas()
        {
            Console.WriteLine("Esto es un mensaje disponible sin necesidad de crear una persona");
        }

    }
}
