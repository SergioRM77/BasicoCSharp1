/**
 * En C# todo  son Objetos, son instancias de Clases y a su vez estos tienen métodos
 * puede haber funciones estáticas que no pertenezcan a una clase
 */
using Clases;
using Metodos;
using static System.Net.Mime.MediaTypeNames;



Random dice = new Random();
int roll = dice.Next(1, 2147483647);
Console.WriteLine(roll);

//Los métodos pueden ser con estado o sin estado
//con estado (instanciados), dependen de valores o parte del código para poder funcionar, .Next(1,7)
//sin estado, son llamamdos sin necesidad de pasarle arguentos, la clase new Random()

//sobrecarga de métodos -> un método puede recibir, o no, varios tipos de datos diferentes y se adapta
Console.WriteLine(8);
Console.WriteLine();
Console.WriteLine("texto");
//Console.Clear();//limpia el terminal
Console.WriteLine(int.MaxValue);

Persona.InfoPersonas();//Esto es creado dentro de proyecto Metodos (Agregar referencia a proyecto)

Vehiculo vehiculo = new Vehiculo();
vehiculo.Nombre= "Seat Arona";
vehiculo.MostrarVehiculo();//El coche es: Seat Arona y su velocidad es: 120
vehiculo.Velocidad = 150;
vehiculo.MostrarVehiculo();//El coche es: Seat Arona y su velocidad es: 150

