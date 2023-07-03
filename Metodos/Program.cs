
using Metodos;

void Hola() 
{
    Console.WriteLine("hola");
}
Hola();

//Puedo llamar a los métodos públicos y estáticos como este, pertenecen a la clase no al objeto Persona
Persona.InfoPersonas();


Persona persona = new Persona();
persona.Nombre = "Jose";
persona.Edad = 30;

persona.Saludo();

string mensaje = persona.SaberJubilacion();
Console.WriteLine(mensaje);

persona.AnniosRestantes();

mensaje =persona.SaberJubilacion();
Console.WriteLine(mensaje);

Persona persona1 = new Persona();
persona1.Nombre = "Julia";
persona1.Edad = 39;
persona1.Trabajando = true;

persona1.Saludo();

