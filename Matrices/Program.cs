
using Clases;
/**
* Una matriz es una secuencia de elementos de datos individuales a los que 
* se puede acceder a través de la posición que ocupa. 
*/
string[] nombres = new string[3];

nombres[0] = "Pepe";
nombres[1] = "Mara";
nombres[2] = "Lucas";


//Si queremos añadir uno más nos dará un error, el espacio ya está asignado
//nombres[3] = "Lucía";

//para mostrar un elemento al igual que para cambiar su valor se debe llamar 
nombres[1] = "Luís";
Console.WriteLine(nombres[1]);//Luís

//Es más simple y común usar la versión corta si se sabe los valores a ingresar
int[] nums = { 10, 20, 30, 40, 50, 60, 70 };

//para saber cuantos elementos hay se usa .Length
Console.WriteLine(nums.Length);

/**Para aumentar el array se debe crear un nuevo array con el numero de elementos +
 * el número que se quiera redimensionar, luego con un bucle se puede guardar los elementos
 * en el nuevo, pero esto no es eficiente si se redimensiona constantemente
*/
int[] nuevoNums = new int[nums.Length + 5];
for (int i = 0; i < nums.Length; i++)
    nuevoNums[i] = nums[i];
foreach (int n in nuevoNums)
    Console.Write(n + " ");//10 20 30 40 50 60 70 0 0 0 0 0

//LIST<T>
//Las listas son colecciones de datos del mismo tipo, donde <T> se indica el tipo
//Se puede redimensionar, con Add() o Remove(), entre otras cosas...

List<string> nombres2 = new List<string>();
nombres2.Add("Juan");
nombres2.Add("Laura");
nombres2.Add("Luis");
nombres2.Add("Jorge");

Console.WriteLine("\nNumero de nombres en lista: " + nombres2.Count());
nombres2.Remove("Luis");
Console.WriteLine($"Numero de nombres en lista: {nombres2.Count()}, " +
    $"Existe Luis? {nombres2.Contains("Luis")}, Existe Laura? {nombres2.Contains("Laura")}");

/*Hay muchos métodos más como Clear() para borrar toda la lista,
 Find() encontrar el primero,
 Insert() para insertar un elemento en un sitio concreto...
*/
Vehiculo coche1 = new Vehiculo();
Vehiculo coche2 = new Vehiculo();
Vehiculo coche3 = new Vehiculo();
Vehiculo coche4 = new Vehiculo();
Vehiculo coche5 = new Vehiculo();

coche1.Nombre = "Seat";
coche2.Nombre = "Ford";
coche3.Nombre = "Suzuki";
coche4.Nombre = "Mercedes";
coche5.Nombre = "Audi";
coche5.Velocidad = 180;

var listaCoches = new List<Vehiculo> 
{
    coche1 , coche2 , coche3 , coche4 , coche5 
};

//Nota importante, si no encuentra coincidencias da error, comprobar primero
var coche = listaCoches.Find(coche => coche.Velocidad == 180);
coche.MostrarVehiculo();

Console.WriteLine();

var coches2 = listaCoches.FindAll(coche => coche.Velocidad == 120 && coche.Nombre != "Seat");
foreach (var vh in coches2)
    vh.MostrarVehiculo();

/**
 * Remove() -> quitar objeto de lista
 * RemoveAt() -> quitar objeto por índice
 * RemoveAll() -> quitar todo
 * RemoveRange() -> quitar elementos por índice y número de elementos a borrar
 * ...
 */